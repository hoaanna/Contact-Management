namespace CNPM_FINAL.GUI
{
    partial class ForgotPasswordGUI
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
            this.header = new System.Windows.Forms.FlowLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.container = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.lbError = new System.Windows.Forms.Label();
            this.btnSend = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.btnCancel = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.panel = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCopyRight = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinimize = new System.Windows.Forms.FlowLayoutPanel();
            this.header.SuspendLayout();
            this.container.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.header.Controls.Add(this.btnExit);
            this.header.Controls.Add(this.btnMinimize);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.header.Size = new System.Drawing.Size(1440, 30);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.header_MouseUp);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.title.Location = new System.Drawing.Point(200, 60);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1070, 80);
            this.title.TabIndex = 0;
            this.title.Text = "Yêu cầu cung cấp mật khẩu mới";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.container.BackgroundColor = System.Drawing.Color.White;
            this.container.BorderColor = System.Drawing.Color.Transparent;
            this.container.BorderRadius = 40;
            this.container.BorderSize = 1;
            this.container.Controls.Add(this.lbError);
            this.container.Controls.Add(this.btnSend);
            this.container.Controls.Add(this.btnCancel);
            this.container.Controls.Add(this.panel);
            this.container.Controls.Add(this.lbInfo);
            this.container.Controls.Add(this.lbEmail);
            this.container.Location = new System.Drawing.Point(200, 170);
            this.container.Margin = new System.Windows.Forms.Padding(0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1070, 550);
            this.container.TabIndex = 0;
            // 
            // lbError
            // 
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(140, 250);
            this.lbError.Margin = new System.Windows.Forms.Padding(0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(600, 20);
            this.lbError.TabIndex = 0;
            this.lbError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(123)))));
            this.btnSend.BackgroundColor = System.Drawing.Color.White;
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.BorderRadius = 15;
            this.btnSend.BorderSize = 0;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Arial Nova Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(732, 416);
            this.btnSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(255, 65);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(79)))), ((int)(((byte)(123)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Nova Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(369, 416);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(255, 65);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BackgroundColor = System.Drawing.Color.White;
            this.panel.BorderColor = System.Drawing.Color.Black;
            this.panel.BorderRadius = 10;
            this.panel.BorderSize = 1;
            this.panel.Controls.Add(this.textBoxEmail);
            this.panel.Location = new System.Drawing.Point(120, 160);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(830, 80);
            this.panel.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial Nova Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxEmail.Location = new System.Drawing.Point(25, 23);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(780, 37);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.Click += new System.EventHandler(this.textBoxEmail_Click);
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(100, 280);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lbInfo.MaximumSize = new System.Drawing.Size(830, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(785, 62);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Thông tin liên lạc của bạn sẽ được gửi tới admin và admin sẽ cung cấp lại mật khẩ" +
    "u cho bạn trong thời gian sớm nhất";
            // 
            // lbEmail
            // 
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(100, 70);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(850, 55);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Nhập địa chỉ email hoặc SDT của bạn";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCopyRight
            // 
            this.lbCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lbCopyRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbCopyRight.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopyRight.ForeColor = System.Drawing.Color.Black;
            this.lbCopyRight.Location = new System.Drawing.Point(0, 775);
            this.lbCopyRight.Margin = new System.Windows.Forms.Padding(0);
            this.lbCopyRight.Name = "lbCopyRight";
            this.lbCopyRight.Size = new System.Drawing.Size(1440, 25);
            this.lbCopyRight.TabIndex = 1;
            this.lbCopyRight.Text = "Copyright: ©2024 STAR. All rights reserved.";
            this.lbCopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::CNPM_FINAL.Properties.Resources.x_icon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(1395, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnExit.Size = new System.Drawing.Size(45, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::CNPM_FINAL.Properties.Resources.minimize_icon;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Location = new System.Drawing.Point(1345, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // ForgotPasswordGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 800);
            this.ControlBox = false;
            this.Controls.Add(this.lbCopyRight);
            this.Controls.Add(this.container);
            this.Controls.Add(this.title);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordGUI";
            this.Text = "ForgotPasswordGUI";
            this.header.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel header;
        private System.Windows.Forms.FlowLayoutPanel btnExit;
        private System.Windows.Forms.FlowLayoutPanel btnMinimize;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbInfo;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel container;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel panel;
        private System.Windows.Forms.TextBox textBoxEmail;
        private CNPM_FINAL.GUI.CustomControl.BorderButton btnSend;
        private CNPM_FINAL.GUI.CustomControl.BorderButton btnCancel;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbCopyRight;
    }
}