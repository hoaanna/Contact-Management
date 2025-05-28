using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using CNPM_FINAL.GUI.SubItem.Commission;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.User
{
    public partial class UpdateUserGUI : Form
    {
        #region properties
        public EventHandler<EventArgs> OpenListGUI;
        private readonly UserBLL userBLL = new UserBLL();
        private readonly UserDTO referancedUser;
        private readonly string oldUsername;
        private readonly string oldUserCode;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private readonly Dictionary<string, List<string>> roles = new Dictionary<string, List<string>>
        {
            {"en", new List<string> { "Admin", "Director", "Sale", "Accountant" } },
            {"vi", new List<string> { "Quản trị", "Giám đốc", "Nhân viên sale", "Kế toán"} }
        };
        #endregion

        public UpdateUserGUI(UserDTO user)
        {
            referancedUser = user;
            oldUsername = user.userName;
            oldUserCode = user.code;

            InitializeComponent();
            InitTextContent();
            InitData();

            this.comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
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
            resourceManager = new ResourceManager(ResourceContext.UPDATE_USER, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnUpdate.Text = GetLocalizedString("btnUpdate");

            this.lbFullName.Text = GetLocalizedString("lbFullName");
            this.lbPhone.Text = GetLocalizedString("lbPhone");
            this.lbRole.Text = GetLocalizedString("lbRole");
            this.lbUserCode.Text = GetLocalizedString("lbUserCode");
            this.lbUsername.Text = GetLocalizedString("lbUsername");

            this.comboBoxRole.Items.Clear();
            this.comboBoxRole.Items.AddRange(roles[SettingContext.Language].ToArray());
            this.comboBoxRole.SelectedIndex = 0;

            this.lbFullNameErr.Text = this.lbPhoneErr.Text
                = this.lbUserCodeErr.Text = this.lbUsernameErr.Text
                = "";
        }

        private void InitData()
        {
            if (referancedUser == null)
            {
                MessageBox.Show(GetLocalizedString("notFound"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.OpenListGUI?.Invoke(this, new EventArgs());
                return;
            }

            this.textBoxUsername.Text = referancedUser.userName;
            this.textBoxUserCode.Text = referancedUser.code;
            this.textBoxFullName.Text = referancedUser.fullName;
            this.textBoxEmail.Text = referancedUser.email;
            this.textBoxPhone.Text = referancedUser.phone;
            this.comboBoxRole.SelectedIndex = roles[SettingContext.Language].IndexOf(referancedUser.roleName);
        }
        #endregion

        #region methods
        private Color rgba(int r, int g, int b, double a) => Color.FromArgb((int)(a * 255), r, g, b);
        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);
        #endregion

        #region events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GetLocalizedString("warning"), "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.OpenListGUI?.Invoke(this, new EventArgs());
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { this.textBoxUsername, this.textBoxUserCode, this.textBoxFullName, this.textBoxEmail, this.textBoxPhone };
            Label[] labels = { this.lbUsernameErr, this.lbUserCodeErr, this.lbFullNameErr, this.lbEmailErr, this.lbPhoneErr };
            bool isValid = true;

            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text == "")
                {
                    labels[i].Text = GetLocalizedString("lbRequired");
                    isValid = false;
                }
            }

            if (!isValid) return;

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                lbEmailErr.Text = GetLocalizedString("invalidEmail");
                isValid = false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPhone.Text, @"^[0-9]{9,12}$"))
            {
                lbPhoneErr.Text = GetLocalizedString("invalidPhone");
                isValid = false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxUsername.Text, @"^[a-zA-Z0-9_]+$"))
            {
                lbUsernameErr.Text = GetLocalizedString("invalidUser");
                isValid = false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxUserCode.Text, @"^[a-zA-Z0-9_]+$"))
            {
                lbUserCodeErr.Text = GetLocalizedString("invalidUser");
                isValid = false;
            }

            if (textBoxUsername.Text.Length < 5 || textBoxUsername.Text.Length > 20)
            {
                lbUsernameErr.Text = GetLocalizedString("invalidLength");
                isValid = false;
            }

            if (textBoxUserCode.Text.Length > 20 || textBoxUserCode.Text.Length < 5)
            {
                lbUserCodeErr.Text = GetLocalizedString("invalidLength");
                isValid = false;
            }

            if (!isValid) return;

            referancedUser.userName = textBoxUsername.Text;
            referancedUser.code = textBoxUserCode.Text;
            referancedUser.fullName = textBoxFullName.Text;
            referancedUser.email = textBoxEmail.Text;
            referancedUser.phone = textBoxPhone.Text;
            referancedUser.roleName = roles["en"][comboBoxRole.SelectedIndex];

            try
            {
                userBLL.UpdateInfo(referancedUser, true, oldUserCode, oldUsername);
                MessageBox.Show(GetLocalizedString("success"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBoxUsername_Event(object sender, EventArgs e) => this.lbUsernameErr.Text = "";
        private void textBoxUserCode_Event(object sender, EventArgs e) => this.lbUserCodeErr.Text = "";
        private void textBoxFullName_Event(object sender, EventArgs e) => this.lbFullNameErr.Text = "";
        private void textBoxEmail_Event(object sender, EventArgs e) => this.lbEmailErr.Text = "";
        private void textBoxPhone_Event(object sender, EventArgs e) => this.lbPhoneErr.Text = "";

        private void textBoxUserCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBoxUserCode.Text.Length > 20)
            {
                e.Handled = true;
            }
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxUsername.Text.Length == 0 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_'
                || textBoxUsername.Text.Length >= 20)
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || textBoxPhone.Text.Length >= 12)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
