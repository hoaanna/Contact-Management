using CNPM_FINAL.Context;
using System;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI
{
    public partial class ForgotPasswordGUI : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public static readonly string DISPLAY_NAME = "Contract Management Application";
        public static readonly string PASSWORD = "pvvp kxrb jnvh latr";
        public static readonly string EMAIL = "contractmanagementapplication@gmail.com";
        public static readonly string HOST = "smtp.gmail.com";
        public static readonly int PORT = 587;
        public ForgotPasswordGUI()
        {
            InitializeComponent();

            if (SettingContext.Language == "en")
            {
                this.lbInfo.Text = "Your contact information will be sent to the admin and the admin will provide you with a new password as soon as possible.";
                this.title.Text = "Request new password";
                this.lbEmail.Text = "Enter your email address or phone number";
                this.btnCancel.Text = "Cancel";
                this.btnSend.Text = "Send";
            }
        }

        private void btnMinimize_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void header_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            if (Program.loginGUI == null)
            {
                Program.loginGUI = new LoginGUI();
            }

            Program.loginGUI.Show();
            this.Close();
        }

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            string text = this.textBoxEmail.Text;
            if (string.IsNullOrEmpty(text))
            {
                var message = SettingContext.Language == "en" ?
                    "Email or phone number must not be empty" : "Email hoặc số điện thoại không được để trống";
                this.lbError.Text = message;
                return;
            }

            bool isEmail = System.Text.RegularExpressions.Regex.IsMatch(text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool isPhone = System.Text.RegularExpressions.Regex.IsMatch(text, @"^[0-9]{9,12}$");
            if (!isEmail && !isPhone)
            {
                var message = SettingContext.Language == "en" ?
                    "Email or phone number format is invalid" : "Định dạng email hoặc số điện thoại không hợp lệ";
                this.lbError.Text = message;
                return;
            }

            try
            {
                var emails = new DAL.UserDAL().GetAdminEmail();
                foreach (var email in emails)
                {
                    var fromAddress = new MailAddress(EMAIL, DISPLAY_NAME);
                    var toAddress = new MailAddress(email, email);

                    var smtp = new SmtpClient
                    {
                        Host = HOST,
                        Port = PORT,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, PASSWORD)
                    };

                    using (var mailMessage = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = "Request new password",
                        Body = $"<p>User with email or phone number: {text} has requested a new password.</p>" +
                            "<p>Please provide a new password as soon as possible.</p>",
                        IsBodyHtml = true
                    })
                    {

                        smtp.Send(mailMessage);
                    }
                }

                var message = SettingContext.Language == "en" ?
                    "Your request has been sent to the admin. Please wait for the admin to provide you with a new password" :
                    "Yêu cầu của bạn đã được gửi đến admin. Vui lòng chờ admin cung cấp mật khẩu mới cho bạn";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                var message = SettingContext.Language == "en" ?
                    "An error occurred while sending the request" : "Đã xảy ra lỗi khi gửi yêu cầu";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxEmail_Click(object sender, System.EventArgs e) => this.lbError.Text = "";

        private void textBoxEmail_TextChanged(object sender, System.EventArgs e) => this.lbError.Text = "";
    }
}
