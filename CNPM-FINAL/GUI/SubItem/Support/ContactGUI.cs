using CNPM_FINAL.Context;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Support
{
    public partial class ContactGUI : Form
    {

        private readonly Dictionary<string, string> language = new Dictionary<string, string>
        {
            {"vi", "Liên hệ với chúng tôi qua địa chỉ sau" },
            {"en", "Contact us at the following address" }
        };
        public ContactGUI()
        {
            InitializeComponent();
            this.lbTitle.Text = language[SettingContext.Language];
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
            this.lbTitle.Text = language[SettingContext.Language];
        }
        #endregion
    }
}
