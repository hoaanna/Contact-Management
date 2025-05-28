using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Commission
{
    public partial class DateCommissionGUI : Form
    {
        private readonly SettingBLL settingBLL = new SettingBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;

        public DateCommissionGUI()
        {
            InitializeComponent();
            InitTextContent();

            checkBoxFilter.Checked = false;
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "dd/MM/yyyy";
            dateTimePickerFrom.Value = DateTime.Now.Date;
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "dd/MM/yyyy";
            dateTimePickerTo.Value = DateTime.Now.Date;
            dateTimePickerFrom.Enabled = dateTimePickerTo.Enabled = checkBoxFilter.Checked;


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

        private bool ValidateDateTime()
        {
            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            { 
                lbFilterErr.Text = GetLocalizedString("invalidDate");
                return false;
            }
            lbFilterErr.Text = "";
            return true;
        }

        private void ShowHistoryCommissionDate()
        {
            if (!checkBoxFilter.Checked)
            {
                lbFilterErr.Text = "";
                dataGridViewCommission.Rows.Clear();
                AddRows(settingBLL.GetAll());
                return;
            }
            else
            {
                if (!ValidateDateTime())
                {
                    return;
                }

                lbFilterErr.Text = "";
                dataGridViewCommission.Rows.Clear();
                DateTime dateFrom = dateTimePickerFrom.Value.Date;
                DateTime dateTo = dateTimePickerTo.Value.Date.AddDays(1).AddTicks(-1);
                AddRows(settingBLL.GetAll(dateFrom, dateTo));
            }
        }

        private void AddRows(List<SettingDTO> historyCommissionDate)
        {
            dataGridViewCommission.Rows.Clear();
            if (historyCommissionDate.Count == 0)
            {
                return;
            }

            foreach (var history in historyCommissionDate)
            {
                dataGridViewCommission.Rows.Add(history.value, history.effectiveDate.ToString("dd/MM/yyyy"));
            }
        }
        #endregion

        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.DATE_COMMISSION, typeof(DateCommissionGUI).Assembly);

            string currentDate = settingBLL.GetCurrentDate() != null ? 
                settingBLL.GetCurrentDate().value.ToString() : "0";

            this.lbTitle.Text = GetLocalizedString("lbTitle");
            this.lbCurrentDate.Text = GetLocalizedString("lbDateCurrent")
                + currentDate;
            this.lbHistory.Text = GetLocalizedString("lbHistory");
            this.lbNewDate.Text = GetLocalizedString("lbNewDate");

            this.checkBoxFilter.Text = GetLocalizedString("lbFilter");

            this.btnChangeDate.Text = GetLocalizedString("btnChangeDate");

            this.columnDate.HeaderText = GetLocalizedString("columnDate");
            this.columnValue.HeaderText = GetLocalizedString("columnValue");

            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnSave.Text = GetLocalizedString("btnSave");

            dataGridViewCommission.Rows.Clear();
            ShowHistoryCommissionDate();

        }

        private void btnChangeDate_Click(object sender, EventArgs e) => panelChangeDate.Visible = true;

        private void btnCancel_Click(object sender, EventArgs e) => panelChangeDate.Visible = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxNewDate.Text, out int newDate) || newDate < 1 || newDate > 28)
            {
                var message = SettingContext.Language == "vi" ? 
                    "Ngày phải là số trong khoảng 1 - 28" : "Date must be a number in range 1 - 28";
                MessageBox.Show(message, GetLocalizedString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var historyCommission = new SettingDTO()
            {
                value = Convert.ToInt32(textBoxNewDate.Text),
                effectiveDate = DateTime.Now
            };
            settingBLL.Insert(historyCommission);
            panelChangeDate.Visible = false;
            string currentDate = settingBLL.GetCurrentDate() != null ?
                settingBLL.GetCurrentDate().value.ToString() : "0";

            this.lbCurrentDate.Text = GetLocalizedString("lbDateCurrent")
                + currentDate;
            dataGridViewCommission.Rows.Clear();
            ShowHistoryCommissionDate();
        }

        private void dateTimePicker_Event(object sender, EventArgs e)
        {
            ShowHistoryCommissionDate();
        }

        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFrom.Enabled
            = dateTimePickerTo.Enabled = checkBoxFilter.Checked;
            ShowHistoryCommissionDate();
        }

    }
}
