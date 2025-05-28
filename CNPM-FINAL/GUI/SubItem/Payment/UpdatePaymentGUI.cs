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
    public partial class UpdatePaymentGUI : Form
    {
        #region properties
        private readonly PaymentStageBLL paymentBLL = new PaymentStageBLL();
        private readonly PaymentStageDTO referancedPayment;
        public EventHandler<EventArgs> OpenListGUI;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        private readonly Dictionary<string, List<string>> paymentStatus = new Dictionary<string, List<string>> {
            {"en", new List<string> { "Unpaid", "Completed" }},
            {"vi", new List<string> { "Chưa thanh toán", "Đã thanh toán" }}
        };
        #endregion

        public UpdatePaymentGUI(PaymentStageDTO payment)
        {
            referancedPayment = payment;

            InitializeComponent();
            InitTextContent();
            InitData();

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

        #region  init
        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.UPDATE_PAYMENT, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnUpdate.Text = GetLocalizedString("btnUpdate");

            this.lbDescription.Text = GetLocalizedString("lbDescription");
            this.lbPaymentDate.Text = GetLocalizedString("lbDate");
            this.lbStageName.Text = GetLocalizedString("lbStageName");

            if (paymentStatus.ContainsKey(SettingContext.Language))
            {
                this.comboBoxStatus.Items.Clear();
                this.comboBoxStatus.Items.AddRange(paymentStatus[SettingContext.Language].ToArray());
                this.comboBoxStatus.SelectedIndex = 0;
            }

            this.lbStageNameErr.Text = this.lbPaymentDateErr.Text 
                = this.lbDescriptionErr.Text = "";

            if(referancedPayment.status == "Unpaid" || referancedPayment.status == "Chưa thanh toán")
            {
                this.textBoxAmount.Enabled = true;
            }
            else
            {
                this.textBoxAmount.Enabled = false;
            }
        }
        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);

        private void InitData()
        {
            if (referancedPayment == null)
            {
                MessageBox.Show(GetLocalizedString("notFound"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenListGUI?.Invoke(this, EventArgs.Empty);
                return;
            }

            if (paymentStatus.ContainsKey(SettingContext.Language))
            {
                this.comboBoxStatus.SelectedIndex = paymentStatus["en"].IndexOf(referancedPayment.status);
            }
            textBoxStageName.Text = referancedPayment.stageName;
            textBoxDescription.Text = referancedPayment.description;
            dateTimePicker.Value = referancedPayment.paymentDate;
            comboBoxContractCode.Text = referancedPayment.contractCode;
            textBoxAmount.Text = referancedPayment.amount.ToString("N0");
        }
        #endregion

        #region
        private void ChangeFormatAmount(TextBox textBox)
        {
            string amountStr = textBox.Text.Trim().Replace(".", "").Replace(",", "");
            if (amountStr.Length > 0)
            {
                textBox.Text = BigInteger.Parse(amountStr).ToString("#,0", CultureInfo.InvariantCulture);
                textBox.Select(textBox.Text.Length, 0);
            }
        }
        #endregion

        #region events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GetLocalizedString("warning"), "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenListGUI?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            TextBox[] textBoxes = { textBoxStageName, textBoxDescription };
            Label[] labels = { lbStageNameErr, lbDescriptionErr };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    labels[i].Text = GetLocalizedString("lbRequired");
                    isValid = false;
                }
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

            if (!isValid) return;

            var payment = new PaymentStageDTO
            {
                id = referancedPayment.id,
                stageName = textBoxStageName.Text,
                amount = Decimal.Parse(textBoxAmount.Text),
                paymentDate = dateTimePicker.Value,
                description = textBoxDescription.Text,
                status = paymentStatus["en"][comboBoxStatus.SelectedIndex]
            };

            try
            {
                paymentBLL.Update(payment);
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

        private void textBoxStageName_Event(object sender, EventArgs e) => lbStageNameErr.Text = "";
        private void textBoxDescription_Event(object sender, EventArgs e) => lbDescriptionErr.Text = "";
        private void dateTimePicker_Event(object sender, EventArgs e) => lbPaymentDateErr.Text = "";
        #endregion

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            this.lbAmountErr.Text = "";
            ChangeFormatAmount(textBoxAmount);
        }

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
    }
}
