using CNPM_FINAL.BLL;
using CNPM_FINAL.Context;
using CNPM_FINAL.DTO;
using CNPM_FINAL.GUI.SubItem.Commission;
using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Contract
{
    public partial class UpdateContractGUI : Form
    {
        #region properties
        private readonly ContractBLL contractBLL = new ContractBLL();
        private readonly UserBLL userBLL = new UserBLL();
        private readonly ContractDTO referencedConntract;
        private readonly string contractCode;
        public EventHandler<EventArgs> OpenListGUI;
        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;
        #endregion

        public UpdateContractGUI(ContractDTO contract)
        {
            referencedConntract = contract;
            contractCode = contract.contractCode;

            InitializeComponent();
            InitTextContent();
            InitData();

            this.comboBoxUserCode.MaxDropDownItems = 5;
            this.comboBoxUserCode.IntegralHeight = false;
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

        private Color rgba(int r, int g, int b, float alpha)
        {
            return Color.FromArgb((int)(alpha * 255), r, g, b);
        }
        #endregion

        #region init
        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.UPDATE_CONTRACT, typeof(ListCommissionGUI).Assembly);

            this.lbTitle.Text = GetLocalizedString("title");
            this.btnCancel.Text = GetLocalizedString("btnCancel");
            this.btnUpdate.Text = GetLocalizedString("btnUpdate");

            this.lbCommissionPercentage.Text = GetLocalizedString("lbCommission");
            this.lbContent.Text = GetLocalizedString("lbContractContent");
            this.lbContractCode.Text = GetLocalizedString("lbContractCode");
            this.lbContractName.Text = GetLocalizedString("lbContractName");
            this.lbDateExpire.Text = GetLocalizedString("lbExpiredDate");
            this.lbDateSign.Text = GetLocalizedString("lbSignedDate");
            this.lbEmail.Text = GetLocalizedString("lbEmail");
            this.lbPartner.Text = GetLocalizedString("lbPartner");
            this.lbPhone.Text = GetLocalizedString("lbPhone");
            this.lbUserCode.Text = GetLocalizedString("lbUserCode");
            this.lbOrganization.Text = GetLocalizedString("lbOrganization");
            this.lbContact.Text = GetLocalizedString("lbContact");
            this.lbAmount.Text = GetLocalizedString("lbTotal");

            this.lbEmailErr.Text = this.lbCommissionPercentageErr.Text = this.lbContentErr.Text
                = this.lbContractCodeErr.Text = this.lbContractNameErr.Text = this.lbPartnerErr.Text
                = this.lbOrganizationErr.Text = this.lbPhoneErr.Text = this.lbUserCodeErr.Text = "";
        }

        private void InitData()
        {
            if (this.referencedConntract == null)
            {
                MessageBox.Show(GetLocalizedString("lbUserCode"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenListGUI?.Invoke(this, EventArgs.Empty);
                return;
            }

            this.textBoxContractCode.Text = referencedConntract.contractCode;
            this.textBoxContractName.Text = referencedConntract.contractName;
            this.textBoxAmount.Text = referencedConntract.totalValue.ToString("#,0");
            this.comboBoxUserCode.Text = referencedConntract.userCode;
            this.textBoxContent.Text = referencedConntract.contractContent;
            this.textBoxPartner.Text = referencedConntract.partnerName;
            this.textBoxCommissionPercentage.Text = referencedConntract.commissionPercentage.ToString();
            this.textBoxEmail.Text = referencedConntract.contactEmail;
            this.textBoxPhone.Text = referencedConntract.contactPhone;
            this.dateTimeSign.Value = referencedConntract.signedDate;
            this.dateTimeExpire.Value = referencedConntract.expiredDate;
            this.textBoxOrganization.Text = referencedConntract.origanizationName;

        }
        #endregion

        #region textBox events
        private void textBoxContractCode_Event(object sender, EventArgs e) => this.lbContractCodeErr.Text = "";
        private void textBoxContractName_Event(object sender, EventArgs e) => this.lbContractNameErr.Text = "";
        private void textBoxContent_Event(object sender, EventArgs e) => this.lbContentErr.Text = "";
        private void textBoxPartner_Event(object sender, EventArgs e) => this.lbPartnerErr.Text = "";
        private void textBoxCommissionPercentage_Event(object sender, EventArgs e) => this.lbCommissionPercentageErr.Text = "";
        private void textBoxEmail_Event(object sender, EventArgs e) => this.lbEmailErr.Text = "";
        private void textBoxPhone_Event(object sender, EventArgs e) => this.lbPhoneErr.Text = "";
        private void textBoxOrganization_Event(object sender, EventArgs e) => this.lbOrganizationErr.Text = "";
        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBoxPhone.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxContractCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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
        #endregion

        #region button events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GetLocalizedString("warningCancel"), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                OpenListGUI?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region validate data
            bool isValid = true;
            TextBox[] textBoxes = { textBoxContractCode, textBoxContractName, textBoxContent, textBoxCommissionPercentage, textBoxPartner, textBoxEmail, textBoxPhone, textBoxOrganization };
            Label[] labels = { lbContractCodeErr, lbContractNameErr, lbContentErr, lbCommissionPercentageErr, lbPartnerErr, lbEmailErr, lbPhoneErr, lbOrganizationErr };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                {
                    labels[i].Text = GetLocalizedString("lbRequired");
                    isValid = false;
                }
            }

            if (string.IsNullOrEmpty(comboBoxUserCode.Text))
            {
                lbUserCodeErr.Text = GetLocalizedString("lbRequired");
                isValid = false;
            }

            if (dateTimeSign.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show(GetLocalizedString("validateSignedDate"),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimeSign.Value.Date > dateTimeExpire.Value.Date)
            {
                MessageBox.Show(GetLocalizedString("validateExpirationDate"),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isValid) return;

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

            if (this.textBoxContractCode.Text.Length > 10 || this.textBoxContractCode.Text.Length < 5)
            {
                lbContractCodeErr.Text = GetLocalizedString("lengthContractCode");
                isValid = false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxContractCode.Text, @"^[a-zA-Z0-9]+$"))
            {
                lbContractCodeErr.Text = GetLocalizedString("invaliContractCode");
                isValid = false;
            }

            if (!double.TryParse(textBoxCommissionPercentage.Text, out double commissionPercentage) || 
                commissionPercentage <= 0 || commissionPercentage > 100)
            {
                lbCommissionPercentageErr.Text = GetLocalizedString("invaliCommission");
                isValid = false;
            }

            if (!isValid) return;
            #endregion  

            if (referencedConntract.userCode != comboBoxUserCode.Text)
            {
                if (MessageBox.Show(GetLocalizedString("warningChangeUser"), 
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    referencedConntract.userCode = comboBoxUserCode.Text.Trim();
                }
                else return;
            }

            try
            {
                referencedConntract.contractCode = textBoxContractCode.Text;
                referencedConntract.contractName = textBoxContractName.Text;
                referencedConntract.contractContent = textBoxContent.Text;
                referencedConntract.partnerName = textBoxPartner.Text;
                referencedConntract.commissionPercentage = commissionPercentage;
                referencedConntract.contactEmail = textBoxEmail.Text;
                referencedConntract.contactPhone = textBoxPhone.Text;
                referencedConntract.signedDate = dateTimeSign.Value;
                referencedConntract.expiredDate = dateTimeExpire.Value;
                referencedConntract.origanizationName = textBoxOrganization.Text;

                contractBLL.Update(referencedConntract, contractCode);
                MessageBox.Show(GetLocalizedString("success"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenListGUI?.Invoke(this, EventArgs.Empty);
            }
            catch (BuisinessException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(GetLocalizedString("undefinedErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region debounce
        private void debounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            HandleTextChanged();
        }

        private void comboBoxUserCode_TextChanged(object sender, EventArgs e)
        {
            this.lbUserCodeErr.Text = "";
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void HandleTextChanged()
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
