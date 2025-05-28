using CNPM_FINAL.Context;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Support
{
    public partial class MainSupportGUI : Form
    {
        public EventHandler<EventArgs> OpenContact;
        public EventHandler<EventArgs> OpenChatbot;

        private readonly Dictionary<string, List<string>> language = new Dictionary<string, List<string>>
        {
            {"vi", new List<string> { "Liên hệ với chúng tôi", "Tóm tắt hợp đồng",} },
            {"en", new List<string> { "Contact with us" , "Contract Summary" } }
        };
        public MainSupportGUI()
        {
            InitializeComponent();

            this.lbContact.Text = language[SettingContext.Language][0];
            this.lbChatbot.Text = language[SettingContext.Language][1];

            int borderRadius = (int) this.borderPanelContact.Width / 2;
            this.borderPanelContact.BorderRadius = borderRadius;
            this.borderPanelChatbot.BorderRadius = borderRadius;

            if(UserContext.GetRoleName() == "Admin" 
                || UserContext.GetRoleName() == "Director")
            {
                this.panelChatbot.Visible = false;

                int starttX = this.Width / 2 - this.panelContact.Width / 2;
                this.panelContact.Location = new System.Drawing.Point(starttX, this.panelContact.Location.Y);
            }
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
            this.lbContact.Text = language[SettingContext.Language][0];
            this.lbChatbot.Text = language[SettingContext.Language][1];
        }
        #endregion

        private void borderPanelContact_Click(object sender, EventArgs e)
        {
            OpenContact?.Invoke(this, e);
        }

        private void borderPanelChatbot_Click(object sender, EventArgs e)
        {
            OpenChatbot?.Invoke(this, e);
        }
    }
}
