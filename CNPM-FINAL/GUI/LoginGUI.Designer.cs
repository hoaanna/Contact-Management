namespace CNPM_FINAL.GUI
{
    partial class LoginGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.controlBox = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinimize = new System.Windows.Forms.FlowLayoutPanel();
            this.show_hide_pass = new System.Windows.Forms.CheckBox();
            this.logoApp = new System.Windows.Forms.PictureBox();
            this.logoTeam = new System.Windows.Forms.PictureBox();
            this.lbUserIDErr = new System.Windows.Forms.Label();
            this.lbPasswordErr = new System.Windows.Forms.Label();
            this.lbCopyRight = new System.Windows.Forms.Label();
            this.btnLogin = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.panelPassword = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelUserID = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTeam)).BeginInit();
            this.panelPassword.SuspendLayout();
            this.panelUserID.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(625, 200);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(650, 120);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Đăng nhập";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUsername
            // 
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUsername.Location = new System.Drawing.Point(645, 340);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(400, 40);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Tên đăng nhập";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPassword
            // 
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(645, 500);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(450, 40);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Mật Khẩu";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgotPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.Location = new System.Drawing.Point(660, 635);
            this.lbForgotPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(250, 20);
            this.lbForgotPassword.TabIndex = 0;
            this.lbForgotPassword.Text = "Quên Mật Khẩu?";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            this.lbForgotPassword.MouseEnter += new System.EventHandler(this.lbForgotPassword_MouseEnter);
            this.lbForgotPassword.MouseLeave += new System.EventHandler(this.lbForgotPassword_MouseLeave);
            // 
            // controlBox
            // 
            this.controlBox.BackColor = System.Drawing.Color.Transparent;
            this.controlBox.Controls.Add(this.btnExit);
            this.controlBox.Controls.Add(this.btnMinimize);
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBox.Location = new System.Drawing.Point(0, 0);
            this.controlBox.Margin = new System.Windows.Forms.Padding(0);
            this.controlBox.Name = "controlBox";
            this.controlBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.controlBox.Size = new System.Drawing.Size(1425, 30);
            this.controlBox.TabIndex = 0;
            this.controlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlBox_MouseDown);
            this.controlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlBox_MouseMove);
            this.controlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlBox_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::CNPM_FINAL.Properties.Resources.x_icon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(1390, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnExit.Size = new System.Drawing.Size(35, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::CNPM_FINAL.Properties.Resources.minimize_icon;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Location = new System.Drawing.Point(1340, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // show_hide_pass
            // 
            this.show_hide_pass.BackColor = System.Drawing.Color.Transparent;
            this.show_hide_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_hide_pass.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.show_hide_pass.Location = new System.Drawing.Point(1015, 634);
            this.show_hide_pass.Margin = new System.Windows.Forms.Padding(0);
            this.show_hide_pass.Name = "show_hide_pass";
            this.show_hide_pass.Size = new System.Drawing.Size(180, 25);
            this.show_hide_pass.TabIndex = 3;
            this.show_hide_pass.Text = "Hiện mật khẩu";
            this.show_hide_pass.UseVisualStyleBackColor = false;
            this.show_hide_pass.CheckedChanged += new System.EventHandler(this.show_hide_pass_CheckedChanged);
            this.show_hide_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.show_hide_pass_KeyDown);
            // 
            // logoApp
            // 
            this.logoApp.BackColor = System.Drawing.Color.Transparent;
            this.logoApp.BackgroundImage = global::CNPM_FINAL.Properties.Resources.logoApp;
            this.logoApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoApp.Location = new System.Drawing.Point(0, 0);
            this.logoApp.Margin = new System.Windows.Forms.Padding(0);
            this.logoApp.Name = "logoApp";
            this.logoApp.Size = new System.Drawing.Size(220, 200);
            this.logoApp.TabIndex = 1;
            this.logoApp.TabStop = false;
            // 
            // logoTeam
            // 
            this.logoTeam.BackColor = System.Drawing.Color.Transparent;
            this.logoTeam.BackgroundImage = global::CNPM_FINAL.Properties.Resources.logo;
            this.logoTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoTeam.Location = new System.Drawing.Point(1300, 670);
            this.logoTeam.Margin = new System.Windows.Forms.Padding(0);
            this.logoTeam.Name = "logoTeam";
            this.logoTeam.Size = new System.Drawing.Size(125, 125);
            this.logoTeam.TabIndex = 2;
            this.logoTeam.TabStop = false;
            // 
            // lbUserIDErr
            // 
            this.lbUserIDErr.BackColor = System.Drawing.Color.Transparent;
            this.lbUserIDErr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUserIDErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserIDErr.ForeColor = System.Drawing.Color.Red;
            this.lbUserIDErr.Location = new System.Drawing.Point(665, 450);
            this.lbUserIDErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbUserIDErr.Name = "lbUserIDErr";
            this.lbUserIDErr.Size = new System.Drawing.Size(450, 20);
            this.lbUserIDErr.TabIndex = 0;
            this.lbUserIDErr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPasswordErr
            // 
            this.lbPasswordErr.BackColor = System.Drawing.Color.Transparent;
            this.lbPasswordErr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPasswordErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordErr.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordErr.Location = new System.Drawing.Point(665, 610);
            this.lbPasswordErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbPasswordErr.Name = "lbPasswordErr";
            this.lbPasswordErr.Size = new System.Drawing.Size(450, 20);
            this.lbPasswordErr.TabIndex = 0;
            this.lbPasswordErr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCopyRight
            // 
            this.lbCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lbCopyRight.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopyRight.ForeColor = System.Drawing.Color.Black;
            this.lbCopyRight.Location = new System.Drawing.Point(25, 770);
            this.lbCopyRight.Margin = new System.Windows.Forms.Padding(0);
            this.lbCopyRight.Name = "lbCopyRight";
            this.lbCopyRight.Size = new System.Drawing.Size(400, 25);
            this.lbCopyRight.TabIndex = 0;
            this.lbCopyRight.Text = "Copyright: ©2024 STAR. All rights reserved.";
            this.lbCopyRight.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.White;
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.BorderRadius = 25;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Nova Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(770, 700);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(255, 65);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.White;
            this.panelPassword.BackgroundColor = System.Drawing.Color.White;
            this.panelPassword.BorderColor = System.Drawing.Color.Black;
            this.panelPassword.BorderRadius = 25;
            this.panelPassword.BorderSize = 1;
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Location = new System.Drawing.Point(645, 550);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(550, 60);
            this.panelPassword.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPassword.Location = new System.Drawing.Point(25, 10);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(500, 40);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // panelUserID
            // 
            this.panelUserID.BackColor = System.Drawing.Color.White;
            this.panelUserID.BackgroundColor = System.Drawing.Color.White;
            this.panelUserID.BorderColor = System.Drawing.Color.Black;
            this.panelUserID.BorderRadius = 25;
            this.panelUserID.BorderSize = 1;
            this.panelUserID.Controls.Add(this.textBoxUserId);
            this.panelUserID.Location = new System.Drawing.Point(645, 390);
            this.panelUserID.Margin = new System.Windows.Forms.Padding(0);
            this.panelUserID.Name = "panelUserID";
            this.panelUserID.Size = new System.Drawing.Size(550, 60);
            this.panelUserID.TabIndex = 1;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserId.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxUserId.Location = new System.Drawing.Point(25, 10);
            this.textBoxUserId.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(500, 40);
            this.textBoxUserId.TabIndex = 1;
            this.textBoxUserId.Click += new System.EventHandler(this.textBoxUserId_Click);
            this.textBoxUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUserId_KeyPress);
            // 
            // LoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CNPM_FINAL.Properties.Resources.backgound;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1425, 800);
            this.ControlBox = false;
            this.Controls.Add(this.lbCopyRight);
            this.Controls.Add(this.lbPasswordErr);
            this.Controls.Add(this.lbUserIDErr);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelUserID);
            this.Controls.Add(this.logoTeam);
            this.Controls.Add(this.logoApp);
            this.Controls.Add(this.show_hide_pass);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginGUI";
            this.Text = "LoginForm";
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTeam)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelUserID.ResumeLayout(false);
            this.panelUserID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label lbForgotPassword;
        private System.Windows.Forms.FlowLayoutPanel controlBox;
        private System.Windows.Forms.FlowLayoutPanel btnExit;
        private System.Windows.Forms.FlowLayoutPanel btnMinimize;
        private System.Windows.Forms.CheckBox show_hide_pass;
        private System.Windows.Forms.PictureBox logoApp;
        private System.Windows.Forms.PictureBox logoTeam;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel panelUserID;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel panelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private CNPM_FINAL.GUI.CustomControl.BorderButton btnLogin;
        private System.Windows.Forms.Label lbUserIDErr;
        private System.Windows.Forms.Label lbPasswordErr;
        private System.Windows.Forms.Label lbCopyRight;
    }
}

