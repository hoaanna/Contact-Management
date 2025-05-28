using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using System;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Report
{
    public partial class QuantityReportGUI : Form
    {
        private readonly ReportBLL reportBLL = new ReportBLL();
        private readonly FileBLL fileBLL = new FileBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;

        public QuantityReportGUI()
        {
            InitializeComponent();
            RenderList();
            InitTextContent();

            this.dateTimePickerFrom.Enabled = this.dateTimePickerTo.Enabled
                = this.checkBoxExpirationDate.Checked || this.checkBoxSignedDate.Checked;
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
            resourceManager = new ResourceManager(ResourceContext.QUANTITY_REPORT_GUI, typeof(QuantityReportGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("lbTitle");
            this.lbSearch.Text = GetLocalizedString("lbSearch");
            this.checkBoxSignedDate.Text = GetLocalizedString("checkBoxSignedDate");
            this.checkBoxExpirationDate.Text = GetLocalizedString("checkBoxExpirationDate");
            this.btnFile.Text = GetLocalizedString("btnFile");

            this.columnContractCode.HeaderText = GetLocalizedString("columnContractCode");
            this.columnContractName.HeaderText = GetLocalizedString("columnContractName");
            this.columnSignedDate.HeaderText = GetLocalizedString("columnSignedDate");
            this.columnExpirationDate.HeaderText = GetLocalizedString("columnExpirationDate");
            this.columnOrganization.HeaderText = GetLocalizedString("columnOrganization");
            this.columnPartner.HeaderText = GetLocalizedString("columnPartnerName");
            this.columnPhone.HeaderText = GetLocalizedString("columnPhone");

            this.lbSearchErr.Text = this.lbSearchErr.Text = "";
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

                var contracts = reportBLL.GetContracts(keyword, dateTimePickerFrom.Value, dateTimePickerTo.Value,
                    checkBoxSignedDate.Checked, checkBoxExpirationDate.Checked);

                if (contracts.Count == 0)
                {
                    this.lbSearchErr.Text = GetLocalizedString("noResults");
                    return;
                }

                foreach (var contract in contracts)
                {
                    dataGridView.Rows.Add(contract.contractCode, contract.contractName, contract.signedDate.ToString("dd/MM/yyyy"),
                        contract.expirationDate.ToString("dd/MM/yyyy"), contract.organizationName,
                        contract.partner, contract.email, contract.phone);
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
