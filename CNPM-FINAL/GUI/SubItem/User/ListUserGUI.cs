using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using CNPM_FINAL.Event;
using CNPM_FINAL.GUI.SubItem.Commission;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.User
{
    public partial class ListUserGUI : Form
    {
        #region properties
        private readonly UserBLL userBLL = new UserBLL();
        public EventHandler<UserEventArgs> UpdateUserEvent;
        public EventHandler<UserEventArgs> UpdatePermissionEvent;
        private UserDTO referancedUser;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private readonly Dictionary<string, string> roleVi = new Dictionary<string, string>
        {
            { "Sale", "Nhân viên sale" },
            { "Director", "Giám đốc" },
            { "Admin", "Quản trị viên" },
            { "Accountant", "Kế toán" }
        };
        private readonly string defaultPassword = ConfigurationManager.AppSettings["defaultPassword"];
        #endregion

        public ListUserGUI()
        {
            InitializeComponent();
            RenderList();
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
            resourceManager = new ResourceManager(ResourceContext.LIST_USER, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.lbSearch.Text = GetLocalizedString("lbSearch");
            this.btnGetAll.Text = GetLocalizedString("btnGetAll");

            this.columnFullName.HeaderText = GetLocalizedString("columnFullname");
            this.columnIconResetPassword.HeaderText = GetLocalizedString("columnIconReset");
            this.columnIconUpdate.HeaderText = GetLocalizedString("columnIconUpdate");
            this.columnPhone.HeaderText = GetLocalizedString("columnPhone");
            this.columnRole.HeaderText = GetLocalizedString("columnRole");
            this.columnUserCode.HeaderText = GetLocalizedString("columnUserCode");
            this.columnUsername.HeaderText = GetLocalizedString("columnUsername");
            this.columnPermission.HeaderText = GetLocalizedString("columnPermission");

            for (int i = 0; i < dataGridViewUser.Rows.Count; i++)
            {
                var roleCell = dataGridViewUser.Rows[i].Cells["columnRole"];
                if (roleCell.Value != null)
                {
                    string role = roleCell.Value.ToString();

                    if (SettingContext.Language == "vi" && roleVi.ContainsKey(role))
                    {
                        roleCell.Value = roleVi[role];
                    }
                    else if (SettingContext.Language == "en" && roleVi.ContainsValue(role))
                    {
                        roleCell.Value = roleVi.FirstOrDefault(x => x.Value == role).Key;
                    }
                }
            }

            this.lbSearchErr.Text = "";
        }

        #region methods
        public void ClearRows() => dataGridViewUser.Rows.Clear();
        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);

        private void AddRows(List<UserDTO> users)
        {
            dataGridViewUser.Rows.Clear();
            if (users.Count == 0)
            {
                lbSearchErr.Text = GetLocalizedString("lbSearchErr");
                return;
            }

            foreach (var user in users)
            {
                var role = SettingContext.Language == "vi" ? 
                    roleVi[user.roleName] : user.roleName;
                dataGridViewUser.Rows.Add(user.id, user.code, user.userName,
                    user.fullName, role, user.email, user.phone);
            }
        }
        private void RenderList(string keyword = "")
        {
            try
            {
                var users = userBLL.GetAll(keyword);
                AddRows(users);
            }
            catch (Exception) { }
        }
        #endregion

        #region events
        private void btnGetAll_Click(object sender, EventArgs e) => RenderList();

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewUser.Columns["columnIconResetPassword"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                string userCode = dataGridViewUser.Rows[rowIndex].Cells["columnUserCode"].Value.ToString();

                try
                {
                    var result = MessageBox.Show(GetLocalizedString("warning"), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        userBLL.ResetPassword(userCode);
                        MessageBox.Show(GetLocalizedString("resetSuccess") + defaultPassword, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            else if (e.ColumnIndex == dataGridViewUser.Columns["columnIconUpdate"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                string userCode = dataGridViewUser.Rows[rowIndex].Cells["columnUserCode"].Value.ToString();

                try
                {
                    referancedUser = userBLL.GetOneByUserCode(userCode);
                    if (referancedUser == null)
                    {
                        MessageBox.Show(GetLocalizedString("updateErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    UpdateUserEvent?.Invoke(this, new UserEventArgs(referancedUser));
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

            else if (e.ColumnIndex == dataGridViewUser.Columns["columnPermission"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                string username = dataGridViewUser.Rows[rowIndex].Cells["columnUsername"].Value.ToString();
                string role = dataGridViewUser.Rows[rowIndex].Cells["columnRole"].Value.ToString();

                try
                {
                    if(role == "Admin" || role == "Quản trị viên")
                    {
                        var message = SettingContext.Language == "vi" ? 
                            "Không thể cập nhật quyền cho quản trị viên" : "Can't update permission for admin";
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    referancedUser = userBLL.GetOneByUserName(username);
                    if (referancedUser == null)
                    {
                        MessageBox.Show(GetLocalizedString("updatePermissionErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    UpdatePermissionEvent?.Invoke(this, new UserEventArgs(referancedUser));
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
        private void textBoxSearch_Event(object sender, EventArgs e) =>  this.lbSearchErr.Text = "";

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
    }
}
