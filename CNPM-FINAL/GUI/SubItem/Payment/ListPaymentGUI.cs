using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using CNPM_FINAL.Event;
using CNPM_FINAL.GUI.SubItem.Commission;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Payment
{
    public partial class ListPaymentGUI : Form
    {
        public event EventHandler<PaymentEventArgs> UpdatePaymentEvent;
        private readonly PaymentStageBLL paymentStageBLL = new PaymentStageBLL();
        private readonly FileBLL fileBLL = new FileBLL();
        private PaymentStageDTO referancedPayment;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private Dictionary<string, string> paymentStatusVi = new Dictionary<string, string>
        {
            {"Unpaid", "Chưa thanh toán" },
            {"Completed", "Đã thanh toán" }
        };

        public ListPaymentGUI()
        {
            InitializeComponent();
            RenderList();
            InitTextContent();

            dateTimePickerFrom.Value = DateTime.Now.Date;
            dateTimePickerTo.Value = DateTime.Now.Date;
            dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled = checkBoxFilter.Checked;
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

        #region methods
        public void ClearRows() => dataGridViewPaymentStage.Rows.Clear();
        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);

        private bool ValidateDateTime()
        {
            lbFilterErr.Text = GetLocalizedString("invalidDate");
            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                lbFilterErr.Visible = true;

                return false;
            }
            lbFilterErr.Visible = false;
            return true;
        }

        private void RenderList(string keyword = "")
        {
            try
            {
                if (!checkBoxFilter.Checked)
                {
                    lbFilterErr.Visible = false;
                    AddRows(paymentStageBLL.GetAll(keyword));
                    return;
                }

                lbFilterErr.Visible = false;
                if (!ValidateDateTime())
                    return;

                var listPayment = paymentStageBLL.GetAll(keyword, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date);
                AddRows(listPayment);
            }
            catch (Exception) { }
        }

        private void AddRows(List<PaymentStageDTO> payments)
        {
            dataGridViewPaymentStage.Rows.Clear();
            if (payments.Count == 0)
            {
                lbSearchErr.Visible = true;
                lbSearchErr.Text = GetLocalizedString("lbSearchErr");
                return;
            }

            lbSearchErr.Visible = false;
            foreach (var payment in payments)
            {
                var status = SettingContext.Language == "vi" ? paymentStatusVi[payment.status] : payment.status;
                dataGridViewPaymentStage.Rows.Add(payment.id, payment.contractCode, payment.stageName, payment.description,
                    payment.paymentDate.ToString("dd/MM/yyyy"), ((decimal)payment.amount).ToString("#,0"), payment.percentage, status);
            }
        }
        #endregion

        #region init
        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.LIST_PAYMENT, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.lbSearch.Text = GetLocalizedString("lbSearch");
            this.checkBoxFilter.Text = GetLocalizedString("lbFilter");
            this.btnGetAll.Text = GetLocalizedString("btnGetAll");
            this.btnFile.Text = GetLocalizedString("btnFile");

            this.columnAmount.HeaderText = GetLocalizedString("columnAmount");
            this.columnContractCode.HeaderText = GetLocalizedString("columnContractCode");
            this.columnDescription.HeaderText = GetLocalizedString("columnDescription");
            this.columnIconDelete.HeaderText = GetLocalizedString("columnIconDelete");
            this.columnIconUpdate.HeaderText = GetLocalizedString("columnIconUpdate");
            this.columnPaymentDate.HeaderText = GetLocalizedString("columnDate");
            this.columnStageName.HeaderText = GetLocalizedString("columnStageName");
            this.columnStatus.HeaderText = GetLocalizedString("columnStatus");
            this.columnPercentage.HeaderText = GetLocalizedString("columnPercentage");

            for (int i = 0; i < dataGridViewPaymentStage.Rows.Count; i++)
            {
                var statusCell = dataGridViewPaymentStage.Rows[i].Cells["columnStatus"];
                if (statusCell.Value != null)
                {
                    string status = statusCell.Value.ToString();

                    if (SettingContext.Language == "vi" && paymentStatusVi.ContainsKey(status))
                    {
                        statusCell.Value = paymentStatusVi[status];
                    }
                    else if (SettingContext.Language == "en" && paymentStatusVi.ContainsValue(status))
                    {
                        statusCell.Value = paymentStatusVi.FirstOrDefault(x => x.Value == status).Key;
                    }
                }
            }

            lbFilterErr.Text = GetLocalizedString("invalidDate");
            lbSearchErr.Text = GetLocalizedString("lbSearchErr");
        }
        #endregion

        #region data event
        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e) => this.dateTimePickerFrom.Enabled = this.dateTimePickerTo.Enabled = checkBoxFilter.Checked;
        private void textBoxSearch_Event(object sender, EventArgs e) => lbSearchErr.Text = "";
        private void dateTimePicker_Event(object sender, EventArgs e) => lbFilterErr.Text = "";
        #endregion

        #region datagridview event
        private void dataGridViewPaymentStage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewPaymentStage.Columns["columnIconDelete"].Index && e.RowIndex >= 0)
            {
                if (!UserContext.GetPermissions().Contains("DELETE_Payment"))
                {
                    MessageBox.Show(GetLocalizedString("roleErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int rowIndex = e.RowIndex;
                if (!int.TryParse(dataGridViewPaymentStage.Rows[rowIndex].Cells["columnPaymentStageId"].Value.ToString(), out int taskId))
                {
                    MessageBox.Show("Invalid id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    var result = MessageBox.Show(GetLocalizedString("warning"), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        paymentStageBLL.Delete(taskId);
                        dataGridViewPaymentStage.Rows.RemoveAt(rowIndex);
                    }
                }
                catch (BuisinessException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Undefined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (e.ColumnIndex == dataGridViewPaymentStage.Columns["columnIconUpdate"].Index && e.RowIndex >= 0)
            {
                if (!UserContext.GetPermissions().Contains("UPDATE_Payment"))
                {
                    MessageBox.Show(GetLocalizedString("roleErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int rowIndex = e.RowIndex;
                if (!int.TryParse(dataGridViewPaymentStage.Rows[rowIndex].Cells["columnPaymentStageId"].Value.ToString(), out int taskId))
                {
                    MessageBox.Show("Invalid id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    referancedPayment = paymentStageBLL.GetById(taskId);
                    if (referancedPayment == null)
                    {
                        MessageBox.Show(GetLocalizedString("updateErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    UpdatePaymentEvent?.Invoke(this, new PaymentEventArgs(referancedPayment));
                }
                catch (BuisinessException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Undefined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
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
            if (this.dataGridViewPaymentStage.Rows.Count == 0)
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
                    List<int> excludedColumns = new List<int> { 0, 7, 8 };
                    fileBLL.ExportDataGridViewToExcel(dataGridViewPaymentStage, saveFileDialog.FileName, excludedColumns);
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewPaymentStage.Rows.Count == 0)
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
                    List<int> excludedColumns = new List<int> { 0, 7, 8 };
                    fileBLL.ExportDataGridViewToPdf(dataGridViewPaymentStage, saveFileDialog.FileName, excludedColumns);
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
