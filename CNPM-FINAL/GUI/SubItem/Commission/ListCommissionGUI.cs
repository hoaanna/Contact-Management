using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Commission
{
    public partial class ListCommissionGUI : Form
    {
        private readonly CommissionBLL commissionBLL = new CommissionBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private readonly FileBLL fileBLL = new FileBLL();

        public ListCommissionGUI()
        {
            InitializeComponent();
            RenderList();
            InitTextContent();

            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "MM/yyyy";
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "MM/yyyy";
            dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled
                = checkBoxFilter.Checked;
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

        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.LIST_COMMISSION, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.lbSearch.Text = GetLocalizedString("lbSearch");
            this.checkBoxFilter.Text = GetLocalizedString("lbFilter");

            this.btnGetAll.Text = GetLocalizedString("btnGetAll");
            this.btnFile.Text = GetLocalizedString("btnFile");

            this.columnContractCode.HeaderText = GetLocalizedString("columnContractCode");
            this.columnCommissionDate.HeaderText = GetLocalizedString("columnDate");
            this.columnStageName.HeaderText = GetLocalizedString("columnStageName");
            this.columnPercentage.HeaderText = GetLocalizedString("columnCommission");
            this.columnCommissionAmount.HeaderText = GetLocalizedString("columnAmount");
            this.columnStatus.HeaderText = GetLocalizedString("columnStatus");

            this.lbSearchErr.Text = GetLocalizedString("lbSearchErr");
            this.lbFilterErr.Text = GetLocalizedString("invalidDate");
        }
        #endregion

        #region methods
        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);

        private bool ValidateDateTime()
        {
            lbFilterErr.Text = GetLocalizedString("invalidDate");
            if (dateTimePickerFrom.Value.Year > dateTimePickerTo.Value.Year ||
                (dateTimePickerFrom.Value.Year == dateTimePickerTo.Value.Year && dateTimePickerFrom.Value.Month > dateTimePickerTo.Value.Month))
            {
                lbFilterErr.Visible = true;
                return false;
            }
            lbFilterErr.Visible = false;
            return true;
        }

        private void AddRows(List<CommissionDTO> commissions)
        {
            dataGridViewCommission.Rows.Clear();
            if (commissions.Count == 0)
            {
                lbSearchErr.Visible = true;
                lbSearchErr.Text = GetLocalizedString("lbSearchErr");
                return;
            }

            lbSearchErr.Visible = false;
            foreach (var commission in commissions)
            {
                var amount = commission.commissionAmount.ToString("#,##0");
                dataGridViewCommission.Rows.Add(commission.contractCode, commission.paymentStageName,
                    commission.commissionDate.ToString("MM/yyyy"), commission.commissionPercentage,
                    amount, commission.status);
            }
        }

        private void RenderList(string keyword = "")
        {
            try
            {
                if (!checkBoxFilter.Checked)
                {
                    lbFilterErr.Visible = false;
                    AddRows(commissionBLL.GetAll(keyword));
                    return;
                }

                if (!ValidateDateTime())
                    return;

                lbFilterErr.Visible = false;
                var listCommission = commissionBLL.GetAll(keyword, dateTimePickerFrom.Value, dateTimePickerTo.Value);
                AddRows(listCommission);
            }
            catch (Exception) { }
        }
        #endregion

        #region text events
        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e) => dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled = checkBoxFilter.Checked;
        private void textBoxSearch_Event(object sender, EventArgs e) => lbSearchErr.Text = "";
        private void dateTimePicker_Event(object sender, EventArgs e) => lbFilterErr.Text = "";
        #endregion

        #region debounce
        private void debounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            RenderList(this.textBoxSearch.Text.Trim());
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.lbSearchErr.Text = "";
            debounceTimer.Stop();
            debounceTimer.Start();
        }
        #endregion

        #region button events
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            lbSearchErr.Visible = false;
            RenderList();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCommission.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save excel file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileBLL.ExportDataGridViewToExcel(dataGridViewCommission, saveFileDialog.FileName);
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCommission.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save PDF file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileBLL.ExportDataGridViewToPdf(dataGridViewCommission, saveFileDialog.FileName);
                }
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            this.fileContainer.Visible = !this.fileContainer.Visible;
        }
        #endregion
    }
}
