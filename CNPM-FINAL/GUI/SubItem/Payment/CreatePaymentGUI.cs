using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using CNPM_FINAL.GUI.SubItem.Commission;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Payment
{
    public partial class CreatePaymentGUI : Form
    {
        #region properties
        private readonly PaymentStageBLL paymentStageBLL = new PaymentStageBLL();
        private readonly ContractBLL contractBLL = new ContractBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private readonly Dictionary<string, List<string>> paymentStatus = new Dictionary<string, List<string>> {
            {"en", new List<string> { "Unpaid", "Completed" }},
            {"vi", new List<string> { "Chưa thanh toán", "Đã thanh toán" }}
        };
        #endregion

        public CreatePaymentGUI()
        {
            InitializeComponent();
            InitTextContent();

            this.comboBoxContractCode.MaxDropDownItems = 5;
            this.comboBoxContractCode.IntegralHeight = false;
            this.comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.CREATE_PAYMENT, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnCreate.Text = GetLocalizedString("btnCreate");

            this.lbAmount.Text = GetLocalizedString("lbAmount");
            this.lbContractCode.Text = GetLocalizedString("lbContractCode");
            this.lbDescription.Text = GetLocalizedString("lbDescription");
            this.lbPaymentDate.Text = GetLocalizedString("lbDate");
            this.lbStageName.Text = GetLocalizedString("lbStageName");
            this.lbStatus.Text = GetLocalizedString("lbStatus");

            this.comboBoxStatus.Items.Clear();
            this.comboBoxStatus.Items.AddRange(paymentStatus[SettingContext.Language].ToArray());
            this.comboBoxStatus.SelectedIndex = 0;

            this.lbContractCodeErr.Text = this.lbStageNameErr.Text
                = this.lbDescriptionErr.Text = this.lbAmountErr.Text = "";
        }

        #region methods
        private void ChangeFormatAmount(TextBox textBox)
        {
            string amountStr = textBox.Text.Trim().Replace(".", "").Replace(",", "");
            if (amountStr.Length > 0)
            {
                textBox.Text = BigInteger.Parse(amountStr).ToString("#,0", CultureInfo.InvariantCulture);
                textBox.Select(textBox.Text.Length, 0);
            }
        }

        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);

        private Color rgba(int r, int g, int b, double alpha)
        {
            return Color.FromArgb((int)(alpha * 255), r, g, b);
        }
        #endregion

        #region button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.comboBoxContractCode.Text = this.textBoxStageName.Text
                = this.textBoxDescription.Text = this.textBoxAmount.Text = "";

            this.lbContractCodeErr.Text = this.lbStageNameErr.Text
                = this.lbDescriptionErr.Text = this.lbAmountErr.Text = "";

            this.dateTimePicker.Value = DateTime.Now;
            this.comboBoxContractCode.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            TextBox[] textBoxes = { textBoxStageName, textBoxDescription, textBoxAmount };
            Label[] labels = { lbStageNameErr, lbDescriptionErr, lbAmountErr };

            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    labels[i].Text = GetLocalizedString("lbRequired");
                    isValid = false;
                }
            }

            if (string.IsNullOrEmpty(this.comboBoxContractCode.Text))
            {
                this.lbContractCodeErr.Text = GetLocalizedString("lbRequired");
                isValid = false;
            }

            if (!isValid) return;

            if (this.textBoxStageName.Text.Length > 255)
            {
                this.lbStageNameErr.Text = GetLocalizedString("lengthStageName");
                return;
            }

            if (this.textBoxAmount.Text.Trim().Length > 20)
            {
                var message = SettingContext.Language == "vi" ? "Số tiền quá lớn" : "Amount is too large";
                this.lbAmountErr.Text = message;
                return;
            }

            BigInteger totalAmount;
            if (!BigInteger.TryParse(this.textBoxAmount.Text.Trim().Replace(".", "").Replace(",", ""), out totalAmount))
            {
                this.lbAmountErr.Text = GetLocalizedString("validateAmount");
                return;
            }

            if (totalAmount < 100000)
            {
                var message = SettingContext.Language == "vi" ? "Tối thiểu là 100,000" : "Minimum is 100,000";
                this.lbAmountErr.Text = message;
                return;
            }

            var paymentStage = new PaymentStageDTO()
            {
                contractCode = this.comboBoxContractCode.Text,
                stageName = this.textBoxStageName.Text,
                description = this.textBoxDescription.Text,
                paymentDate = this.dateTimePicker.Value,
                status = paymentStatus["en"][comboBoxStatus.SelectedIndex],
                amount = (decimal)totalAmount
            };

            try
            {
                paymentStageBLL.Insert(paymentStage);
                MessageBox.Show(GetLocalizedString("success"), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel.PerformClick();
            }
            catch (BuisinessException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Undefined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region textBox
        private void textBoxContractCode_Event(object sender, EventArgs e) => this.lbContractCodeErr.Text = "";
        private void textBoxStageName_Event(object sender, EventArgs e) => this.lbStageNameErr.Text = "";
        private void textBoxDescription_Event(object sender, EventArgs e) => this.lbDescriptionErr.Text = "";
        private void dateTime_Event(object sender, EventArgs e) => this.lbPaymentDateErr.Text = "";
        private void textBoxAmount_Click(object sender, EventArgs e) => this.lbAmountErr.Text = "";

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBoxAmount.Text.Length > 20 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            this.lbAmountErr.Text = "";
            ChangeFormatAmount(textBoxAmount);
        }
        #endregion

        #region debounce
        private void comboBoxContractCode_TextChanged(object sender, EventArgs e)
        {
            this.lbContractCodeErr.Text = "";
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            HandleTextChanged();
        }

        private void HandleTextChanged()
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
