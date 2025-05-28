using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.GUI.SubItem.Commission;
using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.User
{
    public partial class UserInfoGUI : Form
    {
        private readonly UserBLL userBLL = new UserBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;

        public UserInfoGUI()
        {
            InitializeComponent();
            LoadUserInfo();
            InitTextContent();

            this.textBoxNewPassword.PasswordChar = this.textBoxOldPassword.PasswordChar
                = this.textBoxConfirmPassword.PasswordChar = '*';
            this.panelChangePassword.BackColor = Color.FromArgb(200, 211, 226);
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
        #endregion

        #region init
        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.USER_INFO_GUI, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnConfirm.Text = GetLocalizedString("btnConfirm");
            this.btnChangePassword.Text = GetLocalizedString("btnChangePass");

            this.lbConfirmPassword.Text = GetLocalizedString("lbPassConfirm");
            this.lbFullName.Text = GetLocalizedString("lbFullName");
            this.lbNewPassword.Text = GetLocalizedString("lbNewPass");
            this.lbOldPassword.Text = GetLocalizedString("lbOldPass");
            this.lbPhone.Text = GetLocalizedString("lbPhone");
            this.lbRole.Text = GetLocalizedString("lbRole");
            this.lbUserCode.Text = GetLocalizedString("lbUserCode");
            this.lbUsername.Text = GetLocalizedString("lbUsername");

            this.lbOldPasswordErr.Text = this.lbNewPasswordErr.Text 
                = this.lbConfirmPasswordErr.Text = "";
        }
        private void LoadUserInfo()
        {
            this.textBoxUserCode.Text = UserContext.GetUserCode();
            this.textBoxUsername.Text = UserContext.GetUsername();
            this.textBoxRole.Text = UserContext.GetRoleName();
            this.textBoxFullName.Text = UserContext.GetName();
            this.textBoxPhone.Text = UserContext.GetPhone();
            this.textBoxEmail.Text = UserContext.GetEmail();
        }
        #endregion

        #region events
        private void textBoxFullName_Event(object sender, EventArgs e) => this.lbFullNameErr.Text = "";
        private void textBoxPhone_Event(object sender, EventArgs e) => this.lbPhoneErr.Text = "";
        private void textBoxEmail_Event(object sender, EventArgs e) => this.lbEmailErr.Text = "";
        private void textBoxOldPassword_Event(object sender, EventArgs e) => this.lbOldPasswordErr.Text = "";
        private void textBoxNewPassword_Event(object sender, EventArgs e) => this.lbNewPasswordErr.Text = "";
        private void textBoxConfirmPassword_Event(object sender, EventArgs e) => this.lbConfirmPasswordErr.Text = "";

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            TextBox[] textBoxes = { this.textBoxOldPassword, this.textBoxNewPassword, this.textBoxConfirmPassword };
            Label[] labels = { this.lbOldPasswordErr, this.lbNewPasswordErr, this.lbConfirmPasswordErr };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    labels[i].Text = GetLocalizedString("lbRequired");
                    isValid = false;
                }
            }

            if (!isValid) return;

            if (!Regex.IsMatch(textBoxNewPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,16}$"))
            {
                lbNewPasswordErr.Text = GetLocalizedString("invalidPass");
                return;
            }

            if (!textBoxNewPassword.Text.Equals(textBoxConfirmPassword.Text))
            {
                lbConfirmPasswordErr.Text = GetLocalizedString("passNotMatch");
                return;
            }

            try
            {
                userBLL.ChangePassword(textBoxOldPassword.Text, textBoxNewPassword.Text);
                MessageBox.Show(GetLocalizedString("success"), "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnCancel.PerformClick();
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
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.panelChangePassword.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.textBoxOldPassword.Text = this.textBoxNewPassword.Text 
                = this.textBoxConfirmPassword.Text = "";
            this.lbOldPasswordErr.Text = this.lbNewPasswordErr.Text 
                = this.lbConfirmPasswordErr.Text = "";
            this.panelChangePassword.Visible = false;
        }
        #endregion
    }
}
