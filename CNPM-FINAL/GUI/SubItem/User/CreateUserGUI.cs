using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.GUI.SubItem.Commission;
using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.User
{
    public partial class CreateUserGUI : Form
    {
        private readonly UserBLL userBLL = new UserBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        public CreateUserGUI()
        {
            InitializeComponent();
            InitTextContent();
            InitComboBox();
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
            resourceManager = new ResourceManager(ResourceContext.CREATE_USER, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnCreate.Text = GetLocalizedString("btnCreate");

            this.lbFullName.Text = GetLocalizedString("lbFullName");
            this.lbPhone.Text = GetLocalizedString("lbPhone");
            this.lbRole.Text = GetLocalizedString("lbRole");
            this.lbUserCode.Text = GetLocalizedString("lbUserCode");
            this.lbUsername.Text = GetLocalizedString("lbUsername");

            this.lbUsernameErr.Text = this.lbUserCodeErr.Text = this.lbFullNameErr.Text
                = this.lbEmailErr.Text = this.lbPhoneErr.Text = "";
        }

        private void InitComboBox()
        {
            this.comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxRole.Items.Add("Accountant");
            this.comboBoxRole.Items.Add("Sale");
            this.comboBoxRole.Items.Add("Director");
            this.comboBoxRole.Items.Add("Admin");
            this.comboBoxRole.SelectedIndex = 0;
        }
        #endregion

        #region methods
        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);
        private Color rgba(int r, int g, int b, double a) => Color.FromArgb((int)(a * 255), r, g, b);
        #endregion

        #region events
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.textBoxUsername.Text = this.textBoxUserCode.Text = this.textBoxFullName.Text
                = this.textBoxEmail.Text = this.textBoxPhone.Text = "";

            this.lbUsernameErr.Text = this.lbUserCodeErr.Text = this.lbFullNameErr.Text
                = this.lbEmailErr.Text = this.lbPhoneErr.Text = "";

            this.textBoxUserCode.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { this.textBoxUsername, this.textBoxUserCode, this.textBoxFullName, this.textBoxEmail, this.textBoxPhone };
            Label[] labels = { this.lbUsernameErr, this.lbUserCodeErr, this.lbFullNameErr, this.lbEmailErr, this.lbPhoneErr };
            bool isValid = true;

            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
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

            var user = new DTO.UserDTO
            {
                userName = textBoxUsername.Text,
                code = textBoxUserCode.Text,
                fullName = textBoxFullName.Text,
                email = textBoxEmail.Text,
                phone = textBoxPhone.Text,
                roleName = comboBoxRole.SelectedItem.ToString()
            };

            try
            {
                userBLL.Insert(user);
                MessageBox.Show(GetLocalizedString("success"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBoxUsername_Event(object sender, EventArgs e) => this.lbUsernameErr.Text = "";
        private void textBoxUserCode_Event(object sender, EventArgs e) => this.lbUserCodeErr.Text = "";
        private void textBoxFullName_Event(object sender, EventArgs e) => this.lbFullNameErr.Text = "";
        private void textBoxEmail_Event(object sender, EventArgs e) => this.lbEmailErr.Text = "";
        private void textBoxPhone_Event(object sender, EventArgs e) => this.lbPhoneErr.Text = "";
        #endregion

        private void textBoxUserCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBoxUserCode.Text.Length >= 20 && !char.IsControl(e.KeyChar))
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

            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBoxUsername.Text.Length >= 20 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBoxPhone.Text.Length > 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
