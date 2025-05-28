using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using CNPM_FINAL.GUI.SubItem.Commission;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Task
{
    public partial class UpdateTaskGUI : Form
    {
        #region properties
        private readonly TaskProgressBLL taskProgressBLL = new TaskProgressBLL();
        private readonly ContractBLL contractBLL = new ContractBLL();
        private readonly UserBLL userBLL = new UserBLL();
        private readonly TaskProgressDTO referencedTask = null;
        public EventHandler<EventArgs> OpenListGUI;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private readonly Dictionary<string, List<string>> taskStatus = new Dictionary<string, List<string>> {
            {"en", new List<string> { "In Progress", "Completed", "Canceled" }},
            {"vi", new List<string> { "Đang thực hiện", "Đã hoàn thành", "Đã hủy" }}
        };
        #endregion

        public UpdateTaskGUI(TaskProgressDTO task)
        {
            referencedTask = task;

            InitializeComponent();
            InitTextContent();
            InitData();

            comboBoxContractCode.Enabled = false;
            comboBoxUserCode.Focus();
            comboBoxUserCode.MaxDropDownItems = 5;
            comboBoxUserCode.IntegralHeight = false;
            this.comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region methods
        private Color rgba(int r, int g, int b, double alpha)
        {
            return Color.FromArgb((int)(alpha * 255), r, g, b);
        }

        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);
        #endregion

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
            resourceManager = new ResourceManager(ResourceContext.UPDATE_TASK, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnUpdate.Text = GetLocalizedString("btnUpdate");

            this.lbContract.Text = GetLocalizedString("lbContractCode");
            this.lbDateFinish.Text = GetLocalizedString("lbDateFinish");
            this.lbDateStart.Text = GetLocalizedString("lbDateStart");
            this.lbSaleCode.Text = GetLocalizedString("lbUserCode");
            this.lbStatus.Text = GetLocalizedString("lbStatus");
            this.lbTaskName.Text = GetLocalizedString("lbTaskName");

            this.comboBoxStatus.Items.Clear();
            this.comboBoxStatus.Items.AddRange(taskStatus[SettingContext.Language].ToArray());
            this.comboBoxStatus.SelectedIndex = 0;

            this.lbContractErr.Text = this.lbDateFinishErr.Text
                = this.lbSaleCodeErr.Text = this.lbTaskNameErr.Text
                = "";
        }

        private void InitData()
        {
            if (referencedTask == null)
            {
                MessageBox.Show(GetLocalizedString("updateErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenListGUI?.Invoke(this, EventArgs.Empty);
                return;
            }

            this.comboBoxContractCode.Text = referencedTask.contractCode;
            this.textBoxTaskName.Text = referencedTask.taskName;
            this.comboBoxUserCode.Text = referencedTask.assignedTo;
            this.dateTimeStart.Value = referencedTask.startDate;
            this.dateTimeFinish.Value = referencedTask.endDate;
            if (taskStatus.ContainsKey(SettingContext.Language))
            {
                this.comboBoxStatus.SelectedIndex = taskStatus["en"].IndexOf(referencedTask.status);
            }
        }
        #endregion

        #region textBox events
        private void textBoxTask_Click(object sender, EventArgs e) => this.lbTaskNameErr.Text = "";
        private void textBoxSaleCode_Click(object sender, EventArgs e) => this.lbSaleCodeErr.Text = "";
        private void textBoxTask_TextChanged(object sender, EventArgs e) => this.lbTaskNameErr.Text = "";
        private void textBoxSaleCode_TextChanged(object sender, EventArgs e) => this.lbSaleCodeErr.Text = "";
        private void dateTimeStart_Event(object sender, EventArgs e) => this.lbDateFinishErr.Text = "";
        private void dateTimeFinish_Event(object sender, EventArgs e) => this.lbDateFinishErr.Text = "";
        #endregion

        #region button events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GetLocalizedString("warning"), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                OpenListGUI?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            ComboBox[] comboBoxes = { this.comboBoxContractCode, this.comboBoxUserCode };
            Label[] labels = { this.lbContractErr, this.lbSaleCodeErr };

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                if (string.IsNullOrEmpty(comboBoxes[i].Text))
                {
                    labels[i].Text = GetLocalizedString("lbRequired");
                    isValid = false;
                }
            }

            if (string.IsNullOrEmpty(this.textBoxTaskName.Text))
            {
                this.lbTaskNameErr.Text = GetLocalizedString("lbRequired");
                isValid = false;
            }

            if (this.dateTimeStart.Value.Date > this.dateTimeFinish.Value.Date)
            {
                this.lbDateFinishErr.Text = GetLocalizedString("validateDate");
                isValid = false;
            }

            if (!isValid) return;

            if (this.textBoxTaskName.Text.Length > 255)
            {
                this.lbTaskNameErr.Text = GetLocalizedString("lengthTaskName");
                return;
            }

            if (this.comboBoxUserCode.Text != referencedTask.assignedTo)
            {
                if (MessageBox.Show(GetLocalizedString("warningChangeUser"), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            referencedTask.status = taskStatus["en"][comboBoxStatus.SelectedIndex];
            referencedTask.taskName = textBoxTaskName.Text;
            referencedTask.startDate = dateTimeStart.Value;
            referencedTask.endDate = dateTimeFinish.Value;
            referencedTask.assignedTo = comboBoxUserCode.Text;

            try
            {
                taskProgressBLL.Update(referencedTask);
                MessageBox.Show(GetLocalizedString("success"), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenListGUI?.Invoke(this, EventArgs.Empty);
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
        #endregion

        #region comboBox events
        private void debounceUserTimer_Tick(object sender, EventArgs e)
        {
            debounceUserTimer.Stop();
            HandleTextUserChanged();
        }

        private void comboBoxUserCode_TextChanged(object sender, EventArgs e)
        {
            debounceUserTimer.Stop();
            debounceUserTimer.Start();
        }

        private void HandleTextUserChanged()
        {
            if (comboBoxUserCode.Items.Count > 0)
            {
                comboBoxUserCode.Items.Clear();
            }

            try
            {
                var userCodes = userBLL.GetAllUserCode(comboBoxUserCode.Text.Trim());
                if (userCodes != null && userCodes.Count > 0)
                {
                    comboBoxUserCode.Items.AddRange(userCodes.ToArray());
                }
                else
                {
                    comboBoxUserCode.Items.Add("");
                }
            }
            catch (Exception) { }
            finally
            {
                comboBoxUserCode.SelectionStart = comboBoxUserCode.Text.Length;
            }
        }

        private void comboBoxContractCode_TextChanged(object sender, EventArgs e)
        {
            debounceContractTimer.Stop();
            debounceContractTimer.Start();
        }

        private void debounceContractTimer_Tick(object sender, EventArgs e)
        {
            debounceUserTimer.Stop();
            HandleTextContractChanged();
        }

        private void HandleTextContractChanged()
        {
            if (comboBoxContractCode.Items.Count > 0)
            {
                comboBoxContractCode.Items.Clear();
            }

            try
            {
                var contractCodes = contractBLL.GetAllContractCodes(comboBoxContractCode.Text.Trim());
                if (contractCodes != null && contractCodes.Count > 0)
                {
                    comboBoxContractCode.Items.AddRange(contractCodes.ToArray());
                }
                else
                {
                    comboBoxContractCode.Items.Add("");
                }
            }
            catch (Exception) { }
            finally
            {
                comboBoxContractCode.SelectionStart = comboBoxContractCode.Text.Length;
            }
        }
        #endregion
    }
}
