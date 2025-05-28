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

namespace CNPM_FINAL.GUI.SubItem.Task
{
    public partial class ListTaskDetailGUI : Form
    {
        #region properties
        private readonly TaskProgressBLL taskProgressBLL = new TaskProgressBLL();
        private readonly string contractCode;
        private readonly FileBLL fileBLL = new FileBLL();
        private TaskProgressDTO referencedTask = null;
        public event EventHandler<TaskEventArgs> UpdateTaskEvent;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private Dictionary<string, string> taskStatusVi = new Dictionary<string, string>
        {
            { "In Progress", "Đang thực hiện" },
            { "Completed", "Đã hoàn thành" },
            { "Canceled", "Đã hủy" }
        };
        #endregion

        public ListTaskDetailGUI(string contractCode)
        {
            this.contractCode = contractCode;
            InitializeComponent();
            RenderList();
            InitTextContent();

            dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled
                = checkBoxStartDate.Checked = checkBoxEndDate.Checked;
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
                var status = SettingContext.Language == "vi" ? 
                    taskStatusVi[task.status] : task.status;

                dataGridViewTask.Rows.Add(task.id, task.contractCode, task.taskName,
                    task.startDate.ToString("dd/MM/yyyy"), task.endDate.ToString("dd/MM/yyyy"),
                    task.assignedToName, status);
            }
        }

        private void RenderList(string keyword = "")
        {
            if (checkBoxStartDate.Checked || checkBoxEndDate.Checked)
            {
                if (!ValidateDateTime())
                    return;
            }

            try
            {
                var listTask = taskProgressBLL.GetAllDetail(keyword, contractCode, dateTimePickerFrom.Value,
                    dateTimePickerTo.Value, checkBoxStartDate.Checked, checkBoxEndDate.Checked);
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
            resourceManager = new ResourceManager(ResourceContext.LIST_TASK_DETAIL, typeof(ListTaskDetailGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.lbSearch.Text = GetLocalizedString("lbSearch");
            this.checkBoxStartDate.Text = GetLocalizedString("lbStartDate");
            this.checkBoxEndDate.Text = GetLocalizedString("lbEndDate");
            this.btnFile.Text = GetLocalizedString("btnFile");

            this.columnContractCode.HeaderText = GetLocalizedString("columnContractCode");
            this.columnTaskName.HeaderText = GetLocalizedString("columnTaskName");
            this.columnStartDate.HeaderText = GetLocalizedString("columnStartDate");
            this.columnEndDate.HeaderText = GetLocalizedString("columnEndDate");
            this.columnAssignTo.HeaderText = GetLocalizedString("columnAssignTo");
            this.columnStatus.HeaderText = GetLocalizedString("columnStatus");
            this.columnIconUpdate.HeaderText = GetLocalizedString("columnIconUpdate");
            this.columnIconDelete.HeaderText = GetLocalizedString("columnIconDelete");

            this.lbSearchErr.Text = this.lbFilterErr.Text = "";

            for (int i = 0; i < dataGridViewTask.Rows.Count; i++)
            {
                var statusCell = dataGridViewTask.Rows[i].Cells["columnStatus"];
                if (statusCell.Value != null)
                {
                    string status = statusCell.Value.ToString();

                    if (SettingContext.Language == "vi" && taskStatusVi.ContainsKey(status))
                    {
                        statusCell.Value = taskStatusVi[status];
                    }
                    else if (SettingContext.Language == "en" && taskStatusVi.ContainsValue(status))
                    {
                        statusCell.Value = taskStatusVi.FirstOrDefault(x => x.Value == status).Key;
                    }
                }
            }
        }
        #endregion

        #region dataGridView
        private void dataGridViewTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewTask.Columns["columnIconDelete"].Index && e.RowIndex >= 0)
            {
                if (!UserContext.GetPermissions().Contains("DELETE_Task"))
                {
                    MessageBox.Show(GetLocalizedString("roleErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                int rowIndex = e.RowIndex;
                if (!int.TryParse(dataGridViewTask.Rows[rowIndex].Cells["columnId"].Value.ToString(), out int taskId))
                {
                    MessageBox.Show("Invalid task Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    var result = MessageBox.Show(GetLocalizedString("warning"), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        taskProgressBLL.Delete(taskId);
                        dataGridViewTask.Rows.RemoveAt(rowIndex);
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

            else if (e.ColumnIndex == dataGridViewTask.Columns["columnIconUpdate"].Index && e.RowIndex >= 0)
            {
                if (!UserContext.GetPermissions().Contains("UPDATE_Task"))
                {
                    MessageBox.Show(GetLocalizedString("roleErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int rowIndex = e.RowIndex;
                if (!int.TryParse(dataGridViewTask.Rows[rowIndex].Cells["columnId"].Value.ToString(), out int taskId))
                {
                    MessageBox.Show("Invalid task Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    referencedTask = taskProgressBLL.GetById(taskId);
                    if (referencedTask == null)
                    {
                        MessageBox.Show(GetLocalizedString("updateErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    UpdateTaskEvent?.Invoke(this, new TaskEventArgs(referencedTask));
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

        #region others
        private void textBoxSearch_Event(object sender, EventArgs e) => lbSearchErr.Text = "";
        private void dateTimePicker_Event(object sender, EventArgs e) => lbFilterErr.Text = "";
        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            this.lbFilterErr.Text = "";
            dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled
                = checkBoxEndDate.Checked || checkBoxStartDate.Checked;
        }

        private void checkBoxEndDate_CheckedChanged(object sender, EventArgs e)
        {
            this.lbFilterErr.Text = "";
            dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled
                = checkBoxEndDate.Checked || checkBoxStartDate.Checked;
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
                    List<int> excludedColumns = new List<int> { 0, 7, 8 };
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
                    List<int> excludedColumns = new List<int> { 0, 7, 8 };
                    fileBLL.ExportDataGridViewToPdf(dataGridViewTask, saveFileDialog.FileName, excludedColumns);
                }
            }
        }

        private void btnFile_Click(object sender, EventArgs e) => this.fileContainer.Visible = !this.fileContainer.Visible;
        #endregion
    }
}
