using CNPM_FINAL.DTO;
using CNPM_FINAL.BLL;
using System;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Windows.Forms;
using System.Resources;
using CNPM_FINAL.Context;
using CNPM_FINAL.GUI.SubItem.Commission;

namespace CNPM_FINAL.GUI.SubItem.Contract
{
    public partial class CreateContractGUI : Form
    {
        private readonly ContractBLL contractBLL = new ContractBLL();
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;

        public CreateContractGUI()
        {
            InitializeComponent();
            InitTextContent();
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
        private void ChangeFormatAmount(TextBox textBox)
        {
            string amountStr = textBox.Text.Trim().Replace(".", "").Replace(",", "");
            if (amountStr.Length > 0)
            {
                textBox.Text = BigInteger.Parse(amountStr).ToString("#,0", CultureInfo.InvariantCulture);
                textBox.Select(textBox.Text.Length, 0);
            }
        }

        private string GetLocalizedString(string key)
        {
            return resourceManager.GetString(key, cultureInfo);
        }

        private Color rgba(int r, int g, int b, double alpha)
        {
            return Color.FromArgb((int)(alpha * 255), r, g, b);
        }
        #endregion

        #region init
        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.CREATE_CONTRACT, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.lbContractCode.Text = GetLocalizedString("lbContractCode");
            this.lbContractName.Text = GetLocalizedString("lbContractName");
            this.lbContent.Text = GetLocalizedString("lbContractContent");
            this.lbDateSign.Text = GetLocalizedString("lbSignedDate");
            this.lbDateExpire.Text = GetLocalizedString("lbExpiredDate");
            this.lbPartner.Text = GetLocalizedString("lbPartner");
            this.lbCommissionPercentage.Text = GetLocalizedString("lbCommission");
            this.lbEmail.Text = GetLocalizedString("lbEmail");
            this.lbPhone.Text = GetLocalizedString("lbPhone");
            this.lbAmount.Text = GetLocalizedString("lbAmount");
            this.lbContact.Text = GetLocalizedString("lbContact");
            this.lbOrganization.Text = GetLocalizedString("lbOrganization");

            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnCreate.Text = GetLocalizedString("btnCreate");

            this.lbContractCodeErr.Text = this.lbContractNameErr.Text = this.lbContentErr.Text
                = this.lbPartnerErr.Text = this.lbCommissionPercentageErr.Text = this.lbEmailErr.Text
                = this.lbPhoneErr.Text = this.lbAmountErr.Text
                = this.lbOrganizationErr.Text = "";
        }
        #endregion

        #region button
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.textBoxContractCode.Text = this.textBoxContractName.Text = this.textBoxContent.Text
                = this.textBoxPartner.Text = this.textBoxCommissionPercentage.Text = this.textBoxEmail.Text
                = this.textBoxPhone.Text = this.textBoxAmount.Text = this.textBoxOrganization.Text = "";

            this.lbContractCodeErr.Text = this.lbContractNameErr.Text = this.lbContentErr.Text
                = this.lbPartnerErr.Text = this.lbCommissionPercentageErr.Text = this.lbEmailErr.Text
                = this.lbPhoneErr.Text = this.lbAmountErr.Text
                = this.lbOrganizationErr.Text = "";

            this.dateTimeSign.Value = this.dateTimeExpire.Value = DateTime.Now;

            this.textBoxContractCode.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            TextBox[] textBoxes = { textBoxContractCode, textBoxContractName, textBoxContent, textBoxPartner, textBoxPhone, textBoxEmail, textBoxCommissionPercentage, textBoxAmount, textBoxOrganization };
            Label[] labels = { lbContractCodeErr, lbContractNameErr, lbContentErr, lbPartnerErr, lbPhoneErr, lbEmailErr, lbCommissionPercentageErr, lbAmountErr, lbOrganizationErr };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    labels[i].Text = GetLocalizedString("lbRequired");
                    isValid = false;
                }
            }
            if (!isValid) return;

            if (dateTimeSign.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show(GetLocalizedString("validateSignedDate"),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimeSign.Value.Date > dateTimeExpire.Value.Date)
            {
                MessageBox.Show(GetLocalizedString("validateExpirationDate"),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                lbEmailErr.Text = GetLocalizedString("invalidEmail");
                isValid = false;
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPhone.Text, @"^[0-9]{9,12}$"))
            {
                lbPhoneErr.Text = GetLocalizedString("invalidPhone");
                isValid = false;
            }


            if (!isValid) return;

            if (this.textBoxContractCode.Text.Length > 10 || this.textBoxContractCode.Text.Length < 5)
            {
                lbContractCodeErr.Text = GetLocalizedString("lengthContractCode");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxContractCode.Text, @"^[a-zA-Z0-9]+$"))
            {
                lbContractCodeErr.Text = GetLocalizedString("invaliContractCode");
                return;
            }

            if (this.textBoxContractName.Text.Length > 255)
            {
                this.lbContractNameErr.Text = GetLocalizedString("lengthContractName");
                return;
            }

            double amount;
            if (!double.TryParse(this.textBoxAmount.Text.Trim()
                .Replace(",","").Replace(".",""), out amount))
            {
                var message = SettingContext.Language == "vi" ?
                    "Số tiền không hợp lệ" : "Invalid amount";
                this.lbAmountErr.Text = message;
                return;
            }

            if (amount < 100000)
            {
                var message = SettingContext.Language == "vi" ?
                    "Tối thiểu là 100,000" : "Minimum is 100,000";
                this.lbAmountErr.Text = message;
                return;
            }

            if(amount > 1000000000000)
            {
                var message = SettingContext.Language == "vi" ?
                    "Tối đa là 1,000,000,000,000" : "Maximum is 1,000,000,000,000";
                this.lbAmountErr.Text = message;
                return;
            }

            double commissionPercentage;
            if (!double.TryParse(this.textBoxCommissionPercentage.Text, out commissionPercentage))
            {
                this.lbCommissionPercentageErr.Text = GetLocalizedString("invalidCommission");
                return;
            }

            if (commissionPercentage <= 0 || commissionPercentage > 100)
            {
                this.lbCommissionPercentageErr.Text = GetLocalizedString("invalidCommission");
                return;
            }

            var contract = new ContractDTO
            {
                contractCode = this.textBoxContractCode.Text,
                contractName = this.textBoxContractName.Text,
                contractContent = this.textBoxContent.Text,
                signedDate = this.dateTimeSign.Value,
                expiredDate = this.dateTimeExpire.Value,
                partnerName = this.textBoxPartner.Text,
                contactEmail = this.textBoxEmail.Text,
                contactPhone = this.textBoxPhone.Text,
                totalValue = (double)BigInteger.Parse(this.textBoxAmount.Text.Trim().Replace(".", "").Replace(",", "")),
                commissionPercentage = commissionPercentage,
                origanizationName = this.textBoxOrganization.Text
            };

            try
            {
                contractBLL.Insert(contract);
                MessageBox.Show(GetLocalizedString("success"),
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnCancel.PerformClick();
            }
            catch (BuisinessException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(GetLocalizedString("undefinedErr"),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region textBox
        private void textBoxContractCode_Event(object sender, EventArgs e) => this.lbContractCodeErr.Text = "";
        private void textBoxContent_Event(object sender, EventArgs e) => this.lbContentErr.Text = "";
        private void textBoxPartner_Event(object sender, EventArgs e) => this.lbPartnerErr.Text = "";
        private void textBoxCommissionPercentage_Event(object sender, EventArgs e) => this.lbCommissionPercentageErr.Text = "";
        private void textBoxEmail_Event(object sender, EventArgs e) => this.lbEmailErr.Text = "";
        private void textBoxPhone_Event(object sender, EventArgs e) => this.lbPhoneErr.Text = "";
        private void textBoxAmount_Event(object sender, EventArgs e) => this.lbAmountErr.Text = "";
        private void textBoxContractName_Event(object sender, EventArgs e) => this.lbContractNameErr.Text = "";
        private void textBoxOrganization_Event(object sender, EventArgs e) => this.lbOrganizationErr.Text = "";

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.Length >= 20)
            {
                e.Handled = true;
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            this.lbAmountErr.Text = "";
            ChangeFormatAmount(textBoxAmount);
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.Length >= 12)
            {
                e.Handled = true;
            }
        }

        private void textBoxCommissionPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Length == 0)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

            if ((sender as TextBox).Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxContractCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
