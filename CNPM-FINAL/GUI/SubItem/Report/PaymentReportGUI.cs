using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using System;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Report
{
    public partial class PaymentReportGUI : Form
    {
        private readonly ReportBLL reportBLL = new ReportBLL();
        private readonly FileBLL fileBLL = new FileBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;

        public PaymentReportGUI()
        {
            InitializeComponent();
            RenderListPayments();
            InitTextContent();

            this.dateTimePickerFrom.Enabled = this.dateTimePickerTo.Enabled
                = this.checkBoxDate.Checked;
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
            resourceManager = new ResourceManager(ResourceContext.PAYMENT_REPORT_GUI, typeof(PaymentReportGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("lbTitle");
            this.lbSearch.Text = GetLocalizedString("lbSearch");
            this.checkBoxDate.Text = GetLocalizedString("checkBoxDate");
            this.btnFile.Text = GetLocalizedString("btnFile");

            this.columnContractCode.HeaderText = GetLocalizedString("columnContractCode");
            this.columnContractName.HeaderText = GetLocalizedString("columnContractName");
            this.columnPaymentDate.HeaderText = GetLocalizedString("columnPaymentDate");
            this.columnStageName.HeaderText = GetLocalizedString("columnStageName");
            this.columnAmount.HeaderText = GetLocalizedString("columnAmount");
            this.columnPercentage.HeaderText = GetLocalizedString("columnPercentage");

            this.lbSearchErr.Text = this.lbSearchErr.Text = "";
        }

        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);

        private void textBoxSearch_Click(object sender, EventArgs e) => this.lbSearchErr.Text = "";

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e) => this.dateTimePickerFrom.Enabled = this.dateTimePickerTo.Enabled
            = this.checkBoxDate.Checked;

        private void dateTime_Event(object sender, EventArgs e) => this.lbFilterErr.Text = "";

        private void debounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            RenderListPayments(textBoxSearch.Text.Trim());
        }

        private void RenderListPayments(string keyword = "")
        {
            try
            {
                dataGridView.Rows.Clear();
                if (checkBoxDate.Checked)
                {
                    if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
                    {
                        this.lbFilterErr.Text = GetLocalizedString("lbDateErr");
                        return;
                    }
                }

                var payments = reportBLL.GetPayments(keyword, dateTimePickerFrom.Value,
                    dateTimePickerTo.Value, checkBoxDate.Checked);

                if (payments.Count == 0)
                {
                    this.lbSearchErr.Text = GetLocalizedString("noResults");
                    return;
                }

                foreach (var payment in payments)
                {
                    dataGridView.Rows.Add(payment.contractCode, payment.contractName, payment.stageName,
                        payment.paymentDate.ToString("dd/MM/yyyy"), payment.paymentValue,
                        payment.paymentPercentage);
                }

            }
            catch (Exception) { }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.lbSearchErr.Text = "";
            this.debounceTimer.Stop();
            this.debounceTimer.Start();
        }

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
    }
}
