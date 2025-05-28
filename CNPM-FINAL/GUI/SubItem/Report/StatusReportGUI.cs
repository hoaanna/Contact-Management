using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Report
{
    public partial class StatusReportGUI : Form
    {
        #region properties
        private readonly ReportBLL reportBLL = new ReportBLL();
        private readonly FileBLL fileBLL = new FileBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private readonly Dictionary<string, List<string>> contractStatus = new Dictionary<string, List<string>>
        {
            {"en", new List<string> { "New", "In Progress", "Completed" } },
            {"vi", new List<string> { "Mới", "Đang tiến hành", "Hoàn tất" } }
        };
        #endregion

        public StatusReportGUI()
        {
            InitializeComponent();
            RenderList();
            InitTextContent();

            this.dateTimePickerFrom.Enabled = this.dateTimePickerTo.Enabled
                = this.checkBoxExpirationDate.Checked || this.checkBoxSignedDate.Checked;

            this.comboBoxStatus.Enabled = this.checkBoxStatus.Checked;
        }

        #region language
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (this.MdiParent is MainGUI mainForm)
            {
                mainForm.LanguageChanged += MainForm_LanguageChanged;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (this.MdiParent is MainGUI mainForm)
            {
                mainForm.LanguageChanged -= MainForm_LanguageChanged;
            }
        }

        private void MainForm_LanguageChanged(object sender, EventArgs e)
        {
            InitTextContent();
        }
        #endregion

        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.STATUS_REPORT_GUI, typeof(StatusReportGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("lbTitle");
            this.lbSearch.Text = GetLocalizedString("lbSearch");
            this.checkBoxSignedDate.Text = GetLocalizedString("checkBoxSignedDate");
            this.checkBoxExpirationDate.Text = GetLocalizedString("checkBoxExpirationDate");
            this.checkBoxStatus.Text = GetLocalizedString("checkBoxStatus");
            this.btnFile.Text = GetLocalizedString("btnFile");

            this.columnContractCode.HeaderText = GetLocalizedString("columnContractCode");
            this.columnContractName.HeaderText = GetLocalizedString("columnContractName");
            this.columnOrgnization.HeaderText = GetLocalizedString("columnOrganization");
            this.columnStatus.HeaderText = GetLocalizedString("columnStatus");
            this.columnSignedDate.HeaderText = GetLocalizedString("columnSignedDate");
            this.columnExpirationDate.HeaderText = GetLocalizedString("columnExpirationDate");

            this.comboBoxStatus.Items.Clear();
            this.comboBoxStatus.Items.AddRange(contractStatus[SettingContext.Language].ToArray());
            this.comboBoxStatus.SelectedIndex = 0;

            this.lbSearchErr.Text = this.lbSearchErr.Text = "";

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var statusCell = dataGridView.Rows[i].Cells["columnStatus"];
                if (statusCell.Value != null)
                {
                    string status = statusCell.Value.ToString();
                    string language = contractStatus["vi"].Contains(status) ? "vi" : "en";
                    int index = contractStatus[language].IndexOf(status);
                    statusCell.Value = contractStatus[SettingContext.Language][index];
                }
            }
        }

        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);
        private void RenderList(string keyword = "")
        {
            try
            {
                dataGridView.Rows.Clear();
                if (checkBoxSignedDate.Checked || checkBoxExpirationDate.Checked)
                {
                    if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
                    {
                        this.lbFilterErr.Text = GetLocalizedString("lbDateErr");
                        return;
                    }
                }

                var status = checkBoxStatus.Checked ? contractStatus["en"][comboBoxStatus.SelectedIndex] : null;
                var contracts = reportBLL.GetContracts(keyword, dateTimePickerFrom.Value, dateTimePickerTo.Value,
                    checkBoxSignedDate.Checked, checkBoxExpirationDate.Checked, status);

                if (contracts.Count == 0)
                {
                    this.lbSearchErr.Text = GetLocalizedString("noResults");
                    return;
                }

                foreach (var contract in contracts)
                {
                    var statusIndex = contractStatus["en"].IndexOf(contract.contractStatus);
                    var statusValue = contractStatus[SettingContext.Language][statusIndex];
                    dataGridView.Rows.Add(contract.contractCode, contract.contractName, contract.organizationName,
                        contract.signedDate.ToString("dd/MM/yyyy"), contract.expirationDate.ToString("dd/MM/yyyy"), statusValue);
                }

            }
            catch (Exception) { }
        }

        #region text events
        private void textBoxSearch_Click(object sender, EventArgs e) => this.lbSearchErr.Text = "";

        private void checkBoxSignedDate_CheckedChanged(object sender, EventArgs e) => this.dateTimePickerFrom.Enabled = this.dateTimePickerTo.Enabled
            = this.checkBoxSignedDate.Checked || this.checkBoxExpirationDate.Checked;

        private void checkBoxExpirationDate_CheckedChanged(object sender, EventArgs e) => this.dateTimePickerFrom.Enabled = this.dateTimePickerTo.Enabled
            = this.checkBoxSignedDate.Checked || this.checkBoxExpirationDate.Checked;

        private void dateTime_Event(object sender, EventArgs e) => this.lbFilterErr.Text = "";

        private void debounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            RenderList(textBoxSearch.Text.Trim());
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.lbSearchErr.Text = "";
            this.debounceTimer.Stop();
            this.debounceTimer.Start();
        }

        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e) => this.comboBoxStatus.Enabled = this.checkBoxStatus.Checked;
        #endregion

        #region button events
        private void btnFile_Click(object sender, EventArgs e) => this.fileContainer.Visible = !this.fileContainer.Visible;

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.Rows.Count == 0)
            {
                MessageBox.Show(GetLocalizedString("noData"), "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save excel file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileBLL.ExportDataGridViewToExcel(dataGridView, saveFileDialog.FileName);
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (this.dataGridView.Rows.Count == 0)
            {
                MessageBox.Show(GetLocalizedString("noData"), "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save PDF file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileBLL.ExportDataGridViewToPdf(dataGridView, saveFileDialog.FileName);
                }
            }
        }
        #endregion
    }
}
