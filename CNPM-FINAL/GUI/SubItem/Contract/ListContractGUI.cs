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

namespace CNPM_FINAL.GUI.SubItem.Contract
{
    public partial class ListContractGUI : Form
    {
        #region properties
        public event EventHandler<ContractEventArgs> UpdateContractEvent;
        private ContractDTO referancedContract;
        private readonly ContractBLL contractBLL = new ContractBLL();
        private readonly FileBLL fileBLL = new FileBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private Dictionary<string, string> contractStatusVi = new Dictionary<string, string>
        {
            { "New", "Mới" },
            { "In Progress", "Đang tiến hành" },
            { "Completed", "Hoàn thành" }
        };
        #endregion

        public ListContractGUI()
        {
            InitializeComponent();
            RenderList();
            InitTextContent();

            dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled = checkBoxSignedDate.Checked = checkBoxExpirationDate.Checked;
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

        #region init
        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.LIST_CONTRACT, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.lbSearch.Text = GetLocalizedString("lbSearch");
            this.checkBoxSignedDate.Text = GetLocalizedString("lbSignedDate");
            this.checkBoxExpirationDate.Text = GetLocalizedString("lbExpirationDate");
            this.btnGetAll.Text = GetLocalizedString("btnGetAll");
            this.btnFile.Text = GetLocalizedString("btnFile");

            this.columnCommissionPercentage.HeaderText = GetLocalizedString("columnCommission");
            this.columnContactEmail.HeaderText = GetLocalizedString("columnEmail");
            this.columnContactPhone.HeaderText = GetLocalizedString("columnPhone");
            this.columnContractCode.HeaderText = GetLocalizedString("columnContractCode");
            this.columnContractName.HeaderText = GetLocalizedString("columnContractName");
            this.columnStatus.HeaderText = GetLocalizedString("columnStatus");
            this.columnExpiredDate.HeaderText = GetLocalizedString("columnExpirationDate");
            this.columnIconDelete.HeaderText = GetLocalizedString("columnIconDelete");
            this.columnIconUpdate.HeaderText = GetLocalizedString("columnIconUpdate");
            this.columnPartner.HeaderText = GetLocalizedString("columnPartner");
            this.columnSignedDate.HeaderText = GetLocalizedString("columnSignedDate");
            this.columnTotalValue.HeaderText = GetLocalizedString("columnTotalValue");


            for (int i = 0; i < dataGridViewContract.Rows.Count; i++)
            {
                var statusCell = dataGridViewContract.Rows[i].Cells["columnStatus"];
                if (statusCell.Value != null)
                {
                    string status = statusCell.Value.ToString();

                    if (SettingContext.Language == "vi" && contractStatusVi.ContainsKey(status))
                    {
                        statusCell.Value = contractStatusVi[status];
                    }
                    else if (SettingContext.Language == "en" && contractStatusVi.ContainsValue(status))
                    {
                        statusCell.Value = contractStatusVi.FirstOrDefault(x => x.Value == status).Key;
                    }
                }
            }
        }
        #endregion

        #region methods
        public void ClearRows() => dataGridViewContract.Rows.Clear();

        private bool ValidateDateTime()
        {
            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                lbFilterErr.Text = GetLocalizedString("invalidDate");
                return false;
            }

            return true;
        }

        private void AddRows(List<ContractDTO> contracts)
        {
            dataGridViewContract.Rows.Clear();
            if (contracts.Count == 0)
            {
                lbSearchErr.Text = GetLocalizedString("lbSearchErr");
                return;
            }

            foreach (var contract in contracts)
            {
                string status = SettingContext.Language == "vi" ? contractStatusVi[contract.status] : contract.status;
                dataGridViewContract.Rows.Add(contract.contractCode, contract.contractName, status,
                    contract.commissionPercentage, contract.signedDate.ToString("dd/MM/yyyy"), contract.expiredDate.ToString("dd/MM/yyyy"),
                    contract.partnerName, contract.contactEmail, contract.contactPhone, contract.totalValue.ToString("#,0")
                );
            }
        }
        private void RenderList(string keyword = "")
        {
            try
            {
                if (checkBoxSignedDate.Checked || checkBoxExpirationDate.Checked)
                {
                    if (!ValidateDateTime())
                        return;
                }

                var listContract = contractBLL.GetAll(keyword, dateTimePickerFrom.Value.Date, dateTimePickerTo.Value.Date,
                    checkBoxSignedDate.Checked, checkBoxExpirationDate.Checked);
                AddRows(listContract);
            }
            catch (Exception) { }
        }
        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);
        #endregion

        #region text events
        private void textBoxSearch_Event(object sender, EventArgs e) => lbSearchErr.Text = "";
        private void dateTimePicker_Event(object sender, EventArgs e) => lbFilterErr.Text = "";
        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e) => dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled
            = checkBoxSignedDate.Checked || checkBoxExpirationDate.Checked;

        private void checkBoxExpirationDate_CheckedChanged(object sender, EventArgs e) => dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled
            = checkBoxSignedDate.Checked || checkBoxExpirationDate.Checked;

        private void dataGridViewContract_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridViewContract.Columns["columnIconDelete"].Index && e.RowIndex >= 0)
            {
                if (!UserContext.GetPermissions().Contains("DELETE_Contract"))
                {
                    MessageBox.Show(GetLocalizedString("roleErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int rowIndex = e.RowIndex;
                string contractCode = dataGridViewContract.Rows[rowIndex].Cells["columnContractCode"].Value.ToString();

                try
                {
                    var result = MessageBox.Show(resourceManager.GetString("warning", cultureInfo), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        contractBLL.Delete(contractCode);
                        dataGridViewContract.Rows.RemoveAt(rowIndex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                return;
            }

            if (e.ColumnIndex == dataGridViewContract.Columns["columnIconUpdate"].Index && e.RowIndex >= 0)
            {
                if (!UserContext.GetPermissions().Contains("UPDATE_Contract"))
                {
                    MessageBox.Show(GetLocalizedString("roleErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int rowIndex = e.RowIndex;
                string contractCode = dataGridViewContract.Rows[rowIndex].Cells["columnContractCode"].Value.ToString();

                try
                {
                    referancedContract = contractBLL.GetOneByCode(contractCode);
                    if (referancedContract == null)
                    {
                        MessageBox.Show(resourceManager.GetString("updateErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    UpdateContractEvent?.Invoke(this, new ContractEventArgs(referancedContract));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        #endregion

        #region debounce
        private void debounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            RenderList(textBoxSearch.Text.Trim());
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            this.lbSearchErr.Text = "";
            debounceTimer.Stop();
            debounceTimer.Start();
        }
        #endregion

        #region button events
        private void btnGetAll_Click(object sender, EventArgs e) => RenderList();
        private void btnFile_Click(object sender, EventArgs e)
        {
            this.fileContainer.Visible = !this.fileContainer.Visible;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewContract.Rows.Count == 0)
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
                    List<int> excludedColumns = new List<int> { 10, 11 };
                    fileBLL.ExportDataGridViewToExcel(dataGridViewContract, saveFileDialog.FileName, excludedColumns);
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewContract.Rows.Count == 0)
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
                    List<int> excludedColumns = new List<int> { 10, 11 };
                    fileBLL.ExportDataGridViewToPdf(dataGridViewContract, saveFileDialog.FileName, excludedColumns);
                }
            }
        }
        #endregion
    }
}
