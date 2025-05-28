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
    public partial class CreateTaskGUI : Form
    {
        #region properties
        private readonly TaskProgressBLL taskProgressBLL = new TaskProgressBLL();
        private readonly ContractBLL contractBLL = new ContractBLL();
        private readonly UserBLL userBLL = new UserBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private readonly Dictionary<string, List<string>> taskStatus = new Dictionary<string, List<string>> {
            {"en", new List<string> { "In Progress", "Completed", "Canceled" }},
            {"vi", new List<string> { "Đang thực hiện", "Đã hoàn thành", "Đã hủy" }}
        };
        #endregion

        public CreateTaskGUI()
        {
            InitializeComponent();
            InitTextContent();
            InitComboBox();
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

        #region init
        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.CREATE_TASK, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnCreate.Text = GetLocalizedString("btnCreate");

            this.lbContractCode.Text = GetLocalizedString("lbContractCode");
            this.lbDateFinish.Text = GetLocalizedString("lbDateFinish");
            this.lbDateStart.Text = GetLocalizedString("lbDateStart");
            this.lbSaleCode.Text = GetLocalizedString("lbUserCode");
            this.lbStatus.Text = GetLocalizedString("lbStatus");
            this.lbTaskName.Text = GetLocalizedString("lbTaskName");

            this.comboBoxStatus.Items.Clear();
            this.comboBoxStatus.Items.AddRange(taskStatus[SettingContext.Language].ToArray());
            this.comboBoxStatus.SelectedIndex = 0;

            this.lbContractCodeErr.Text = this.lbTaskNameErr.Text
                = this.lbSaleCodeErr.Text = this.lbDateFinishErr.Text = "";
        }

        private void InitComboBox()
        {
            comboBoxContractCode.Focus();
            comboBoxContractCode.MaxDropDownItems = 5;
            comboBoxContractCode.IntegralHeight = false;
            comboBoxUserCode.MaxDropDownItems = 5;
            comboBoxUserCode.IntegralHeight = false;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region methods
        private Color rgba(int r, int g, int b, double alpha)
        {
            return Color.FromArgb((int)(alpha * 255), r, g, b);
        }

        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);
        #endregion

        #region events
        private void textBoxTaskName_Event(object sender, EventArgs e) => this.lbTaskNameErr.Text = "";
        private void dateTime_Event(object sender, EventArgs e) => this.lbDateFinishErr.Text = "";

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            ComboBox[] comboBoxes = { comboBoxContractCode, comboBoxUserCode };
            Label[] labels = { lbContractCodeErr, lbSaleCodeErr };

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                if (string.IsNullOrEmpty(comboBoxes[i].Text))
                {
                    labels[i].Text = GetLocalizedString("lbRequired");
                    isValid = false;
                }
            }

            if (string.IsNullOrEmpty(textBoxTaskName.Text))
            {
                lbTaskNameErr.Text = GetLocalizedString("lbRequired");
                isValid = false;
            }

            if (dateTimeStart.Value.Date > dateTimeFinish.Value.Date)
            {
                lbDateFinishErr.Text = GetLocalizedString("validateDate");
                isValid = false;
            }

            if (textBoxTaskName.Text.Length > 255)
            {
                lbTaskNameErr.Text = GetLocalizedString("lengthTaskName");
                isValid = false;
            }

            if (!isValid) return;

            var task = new TaskProgressDTO
            {
                status = taskStatus["en"][comboBoxStatus.SelectedIndex],
                taskName = textBoxTaskName.Text,
                startDate = dateTimeStart.Value,
                endDate = dateTimeFinish.Value,
                contractCode = comboBoxContractCode.Text,
                assignedTo = comboBoxUserCode.Text
            };

            try
            {
                taskProgressBLL.Insert(task);
                MessageBox.Show(GetLocalizedString("success"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnCancel.PerformClick();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.comboBoxContractCode.Text = this.textBoxTaskName.Text
                = this.comboBoxUserCode.Text = "";
            this.lbContractCodeErr.Text = this.lbTaskNameErr.Text
                = this.lbSaleCodeErr.Text = this.lbDateFinishErr.Text = "";
            this.dateTimeStart.Value = DateTime.Now;

            this.comboBoxContractCode.Focus();
        }
        #endregion

        #region comboBox events
        private void debounceContractTimer_Tick(object sender, EventArgs e)
        {
            debounceContractTimer.Stop();
            HandleTextConntractChanged();
        }

        private void comboBoxContractCode_TextChanged(object sender, EventArgs e)
        {
            this.lbContractCodeErr.Text = "";
            debounceContractTimer.Stop();
            debounceContractTimer.Start();
        }

        private void HandleTextConntractChanged()
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
        #endregion
    }
}
