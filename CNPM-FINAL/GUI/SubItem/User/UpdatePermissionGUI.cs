using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.User
{
    public partial class UpdatePermissionGUI : Form
    {
        private readonly UserDTO referencedUser;
        public EventHandler<EventArgs> OpenListGUI;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private HashSet<string> permissions = new HashSet<string>();
        private readonly UserBLL userBLL = new UserBLL();
        private readonly List<List<string>> permissionsList = new List<List<string>>
        {
            new List<string> { "GET_Contract", "CREATE_Contract", "UPDATE_Contract", "DELETE_Contract" },
            new List<string> { "GET_Task", "CREATE_Task", "UPDATE_Task", "DELETE_Task" },
            new List<string> { "GET_Payment", "CREATE_Payment", "UPDATE_Payment", "DELETE_Payment" }
        };
        private readonly Dictionary<string, List<string>> elements = new Dictionary<string, List<string>>
        {
            {"vi", new List<string> { "Hợp đồng", "Công việc", "Thanh toán", "Báo cáo kinh doanh", "Báo cáo hoa hồng" } },
            {"en", new List<string> { "Contract", "Task", "Payment", "Business Report", "Commission Report" } }
        };

        public UpdatePermissionGUI(UserDTO user)
        {
            referencedUser = user;
            InitializeComponent();
            InitDataGridView();
            InitTextContent();
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
            resourceManager = new ResourceManager(ResourceContext.UPDATE_PERMISSION, typeof(UpdatePermissionGUI).Assembly);

            this.lbRole.Text = GetLocalizedString("lbRole") + referencedUser.roleName;
            this.lbbUsercode.Text = GetLocalizedString("lbUserCode") + referencedUser.code;
            this.lbFullname.Text = GetLocalizedString("lbFullname") + referencedUser.fullName;
            this.lbTitle.Text = GetLocalizedString("title");

            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnConfirm.Text = GetLocalizedString("btnConfirm");

            this.columnElement.HeaderText = GetLocalizedString("columnPermission");
            this.columnGet.HeaderText = GetLocalizedString("columnGet");
            this.columnCreate.HeaderText = GetLocalizedString("columnCreate");
            this.columnUpdate.HeaderText = GetLocalizedString("columnUpdate");
            this.columnDelete.HeaderText = GetLocalizedString("columnDelete");
            this.columnLock.HeaderText = GetLocalizedString("columnLock");

            if(dataGridView.Rows.Count > 0)
            {
                var rowContract = GetLocalizedString("rowContract");
                dataGridView.Rows[0].Cells[0].Value = GetLocalizedString("rowContract");
                var rowTask = GetLocalizedString("rowTask");
                dataGridView.Rows[1].Cells[0].Value = GetLocalizedString("rowTask");
                var rowPayment = GetLocalizedString("rowPayment");
                dataGridView.Rows[2].Cells[0].Value = GetLocalizedString("rowPayment");
                var rowBusinessReport = GetLocalizedString("rowBusinessReport");
                dataGridView.Rows[3].Cells[0].Value = GetLocalizedString("rowBusinessReport");
                var rowCommission = GetLocalizedString("rowCommission");
                dataGridView.Rows[4].Cells[0].Value = GetLocalizedString("rowCommission");
            }
        }

        private void InitDataGridView()
        {
            List<string> data = elements[SettingContext.Language];
            dataGridView.Rows.Clear();
            foreach (var item in data)
            {
                dataGridView.Rows.Add(item);
            }

            if (dataGridView.Rows.Count > 0)
            {
                int availableHeight = dataGridView.ClientSize.Height - dataGridView.ColumnHeadersHeight;
                int rowHeight = (int)Math.Floor((double)availableHeight / dataGridView.Rows.Count);

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Height = rowHeight - 1;
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int j = 2; j <= 4; j++)
                {
                    row.Cells[j].Value = false;
                }
            }

            for (int i = 2; i < 5; i++)
            {
                dataGridView.Rows[3].Cells[i].ReadOnly = true;
                dataGridView.Rows[4].Cells[i].ReadOnly = true;
            }

            if (referencedUser == null)
            {
                OpenListGUI?.Invoke(this, EventArgs.Empty);
                return;
            }

            switch (referencedUser.roleName)
            {
                case "Director":
                    dataGridView.Rows[3].ReadOnly = true;
                    dataGridView.Rows[3].Cells[1].Value = true;
                    break;

                case "Sale":
                    dataGridView.Rows[0].ReadOnly = true;
                    dataGridView.Rows[1].ReadOnly = true;
                    dataGridView.Rows[4].ReadOnly = true;
                    for (int j = 1; j <= 4; j++)
                    {
                        dataGridView.Rows[0].Cells[j].Value = true;
                        dataGridView.Rows[1].Cells[j].Value = true;
                    }
                    dataGridView.Rows[4].Cells[1].Value = true;
                    break;

                case "Accountant":
                    dataGridView.Rows[2].ReadOnly = true;
                    for (int i = 1; i <= 4; i++)
                    {
                        dataGridView.Rows[2].Cells[i].Value = true;
                    }
                    dataGridView.Rows[4].Cells[1].Value = true;
                    break;
            }

            foreach (var permission in referencedUser.permissions)
            {
                if (permission == "BusinessReport")
                {
                    dataGridView.Rows[3].Cells[1].Value = true;
                }
                else if (permission == "CommissionReport")
                {
                    dataGridView.Rows[4].Cells[1].Value = true;
                }
                else if (permission.Contains("Contract"))
                {
                    dataGridView.Rows[0].Cells[permissionsList[0].IndexOf(permission) + 1].Value = true;
                }
                else if (permission.Contains("Task"))
                {
                    dataGridView.Rows[1].Cells[permissionsList[1].IndexOf(permission) + 1].Value = true;
                }
                else if (permission.Contains("Payment"))
                {
                    dataGridView.Rows[2].Cells[permissionsList[2].IndexOf(permission) + 1].Value = true;
                }
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                bool isAllUnchecked = true;
                for (int j = 1; j <= 4; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value is bool isChecked && isChecked)
                    {
                        isAllUnchecked = false;
                        break;
                    }
                }

                dataGridView.Rows[i].Cells[5].Value = isAllUnchecked;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (dataGridView.Rows[i].Cells[5].Value is bool isChecked && isChecked)
                {
                    continue;
                }

                for (int j = 1; j <= 4; j++)
                {
                    var cellValue = dataGridView.Rows[i].Cells[j].Value;
                    if (cellValue is bool isCheck && isCheck)
                    {
                        permissions.Add(permissionsList[i][j - 1]);
                    }
                }
            }

            var cell1_3 = dataGridView.Rows[3].Cells[1].Value;
            var cell1_4 = dataGridView.Rows[4].Cells[1].Value; 

            if (cell1_3 is bool isCheck1_3 && isCheck1_3)
            {
                permissions.Add("BusinessReport");
            }

            if (cell1_4 is bool isCheck1_4 && isCheck1_4)
            {
                permissions.Add("CommissionReport");
            }

            try
            {
                userBLL.UpdateUserPermissions(referencedUser.userName, new List<string>(permissions));
                MessageBox.Show(GetLocalizedString("success"), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenListGUI?.Invoke(this, EventArgs.Empty);
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

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly && e.ColumnIndex != 0)
            {
                e.CellStyle.BackColor = System.Drawing.Color.LightGray;
                e.CellStyle.ForeColor = System.Drawing.Color.Gray;
                e.CellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
                e.CellStyle.SelectionForeColor = System.Drawing.Color.Gray;
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (rowIndex < 0 || rowIndex >= dataGridView.Rows.Count)
                return;

            if (columnIndex <= 0 || columnIndex >= dataGridView.Columns.Count)
                return;

            if (columnIndex == 5)
            {
                var cellValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value;
                if (cellValue is bool isChecked && isChecked)
                {
                    for (int i = 1; i < 5; i++)
                    {
                        if (!dataGridView.Rows[rowIndex].Cells[i].ReadOnly)
                        {
                            dataGridView.Rows[rowIndex].Cells[i].Value = false;
                        }
                    }
                }
                else
                {
                    dataGridView.Rows[rowIndex].Cells[1].Value = true;
                }
            }
            else if (columnIndex == 1)
            {
                var cellValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value;
                if (cellValue is bool isChecked && !isChecked)
                {
                    for (int i = 1; i < 5; i++)
                    {
                        dataGridView.Rows[rowIndex].Cells[i].Value = false;
                    }
                    dataGridView.Rows[rowIndex].Cells[5].Value = true;
                }
                else
                {
                    dataGridView.Rows[rowIndex].Cells[5].Value = false;
                }
            }
            else if (columnIndex > 1 && columnIndex <= 4)
            {
                var cellValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value;
                if (cellValue is bool isChecked && isChecked)
                {
                    dataGridView.Rows[rowIndex].Cells[5].Value = false;
                    dataGridView.Rows[rowIndex].Cells[1].Value = true;
                }
            }
        }

        private void dataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GetLocalizedString("warning"), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                OpenListGUI?.Invoke(this, EventArgs.Empty);
            }
        }

        private string GetLocalizedString(string key) =>  resourceManager.GetString(key, cultureInfo);
    } 
}
