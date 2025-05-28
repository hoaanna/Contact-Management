using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.GUI.SubItem.Commission;
using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI
{
    public partial class LoginGUI : Form
    {
        #region properties
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private readonly UserBLL userDLL = new UserBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;

        private MainGUI mainGUI;
        #endregion
        public LoginGUI()
        {
            InitializeComponent();
            InitTextContent();

            textBoxPassword.UseSystemPasswordChar = !show_hide_pass.Checked;
        }

        #region init
        public void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.LOGIN_GUI, typeof(ListCommissionGUI).Assembly);

            this.lbLogin.Text = GetLocalizedString("title");
            this.lbUsername.Text = GetLocalizedString("lbUsername");
            this.lbPassword.Text = GetLocalizedString("lbPassword");
            this.btnLogin.Text = GetLocalizedString("btnLogin");
            this.show_hide_pass.Text = GetLocalizedString("checkbox");
            this.lbForgotPassword.Text = GetLocalizedString("lbForgotPasswod");
        }
        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);
        #endregion

        #region controlBox
        private void controlBox_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void controlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void controlBox_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnMinimize_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region events
        private void lbForgotPassword_MouseEnter(object sender, EventArgs e) => lbForgotPassword.Font = new Font(lbForgotPassword.Font, FontStyle.Underline);
        private void lbForgotPassword_MouseLeave(object sender, EventArgs e) => lbForgotPassword.Font = new Font(lbForgotPassword.Font, FontStyle.Regular);
        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ForgotPasswordGUI().ShowDialog();
        }

        private void show_hide_pass_CheckedChanged(object sender, EventArgs e) => textBoxPassword.UseSystemPasswordChar = !show_hide_pass.Checked;
        private void show_hide_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                show_hide_pass.Checked = !show_hide_pass.Checked;
                e.Handled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isFullInfo = true;
            if (string.IsNullOrEmpty(textBoxUserId.Text))
            {
                this.lbUserIDErr.Text = GetLocalizedString("lbRequired");
                isFullInfo = false;
            }

            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                this.lbPasswordErr.Text = GetLocalizedString("lbRequired");
                isFullInfo = false;
            }

            if (!isFullInfo) return;

            try
            {
                if (!userDLL.Login(textBoxUserId.Text, textBoxPassword.Text))
                {
                    this.lbUserIDErr.Text = GetLocalizedString("lbLoginFailure");
                    this.lbPasswordErr.Text = GetLocalizedString("lbLoginFailure");
                    return;
                }
                mainGUI = new MainGUI();
                mainGUI.Show();
                this.Hide();
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

        private void textBoxUserId_Click(object sender, EventArgs e) => lbUserIDErr.Text = "";
        private void textBoxPassword_Click(object sender, EventArgs e) => lbPasswordErr.Text = "";
        private void textBoxUserId_KeyPress(object sender, KeyPressEventArgs e) => lbUserIDErr.Text = "";
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e) => lbPasswordErr.Text = "";
        #endregion
    }
}
