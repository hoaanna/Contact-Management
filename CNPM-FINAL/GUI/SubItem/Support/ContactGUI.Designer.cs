namespace CNPM_FINAL.GUI.SubItem.Support
{
    partial class ContactGUI
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.borderPanel1 = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbFb = new System.Windows.Forms.Label();
            this.borderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 100);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1000, 100);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Liên hệ với chúng tôi theo thông tin sau";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borderPanel1
            // 
            this.borderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.borderPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.borderPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.borderPanel1.BorderRadius = 20;
            this.borderPanel1.BorderSize = 1;
            this.borderPanel1.Controls.Add(this.lbFb);
            this.borderPanel1.Controls.Add(this.lbPhone);
            this.borderPanel1.Controls.Add(this.lbEmail);
            this.borderPanel1.Controls.Add(this.lbTitle);
            this.borderPanel1.Location = new System.Drawing.Point(50, 150);
            this.borderPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(1000, 500);
            this.borderPanel1.TabIndex = 0;
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.lbEmail.Location = new System.Drawing.Point(0, 200);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(1000, 30);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email: phamtruong04112004@gmail.com";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPhone
            // 
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.lbPhone.Location = new System.Drawing.Point(0, 230);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(1000, 30);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.Text = "Phone number: 0123456789";
            this.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFb
            // 
            this.lbFb.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.lbFb.Location = new System.Drawing.Point(0, 260);
            this.lbFb.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lbFb.Name = "lbFb";
            this.lbFb.Size = new System.Drawing.Size(1000, 30);
            this.lbFb.TabIndex = 0;
            this.lbFb.Text = "Facebook: facebook.com";
            this.lbFb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContactGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.ControlBox = false;
            this.Controls.Add(this.borderPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactGUI";
            this.Text = "ContactGUI";
            this.borderPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private CustomControl.BorderPanel borderPanel1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbFb;
        private System.Windows.Forms.Label lbPhone;
    }
}