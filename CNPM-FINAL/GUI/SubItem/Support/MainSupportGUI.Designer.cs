namespace CNPM_FINAL.GUI.SubItem.Support
{
    partial class MainSupportGUI
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
            this.panelContact = new System.Windows.Forms.Panel();
            this.lbContact = new System.Windows.Forms.Label();
            this.panelChatbot = new System.Windows.Forms.Panel();
            this.lbChatbot = new System.Windows.Forms.Label();
            this.borderPanelChatbot = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.borderPanelContact = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.panelContact.SuspendLayout();
            this.panelChatbot.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContact
            // 
            this.panelContact.BackColor = System.Drawing.Color.Transparent;
            this.panelContact.Controls.Add(this.lbContact);
            this.panelContact.Controls.Add(this.borderPanelContact);
            this.panelContact.Location = new System.Drawing.Point(100, 200);
            this.panelContact.Margin = new System.Windows.Forms.Padding(0);
            this.panelContact.Name = "panelContact";
            this.panelContact.Size = new System.Drawing.Size(350, 300);
            this.panelContact.TabIndex = 0;
            // 
            // lbContact
            // 
            this.lbContact.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(0, 250);
            this.lbContact.Margin = new System.Windows.Forms.Padding(0);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(350, 50);
            this.lbContact.TabIndex = 0;
            this.lbContact.Text = "Liên hệ với chúng tôi";
            this.lbContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChatbot
            // 
            this.panelChatbot.BackColor = System.Drawing.Color.Transparent;
            this.panelChatbot.Controls.Add(this.lbChatbot);
            this.panelChatbot.Controls.Add(this.borderPanelChatbot);
            this.panelChatbot.Location = new System.Drawing.Point(650, 200);
            this.panelChatbot.Margin = new System.Windows.Forms.Padding(0);
            this.panelChatbot.Name = "panelChatbot";
            this.panelChatbot.Size = new System.Drawing.Size(350, 300);
            this.panelChatbot.TabIndex = 0;
            // 
            // lbChatbot
            // 
            this.lbChatbot.BackColor = System.Drawing.Color.Transparent;
            this.lbChatbot.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChatbot.Location = new System.Drawing.Point(0, 250);
            this.lbChatbot.Margin = new System.Windows.Forms.Padding(0);
            this.lbChatbot.Name = "lbChatbot";
            this.lbChatbot.Size = new System.Drawing.Size(350, 50);
            this.lbChatbot.TabIndex = 0;
            this.lbChatbot.Text = "Tóm tắt hợp đồng";
            this.lbChatbot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borderPanelChatbot
            // 
            this.borderPanelChatbot.BackgroundColor = System.Drawing.Color.Transparent;
            this.borderPanelChatbot.BackgroundImage = global::CNPM_FINAL.Properties.Resources.chatbot;
            this.borderPanelChatbot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.borderPanelChatbot.BorderColor = System.Drawing.Color.Black;
            this.borderPanelChatbot.BorderRadius = 125;
            this.borderPanelChatbot.BorderSize = 1;
            this.borderPanelChatbot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borderPanelChatbot.Location = new System.Drawing.Point(50, 0);
            this.borderPanelChatbot.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelChatbot.Name = "borderPanelChatbot";
            this.borderPanelChatbot.Size = new System.Drawing.Size(250, 250);
            this.borderPanelChatbot.TabIndex = 0;
            this.borderPanelChatbot.Click += new System.EventHandler(this.borderPanelChatbot_Click);
            // 
            // borderPanelContact
            // 
            this.borderPanelContact.BackgroundColor = System.Drawing.Color.Transparent;
            this.borderPanelContact.BackgroundImage = global::CNPM_FINAL.Properties.Resources.contact;
            this.borderPanelContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.borderPanelContact.BorderColor = System.Drawing.Color.Black;
            this.borderPanelContact.BorderRadius = 125;
            this.borderPanelContact.BorderSize = 1;
            this.borderPanelContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borderPanelContact.Location = new System.Drawing.Point(50, 0);
            this.borderPanelContact.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelContact.Name = "borderPanelContact";
            this.borderPanelContact.Size = new System.Drawing.Size(250, 250);
            this.borderPanelContact.TabIndex = 0;
            this.borderPanelContact.Click += new System.EventHandler(this.borderPanelContact_Click);
            // 
            // MainSupportGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.ControlBox = false;
            this.Controls.Add(this.panelChatbot);
            this.Controls.Add(this.panelContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainSupportGUI";
            this.Text = "MainSupportGUI";
            this.panelContact.ResumeLayout(false);
            this.panelChatbot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContact;
        private CustomControl.BorderPanel borderPanelContact;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Panel panelChatbot;
        private System.Windows.Forms.Label lbChatbot;
        private CustomControl.BorderPanel borderPanelChatbot;
    }
}