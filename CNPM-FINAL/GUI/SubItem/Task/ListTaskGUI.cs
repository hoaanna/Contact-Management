using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using CNPM_FINAL.Event;
using CNPM_FINAL.GUI.SubItem.Commission;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Task
{
    public partial class ListTaskGUI : Form
    {
        #region properties
        private readonly TaskProgressBLL taskProgressBLL = new TaskProgressBLL();
        private readonly FileBLL fileBLL = new FileBLL();
        public event EventHandler<TaskDetailEventArgs> OpenTaskDetail;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        #endregion

        public ListTaskGUI()
        {
            InitializeComponent();
            RenderList();
            InitTextContent();

            dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled
                = checkBoxSignedDate.Checked = checkBoxExpirationDate.Checked;
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
        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);
        public void ClearRows() => dataGridViewTask.Rows.Clear();

        private bool ValidateDateTime()
        {
            if (dateTimePickerFrom.Value.Date > dateTimePickerTo.Value.Date)
            {
                lbFilterErr.Text = GetLocalizedString("invalidDate");
                return false;
            }

            return true;
        }

        private void AddRows(List<TaskProgressDTO> tasks)
        {
            dataGridViewTask.Rows.Clear();
            if (tasks.Count == 0)
            {
                lbSearchErr.Text = GetLocalizedString("lbSearchErr");
                return;
            }
            foreach (var task in tasks)
            {
                dataGridViewTask.Rows.Add(task.contractCode, task.contractName,
                    task.signedDate.ToString("dd/MM/yyyy"), task.expirationDate.ToString("dd/MM/yyyy"),
                    task.contractOrganization, task.percentage);
            }
        }

        private void RenderList(string keyword = "")
        {
            if (checkBoxSignedDate.Checked || checkBoxExpirationDate.Checked)
            {
                if (!ValidateDateTime())
                    return;
            }

            try
            {
                var listTask = taskProgressBLL.GetAll(keyword, dateTimePickerFrom.Value, dateTimePickerTo.Value,
                        checkBoxSignedDate.Checked, checkBoxExpirationDate.Checked);
                AddRows(listTask);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region init
        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.LIST_TASK, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.lbSearch.Text = GetLocalizedString("lbSearch");
            var signedDate = GetLocalizedString("lbSignedDate");
            this.checkBoxSignedDate.Text = GetLocalizedString("lbSignedDate");
            this.checkBoxExpirationDate.Text = GetLocalizedString("lbExpirationDate");
            this.btnGetAll.Text = GetLocalizedString("btnGetAll");
            this.btnFile.Text = GetLocalizedString("btnFile");

            this.columnContractCode.HeaderText = GetLocalizedString("columnContractCode");
            this.columnContractName.HeaderText = GetLocalizedString("columnContractName");
            this.columnSignedDate.HeaderText = GetLocalizedString("columnSignedDate");
            this.columnExpirationDate.HeaderText = GetLocalizedString("columnExpirationDate");
            this.columnOrganization.HeaderText = GetLocalizedString("columnOrganization");
            this.columnPercentage.HeaderText = GetLocalizedString("columnPercentage");
            this.columnIconDetail.HeaderText = GetLocalizedString("columnIconDetail");

            this.lbSearchErr.Text = this.lbFilterErr.Text = "";
        }
        #endregion

        #region dataGridView
        private void dataGridViewTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewTask.Columns["columnIconDetail"].Index && e.RowIndex >= 0)
            {
                OpenTaskDetail?.Invoke(this,
                    new TaskDetailEventArgs(dataGridViewTask.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }
        }
        #endregion

        #region others
        private void textBoxSearch_Event(object sender, EventArgs e) => lbSearchErr.Text = "";
        private void dateTimePicker_Event(object sender, EventArgs e) => lbFilterErr.Text = "";
        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            this.lbFilterErr.Text = "";
            dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled
                = checkBoxExpirationDate.Checked || checkBoxSignedDate.Checked;
        }

        private void checkBoxEndDate_CheckedChanged(object sender, EventArgs e)
        {
            this.lbFilterErr.Text = "";
            dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled
                = checkBoxExpirationDate.Checked || checkBoxSignedDate.Checked;
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewTask.Rows.Count == 0)
            {
                var message = SettingContext.Language == "vi" ?
                    "Không có dữ liệu để xuất" : "No data to export";
                MessageBox.Show(message, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save excel file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<int> excludedColumns = new List<int> { 6 };
                    fileBLL.ExportDataGridViewToExcel(dataGridViewTask, saveFileDialog.FileName, excludedColumns);
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewTask.Rows.Count == 0)
            {
                var message = SettingContext.Language == "vi" ?
                    "Không có dữ liệu để xuất" : "No data to export";
                MessageBox.Show(message, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save PDF file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<int> excludedColumns = new List<int> { 6 };
                    fileBLL.ExportDataGridViewToPdf(dataGridViewTask, saveFileDialog.FileName, excludedColumns);
                }
            }
        }

        private void btnFile_Click(object sender, EventArgs e) => this.fileContainer.Visible = !this.fileContainer.Visible;
        #endregion
    }
}
