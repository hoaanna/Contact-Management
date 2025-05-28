using System.Windows.Forms;

namespace CNPM_FINAL.GUI.SubItem.Contract
{
    partial class UpdateContractGUI
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
            this.components = new System.ComponentModel.Container();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lbContentErr = new System.Windows.Forms.Label();
            this.borderPanelContent = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelContractCode = new System.Windows.Forms.Panel();
            this.lbContractCodeErr = new System.Windows.Forms.Label();
            this.borderPanelContractCode = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxContractCode = new System.Windows.Forms.TextBox();
            this.lbContractCode = new System.Windows.Forms.Label();
            this.panelDateExpire = new System.Windows.Forms.Panel();
            this.borderPanelDateExpire = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimeExpire = new System.Windows.Forms.DateTimePicker();
            this.lbDateExpire = new System.Windows.Forms.Label();
            this.panelContractName = new System.Windows.Forms.Panel();
            this.lbContractNameErr = new System.Windows.Forms.Label();
            this.borderPanelContractName = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxContractName = new System.Windows.Forms.TextBox();
            this.lbContractName = new System.Windows.Forms.Label();
            this.panelUserCode = new System.Windows.Forms.Panel();
            this.comboBoxUserCode = new System.Windows.Forms.ComboBox();
            this.lbUserCodeErr = new System.Windows.Forms.Label();
            this.lbUserCode = new System.Windows.Forms.Label();
            this.debounceTimer = new System.Windows.Forms.Timer(this.components);
            this.btnUpdate = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.btnCancel = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.borderPanelAmount = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.panelDateSign = new System.Windows.Forms.Panel();
            this.borderPanelDateSign = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimeSign = new System.Windows.Forms.DateTimePicker();
            this.lbDateSign = new System.Windows.Forms.Label();
            this.panelCommissionPercentage = new System.Windows.Forms.Panel();
            this.lbCommissionPercentageErr = new System.Windows.Forms.Label();
            this.borderPanelCommissionPercentage = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxCommissionPercentage = new System.Windows.Forms.TextBox();
            this.lbCommissionPercentage = new System.Windows.Forms.Label();
            this.panelOrganization = new System.Windows.Forms.Panel();
            this.lbOrganizationErr = new System.Windows.Forms.Label();
            this.borderPanelOrganization = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxOrganization = new System.Windows.Forms.TextBox();
            this.lbOrganization = new System.Windows.Forms.Label();
            this.panelContact = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.panelPartner = new System.Windows.Forms.Panel();
            this.lbPartnerErr = new System.Windows.Forms.Label();
            this.borderPanelPartner = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxPartner = new System.Windows.Forms.TextBox();
            this.lbPartner = new System.Windows.Forms.Label();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.lbPhoneErr = new System.Windows.Forms.Label();
            this.borderPanelPhone = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.lbEmailErr = new System.Windows.Forms.Label();
            this.borderPanelEmail = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            this.borderPanelContent.SuspendLayout();
            this.panelContractCode.SuspendLayout();
            this.borderPanelContractCode.SuspendLayout();
            this.panelDateExpire.SuspendLayout();
            this.borderPanelDateExpire.SuspendLayout();
            this.panelContractName.SuspendLayout();
            this.borderPanelContractName.SuspendLayout();
            this.panelUserCode.SuspendLayout();
            this.panelAmount.SuspendLayout();
            this.borderPanelAmount.SuspendLayout();
            this.panelDateSign.SuspendLayout();
            this.borderPanelDateSign.SuspendLayout();
            this.panelCommissionPercentage.SuspendLayout();
            this.borderPanelCommissionPercentage.SuspendLayout();
            this.panelOrganization.SuspendLayout();
            this.borderPanelOrganization.SuspendLayout();
            this.panelContact.SuspendLayout();
            this.panelPartner.SuspendLayout();
            this.borderPanelPartner.SuspendLayout();
            this.panelPhone.SuspendLayout();
            this.borderPanelPhone.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.borderPanelEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.lbContentErr);
            this.panelContent.Controls.Add(this.borderPanelContent);
            this.panelContent.Controls.Add(this.lbContent);
            this.panelContent.Location = new System.Drawing.Point(75, 180);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(605, 340);
            this.panelContent.TabIndex = 6;
            // 
            // lbContentErr
            // 
            this.lbContentErr.BackColor = System.Drawing.Color.Transparent;
            this.lbContentErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContentErr.ForeColor = System.Drawing.Color.Red;
            this.lbContentErr.Location = new System.Drawing.Point(20, 310);
            this.lbContentErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbContentErr.Name = "lbContentErr";
            this.lbContentErr.Size = new System.Drawing.Size(350, 20);
            this.lbContentErr.TabIndex = 0;
            // 
            // borderPanelContent
            // 
            this.borderPanelContent.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelContent.BorderColor = System.Drawing.Color.Black;
            this.borderPanelContent.BorderRadius = 10;
            this.borderPanelContent.BorderSize = 1;
            this.borderPanelContent.Controls.Add(this.textBoxContent);
            this.borderPanelContent.Location = new System.Drawing.Point(10, 30);
            this.borderPanelContent.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelContent.Name = "borderPanelContent";
            this.borderPanelContent.Size = new System.Drawing.Size(590, 280);
            this.borderPanelContent.TabIndex = 0;
            // 
            // textBoxContent
            // 
            this.textBoxContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContent.Location = new System.Drawing.Point(10, 10);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(570, 260);
            this.textBoxContent.TabIndex = 1;
            this.textBoxContent.Click += new System.EventHandler(this.textBoxContent_Event);
            this.textBoxContent.TextChanged += new System.EventHandler(this.textBoxContent_Event);
            // 
            // lbContent
            // 
            this.lbContent.BackColor = System.Drawing.Color.Transparent;
            this.lbContent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.Location = new System.Drawing.Point(10, 0);
            this.lbContent.Margin = new System.Windows.Forms.Padding(0);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(200, 25);
            this.lbContent.TabIndex = 0;
            this.lbContent.Text = "Nội dung hợp đồng";
            this.lbContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(75, 20);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(945, 70);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Chỉnh sửa hợp đồng";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContractCode
            // 
            this.panelContractCode.Controls.Add(this.lbContractCodeErr);
            this.panelContractCode.Controls.Add(this.borderPanelContractCode);
            this.panelContractCode.Controls.Add(this.lbContractCode);
            this.panelContractCode.Location = new System.Drawing.Point(75, 100);
            this.panelContractCode.Margin = new System.Windows.Forms.Padding(0);
            this.panelContractCode.Name = "panelContractCode";
            this.panelContractCode.Size = new System.Drawing.Size(265, 85);
            this.panelContractCode.TabIndex = 1;
            // 
            // lbContractCodeErr
            // 
            this.lbContractCodeErr.BackColor = System.Drawing.Color.Transparent;
            this.lbContractCodeErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContractCodeErr.ForeColor = System.Drawing.Color.Red;
            this.lbContractCodeErr.Location = new System.Drawing.Point(20, 55);
            this.lbContractCodeErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbContractCodeErr.Name = "lbContractCodeErr";
            this.lbContractCodeErr.Size = new System.Drawing.Size(230, 20);
            this.lbContractCodeErr.TabIndex = 0;
            // 
            // borderPanelContractCode
            // 
            this.borderPanelContractCode.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelContractCode.BorderColor = System.Drawing.Color.Black;
            this.borderPanelContractCode.BorderRadius = 10;
            this.borderPanelContractCode.BorderSize = 1;
            this.borderPanelContractCode.Controls.Add(this.textBoxContractCode);
            this.borderPanelContractCode.Location = new System.Drawing.Point(10, 25);
            this.borderPanelContractCode.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelContractCode.Name = "borderPanelContractCode";
            this.borderPanelContractCode.Size = new System.Drawing.Size(250, 30);
            this.borderPanelContractCode.TabIndex = 0;
            // 
            // textBoxContractCode
            // 
            this.textBoxContractCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContractCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContractCode.Location = new System.Drawing.Point(13, 4);
            this.textBoxContractCode.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxContractCode.Name = "textBoxContractCode";
            this.textBoxContractCode.Size = new System.Drawing.Size(225, 23);
            this.textBoxContractCode.TabIndex = 1;
            this.textBoxContractCode.Click += new System.EventHandler(this.textBoxContractCode_Event);
            this.textBoxContractCode.TextChanged += new System.EventHandler(this.textBoxContractCode_Event);
            this.textBoxContractCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContractCode_KeyPress);
            // 
            // lbContractCode
            // 
            this.lbContractCode.BackColor = System.Drawing.Color.Transparent;
            this.lbContractCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContractCode.Location = new System.Drawing.Point(10, 0);
            this.lbContractCode.Margin = new System.Windows.Forms.Padding(0);
            this.lbContractCode.Name = "lbContractCode";
            this.lbContractCode.Size = new System.Drawing.Size(200, 25);
            this.lbContractCode.TabIndex = 0;
            this.lbContractCode.Text = "Mã hợp đồng";
            this.lbContractCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDateExpire
            // 
            this.panelDateExpire.Controls.Add(this.borderPanelDateExpire);
            this.panelDateExpire.Controls.Add(this.lbDateExpire);
            this.panelDateExpire.Location = new System.Drawing.Point(620, 600);
            this.panelDateExpire.Margin = new System.Windows.Forms.Padding(0);
            this.panelDateExpire.Name = "panelDateExpire";
            this.panelDateExpire.Size = new System.Drawing.Size(400, 85);
            this.panelDateExpire.TabIndex = 10;
            // 
            // borderPanelDateExpire
            // 
            this.borderPanelDateExpire.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelDateExpire.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDateExpire.BorderRadius = 10;
            this.borderPanelDateExpire.BorderSize = 1;
            this.borderPanelDateExpire.Controls.Add(this.dateTimeExpire);
            this.borderPanelDateExpire.Location = new System.Drawing.Point(10, 25);
            this.borderPanelDateExpire.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelDateExpire.Name = "borderPanelDateExpire";
            this.borderPanelDateExpire.Size = new System.Drawing.Size(385, 30);
            this.borderPanelDateExpire.TabIndex = 0;
            // 
            // dateTimeExpire
            // 
            this.dateTimeExpire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeExpire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExpire.Location = new System.Drawing.Point(10, 4);
            this.dateTimeExpire.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeExpire.Name = "dateTimeExpire";
            this.dateTimeExpire.Size = new System.Drawing.Size(360, 22);
            this.dateTimeExpire.TabIndex = 1;
            // 
            // lbDateExpire
            // 
            this.lbDateExpire.BackColor = System.Drawing.Color.Transparent;
            this.lbDateExpire.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateExpire.Location = new System.Drawing.Point(10, 0);
            this.lbDateExpire.Margin = new System.Windows.Forms.Padding(0);
            this.lbDateExpire.Name = "lbDateExpire";
            this.lbDateExpire.Size = new System.Drawing.Size(200, 25);
            this.lbDateExpire.TabIndex = 0;
            this.lbDateExpire.Text = "Ngày kết thúc";
            this.lbDateExpire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContractName
            // 
            this.panelContractName.Controls.Add(this.lbContractNameErr);
            this.panelContractName.Controls.Add(this.borderPanelContractName);
            this.panelContractName.Controls.Add(this.lbContractName);
            this.panelContractName.Location = new System.Drawing.Point(415, 100);
            this.panelContractName.Margin = new System.Windows.Forms.Padding(0);
            this.panelContractName.Name = "panelContractName";
            this.panelContractName.Size = new System.Drawing.Size(265, 85);
            this.panelContractName.TabIndex = 2;
            // 
            // lbContractNameErr
            // 
            this.lbContractNameErr.BackColor = System.Drawing.Color.Transparent;
            this.lbContractNameErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContractNameErr.ForeColor = System.Drawing.Color.Red;
            this.lbContractNameErr.Location = new System.Drawing.Point(20, 55);
            this.lbContractNameErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbContractNameErr.Name = "lbContractNameErr";
            this.lbContractNameErr.Size = new System.Drawing.Size(230, 20);
            this.lbContractNameErr.TabIndex = 0;
            // 
            // borderPanelContractName
            // 
            this.borderPanelContractName.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelContractName.BorderColor = System.Drawing.Color.Black;
            this.borderPanelContractName.BorderRadius = 10;
            this.borderPanelContractName.BorderSize = 1;
            this.borderPanelContractName.Controls.Add(this.textBoxContractName);
            this.borderPanelContractName.Location = new System.Drawing.Point(10, 25);
            this.borderPanelContractName.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelContractName.Name = "borderPanelContractName";
            this.borderPanelContractName.Size = new System.Drawing.Size(250, 30);
            this.borderPanelContractName.TabIndex = 0;
            // 
            // textBoxContractName
            // 
            this.textBoxContractName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContractName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContractName.Location = new System.Drawing.Point(13, 4);
            this.textBoxContractName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxContractName.Name = "textBoxContractName";
            this.textBoxContractName.Size = new System.Drawing.Size(225, 23);
            this.textBoxContractName.TabIndex = 1;
            this.textBoxContractName.Click += new System.EventHandler(this.textBoxContractName_Event);
            this.textBoxContractName.TextChanged += new System.EventHandler(this.textBoxContractName_Event);
            // 
            // lbContractName
            // 
            this.lbContractName.BackColor = System.Drawing.Color.Transparent;
            this.lbContractName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContractName.Location = new System.Drawing.Point(10, 0);
            this.lbContractName.Margin = new System.Windows.Forms.Padding(0);
            this.lbContractName.Name = "lbContractName";
            this.lbContractName.Size = new System.Drawing.Size(200, 25);
            this.lbContractName.TabIndex = 0;
            this.lbContractName.Text = "Tên hợp đồng";
            this.lbContractName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelUserCode
            // 
            this.panelUserCode.Controls.Add(this.comboBoxUserCode);
            this.panelUserCode.Controls.Add(this.lbUserCodeErr);
            this.panelUserCode.Controls.Add(this.lbUserCode);
            this.panelUserCode.Location = new System.Drawing.Point(415, 520);
            this.panelUserCode.Margin = new System.Windows.Forms.Padding(0);
            this.panelUserCode.Name = "panelUserCode";
            this.panelUserCode.Size = new System.Drawing.Size(265, 85);
            this.panelUserCode.TabIndex = 7;
            // 
            // comboBoxUserCode
            // 
            this.comboBoxUserCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBoxUserCode.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxUserCode.FormattingEnabled = true;
            this.comboBoxUserCode.Location = new System.Drawing.Point(10, 25);
            this.comboBoxUserCode.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxUserCode.Name = "comboBoxUserCode";
            this.comboBoxUserCode.Size = new System.Drawing.Size(240, 31);
            this.comboBoxUserCode.TabIndex = 1;
            this.comboBoxUserCode.TextChanged += new System.EventHandler(this.comboBoxUserCode_TextChanged);
            // 
            // lbUserCodeErr
            // 
            this.lbUserCodeErr.BackColor = System.Drawing.Color.Transparent;
            this.lbUserCodeErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserCodeErr.ForeColor = System.Drawing.Color.Red;
            this.lbUserCodeErr.Location = new System.Drawing.Point(20, 55);
            this.lbUserCodeErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbUserCodeErr.Name = "lbUserCodeErr";
            this.lbUserCodeErr.Size = new System.Drawing.Size(230, 20);
            this.lbUserCodeErr.TabIndex = 0;
            // 
            // lbUserCode
            // 
            this.lbUserCode.BackColor = System.Drawing.Color.Transparent;
            this.lbUserCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserCode.Location = new System.Drawing.Point(10, 0);
            this.lbUserCode.Margin = new System.Windows.Forms.Padding(0);
            this.lbUserCode.Name = "lbUserCode";
            this.lbUserCode.Size = new System.Drawing.Size(200, 25);
            this.lbUserCode.TabIndex = 0;
            this.lbUserCode.Text = "Mã người phụ trách";
            this.lbUserCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // debounceTimer
            // 
            this.debounceTimer.Interval = 300;
            this.debounceTimer.Tick += new System.EventHandler(this.debounceTimer_Tick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.White;
            this.btnUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderSize = 1;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(865, 690);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(630, 690);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelAmount
            // 
            this.panelAmount.Controls.Add(this.borderPanelAmount);
            this.panelAmount.Controls.Add(this.lbAmount);
            this.panelAmount.Location = new System.Drawing.Point(755, 100);
            this.panelAmount.Margin = new System.Windows.Forms.Padding(0);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(265, 85);
            this.panelAmount.TabIndex = 0;
            // 
            // borderPanelAmount
            // 
            this.borderPanelAmount.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelAmount.BorderColor = System.Drawing.Color.Black;
            this.borderPanelAmount.BorderRadius = 10;
            this.borderPanelAmount.BorderSize = 1;
            this.borderPanelAmount.Controls.Add(this.textBoxAmount);
            this.borderPanelAmount.Location = new System.Drawing.Point(10, 25);
            this.borderPanelAmount.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelAmount.Name = "borderPanelAmount";
            this.borderPanelAmount.Size = new System.Drawing.Size(250, 30);
            this.borderPanelAmount.TabIndex = 0;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAmount.Enabled = false;
            this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(13, 4);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(225, 23);
            this.textBoxAmount.TabIndex = 1;
            // 
            // lbAmount
            // 
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(10, 0);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(250, 25);
            this.lbAmount.TabIndex = 0;
            this.lbAmount.Text = "Giá trị hợp đồng";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDateSign
            // 
            this.panelDateSign.Controls.Add(this.borderPanelDateSign);
            this.panelDateSign.Controls.Add(this.lbDateSign);
            this.panelDateSign.Location = new System.Drawing.Point(75, 600);
            this.panelDateSign.Margin = new System.Windows.Forms.Padding(0);
            this.panelDateSign.Name = "panelDateSign";
            this.panelDateSign.Size = new System.Drawing.Size(400, 85);
            this.panelDateSign.TabIndex = 9;
            // 
            // borderPanelDateSign
            // 
            this.borderPanelDateSign.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelDateSign.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDateSign.BorderRadius = 10;
            this.borderPanelDateSign.BorderSize = 1;
            this.borderPanelDateSign.Controls.Add(this.dateTimeSign);
            this.borderPanelDateSign.Location = new System.Drawing.Point(10, 25);
            this.borderPanelDateSign.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelDateSign.Name = "borderPanelDateSign";
            this.borderPanelDateSign.Size = new System.Drawing.Size(385, 30);
            this.borderPanelDateSign.TabIndex = 0;
            // 
            // dateTimeSign
            // 
            this.dateTimeSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeSign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSign.Location = new System.Drawing.Point(10, 4);
            this.dateTimeSign.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeSign.Name = "dateTimeSign";
            this.dateTimeSign.Size = new System.Drawing.Size(360, 22);
            this.dateTimeSign.TabIndex = 1;
            // 
            // lbDateSign
            // 
            this.lbDateSign.BackColor = System.Drawing.Color.Transparent;
            this.lbDateSign.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateSign.Location = new System.Drawing.Point(10, 0);
            this.lbDateSign.Margin = new System.Windows.Forms.Padding(0);
            this.lbDateSign.Name = "lbDateSign";
            this.lbDateSign.Size = new System.Drawing.Size(200, 25);
            this.lbDateSign.TabIndex = 0;
            this.lbDateSign.Text = "Ngày kí";
            this.lbDateSign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelCommissionPercentage
            // 
            this.panelCommissionPercentage.Controls.Add(this.lbCommissionPercentageErr);
            this.panelCommissionPercentage.Controls.Add(this.borderPanelCommissionPercentage);
            this.panelCommissionPercentage.Controls.Add(this.lbCommissionPercentage);
            this.panelCommissionPercentage.Location = new System.Drawing.Point(75, 520);
            this.panelCommissionPercentage.Margin = new System.Windows.Forms.Padding(0);
            this.panelCommissionPercentage.Name = "panelCommissionPercentage";
            this.panelCommissionPercentage.Size = new System.Drawing.Size(265, 85);
            this.panelCommissionPercentage.TabIndex = 6;
            // 
            // lbCommissionPercentageErr
            // 
            this.lbCommissionPercentageErr.BackColor = System.Drawing.Color.Transparent;
            this.lbCommissionPercentageErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommissionPercentageErr.ForeColor = System.Drawing.Color.Red;
            this.lbCommissionPercentageErr.Location = new System.Drawing.Point(20, 55);
            this.lbCommissionPercentageErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbCommissionPercentageErr.Name = "lbCommissionPercentageErr";
            this.lbCommissionPercentageErr.Size = new System.Drawing.Size(230, 20);
            this.lbCommissionPercentageErr.TabIndex = 0;
            // 
            // borderPanelCommissionPercentage
            // 
            this.borderPanelCommissionPercentage.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelCommissionPercentage.BorderColor = System.Drawing.Color.Black;
            this.borderPanelCommissionPercentage.BorderRadius = 10;
            this.borderPanelCommissionPercentage.BorderSize = 1;
            this.borderPanelCommissionPercentage.Controls.Add(this.textBoxCommissionPercentage);
            this.borderPanelCommissionPercentage.Location = new System.Drawing.Point(10, 25);
            this.borderPanelCommissionPercentage.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelCommissionPercentage.Name = "borderPanelCommissionPercentage";
            this.borderPanelCommissionPercentage.Size = new System.Drawing.Size(250, 30);
            this.borderPanelCommissionPercentage.TabIndex = 0;
            // 
            // textBoxCommissionPercentage
            // 
            this.textBoxCommissionPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCommissionPercentage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommissionPercentage.Location = new System.Drawing.Point(13, 4);
            this.textBoxCommissionPercentage.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCommissionPercentage.Name = "textBoxCommissionPercentage";
            this.textBoxCommissionPercentage.Size = new System.Drawing.Size(230, 23);
            this.textBoxCommissionPercentage.TabIndex = 1;
            this.textBoxCommissionPercentage.Click += new System.EventHandler(this.textBoxCommissionPercentage_Event);
            this.textBoxCommissionPercentage.TextChanged += new System.EventHandler(this.textBoxCommissionPercentage_Event);
            this.textBoxCommissionPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCommissionPercentage_KeyPress);
            // 
            // lbCommissionPercentage
            // 
            this.lbCommissionPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lbCommissionPercentage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommissionPercentage.Location = new System.Drawing.Point(10, 0);
            this.lbCommissionPercentage.Margin = new System.Windows.Forms.Padding(0);
            this.lbCommissionPercentage.Name = "lbCommissionPercentage";
            this.lbCommissionPercentage.Size = new System.Drawing.Size(250, 25);
            this.lbCommissionPercentage.TabIndex = 0;
            this.lbCommissionPercentage.Text = "Hoa hồng (%)";
            this.lbCommissionPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelOrganization
            // 
            this.panelOrganization.Controls.Add(this.lbOrganizationErr);
            this.panelOrganization.Controls.Add(this.borderPanelOrganization);
            this.panelOrganization.Controls.Add(this.lbOrganization);
            this.panelOrganization.Location = new System.Drawing.Point(755, 520);
            this.panelOrganization.Margin = new System.Windows.Forms.Padding(0);
            this.panelOrganization.Name = "panelOrganization";
            this.panelOrganization.Size = new System.Drawing.Size(265, 85);
            this.panelOrganization.TabIndex = 8;
            // 
            // lbOrganizationErr
            // 
            this.lbOrganizationErr.BackColor = System.Drawing.Color.Transparent;
            this.lbOrganizationErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrganizationErr.ForeColor = System.Drawing.Color.Red;
            this.lbOrganizationErr.Location = new System.Drawing.Point(20, 55);
            this.lbOrganizationErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbOrganizationErr.Name = "lbOrganizationErr";
            this.lbOrganizationErr.Size = new System.Drawing.Size(230, 20);
            this.lbOrganizationErr.TabIndex = 0;
            // 
            // borderPanelOrganization
            // 
            this.borderPanelOrganization.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelOrganization.BorderColor = System.Drawing.Color.Black;
            this.borderPanelOrganization.BorderRadius = 10;
            this.borderPanelOrganization.BorderSize = 1;
            this.borderPanelOrganization.Controls.Add(this.textBoxOrganization);
            this.borderPanelOrganization.Location = new System.Drawing.Point(10, 25);
            this.borderPanelOrganization.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelOrganization.Name = "borderPanelOrganization";
            this.borderPanelOrganization.Size = new System.Drawing.Size(250, 30);
            this.borderPanelOrganization.TabIndex = 0;
            // 
            // textBoxOrganization
            // 
            this.textBoxOrganization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOrganization.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrganization.Location = new System.Drawing.Point(13, 4);
            this.textBoxOrganization.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxOrganization.Name = "textBoxOrganization";
            this.textBoxOrganization.Size = new System.Drawing.Size(230, 23);
            this.textBoxOrganization.TabIndex = 1;
            this.textBoxOrganization.Click += new System.EventHandler(this.textBoxOrganization_Event);
            this.textBoxOrganization.TextChanged += new System.EventHandler(this.textBoxOrganization_Event);
            // 
            // lbOrganization
            // 
            this.lbOrganization.BackColor = System.Drawing.Color.Transparent;
            this.lbOrganization.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrganization.Location = new System.Drawing.Point(10, 0);
            this.lbOrganization.Margin = new System.Windows.Forms.Padding(0);
            this.lbOrganization.Name = "lbOrganization";
            this.lbOrganization.Size = new System.Drawing.Size(250, 25);
            this.lbOrganization.TabIndex = 0;
            this.lbOrganization.Text = "Tên tổ chức";
            this.lbOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContact
            // 
            this.panelContact.BackgroundColor = System.Drawing.Color.White;
            this.panelContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.panelContact.BorderRadius = 20;
            this.panelContact.BorderSize = 1;
            this.panelContact.Controls.Add(this.panelPartner);
            this.panelContact.Controls.Add(this.panelPhone);
            this.panelContact.Controls.Add(this.panelEmail);
            this.panelContact.Location = new System.Drawing.Point(750, 210);
            this.panelContact.Margin = new System.Windows.Forms.Padding(0);
            this.panelContact.Name = "panelContact";
            this.panelContact.Size = new System.Drawing.Size(280, 280);
            this.panelContact.TabIndex = 5;
            // 
            // panelPartner
            // 
            this.panelPartner.Controls.Add(this.lbPartnerErr);
            this.panelPartner.Controls.Add(this.borderPanelPartner);
            this.panelPartner.Controls.Add(this.lbPartner);
            this.panelPartner.Location = new System.Drawing.Point(10, 10);
            this.panelPartner.Margin = new System.Windows.Forms.Padding(0);
            this.panelPartner.Name = "panelPartner";
            this.panelPartner.Size = new System.Drawing.Size(265, 85);
            this.panelPartner.TabIndex = 1;
            // 
            // lbPartnerErr
            // 
            this.lbPartnerErr.BackColor = System.Drawing.Color.Transparent;
            this.lbPartnerErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPartnerErr.ForeColor = System.Drawing.Color.Red;
            this.lbPartnerErr.Location = new System.Drawing.Point(20, 55);
            this.lbPartnerErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbPartnerErr.Name = "lbPartnerErr";
            this.lbPartnerErr.Size = new System.Drawing.Size(230, 20);
            this.lbPartnerErr.TabIndex = 0;
            // 
            // borderPanelPartner
            // 
            this.borderPanelPartner.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelPartner.BorderColor = System.Drawing.Color.Black;
            this.borderPanelPartner.BorderRadius = 10;
            this.borderPanelPartner.BorderSize = 1;
            this.borderPanelPartner.Controls.Add(this.textBoxPartner);
            this.borderPanelPartner.Location = new System.Drawing.Point(10, 25);
            this.borderPanelPartner.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelPartner.Name = "borderPanelPartner";
            this.borderPanelPartner.Size = new System.Drawing.Size(250, 30);
            this.borderPanelPartner.TabIndex = 0;
            // 
            // textBoxPartner
            // 
            this.textBoxPartner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPartner.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPartner.Location = new System.Drawing.Point(13, 4);
            this.textBoxPartner.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPartner.Name = "textBoxPartner";
            this.textBoxPartner.Size = new System.Drawing.Size(225, 23);
            this.textBoxPartner.TabIndex = 1;
            this.textBoxPartner.Click += new System.EventHandler(this.textBoxPartner_Event);
            this.textBoxPartner.TextChanged += new System.EventHandler(this.textBoxPartner_Event);
            // 
            // lbPartner
            // 
            this.lbPartner.BackColor = System.Drawing.Color.Transparent;
            this.lbPartner.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPartner.Location = new System.Drawing.Point(10, 0);
            this.lbPartner.Margin = new System.Windows.Forms.Padding(0);
            this.lbPartner.Name = "lbPartner";
            this.lbPartner.Size = new System.Drawing.Size(250, 25);
            this.lbPartner.TabIndex = 0;
            this.lbPartner.Text = "Tên đối tác";
            this.lbPartner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelPhone
            // 
            this.panelPhone.Controls.Add(this.lbPhoneErr);
            this.panelPhone.Controls.Add(this.borderPanelPhone);
            this.panelPhone.Controls.Add(this.lbPhone);
            this.panelPhone.Location = new System.Drawing.Point(10, 180);
            this.panelPhone.Margin = new System.Windows.Forms.Padding(0);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(265, 85);
            this.panelPhone.TabIndex = 3;
            // 
            // lbPhoneErr
            // 
            this.lbPhoneErr.BackColor = System.Drawing.Color.Transparent;
            this.lbPhoneErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneErr.ForeColor = System.Drawing.Color.Red;
            this.lbPhoneErr.Location = new System.Drawing.Point(20, 55);
            this.lbPhoneErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbPhoneErr.Name = "lbPhoneErr";
            this.lbPhoneErr.Size = new System.Drawing.Size(230, 20);
            this.lbPhoneErr.TabIndex = 0;
            // 
            // borderPanelPhone
            // 
            this.borderPanelPhone.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelPhone.BorderColor = System.Drawing.Color.Black;
            this.borderPanelPhone.BorderRadius = 10;
            this.borderPanelPhone.BorderSize = 1;
            this.borderPanelPhone.Controls.Add(this.textBoxPhone);
            this.borderPanelPhone.Location = new System.Drawing.Point(10, 25);
            this.borderPanelPhone.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelPhone.Name = "borderPanelPhone";
            this.borderPanelPhone.Size = new System.Drawing.Size(250, 30);
            this.borderPanelPhone.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(13, 4);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(225, 23);
            this.textBoxPhone.TabIndex = 1;
            this.textBoxPhone.Click += new System.EventHandler(this.textBoxPhone_Event);
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_Event);
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // lbPhone
            // 
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(10, 0);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(250, 25);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.Text = "Số điện thoại liên hệ";
            this.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.lbEmailErr);
            this.panelEmail.Controls.Add(this.borderPanelEmail);
            this.panelEmail.Controls.Add(this.lbEmail);
            this.panelEmail.Location = new System.Drawing.Point(10, 95);
            this.panelEmail.Margin = new System.Windows.Forms.Padding(0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(265, 85);
            this.panelEmail.TabIndex = 2;
            // 
            // lbEmailErr
            // 
            this.lbEmailErr.BackColor = System.Drawing.Color.Transparent;
            this.lbEmailErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailErr.ForeColor = System.Drawing.Color.Red;
            this.lbEmailErr.Location = new System.Drawing.Point(20, 55);
            this.lbEmailErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmailErr.Name = "lbEmailErr";
            this.lbEmailErr.Size = new System.Drawing.Size(230, 20);
            this.lbEmailErr.TabIndex = 0;
            // 
            // borderPanelEmail
            // 
            this.borderPanelEmail.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelEmail.BorderColor = System.Drawing.Color.Black;
            this.borderPanelEmail.BorderRadius = 10;
            this.borderPanelEmail.BorderSize = 1;
            this.borderPanelEmail.Controls.Add(this.textBoxEmail);
            this.borderPanelEmail.Location = new System.Drawing.Point(10, 25);
            this.borderPanelEmail.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelEmail.Name = "borderPanelEmail";
            this.borderPanelEmail.Size = new System.Drawing.Size(250, 30);
            this.borderPanelEmail.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(13, 4);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(225, 23);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.Click += new System.EventHandler(this.textBoxEmail_Event);
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_Event);
            // 
            // lbEmail
            // 
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(10, 0);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(250, 25);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email liên hệ";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbContact
            // 
            this.lbContact.BackColor = System.Drawing.Color.Transparent;
            this.lbContact.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(765, 180);
            this.lbContact.Margin = new System.Windows.Forms.Padding(0);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(250, 25);
            this.lbContact.TabIndex = 0;
            this.lbContact.Text = "Thông tin liên hệ";
            this.lbContact.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // UpdateContractGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.lbContact);
            this.Controls.Add(this.panelContact);
            this.Controls.Add(this.panelOrganization);
            this.Controls.Add(this.panelCommissionPercentage);
            this.Controls.Add(this.panelAmount);
            this.Controls.Add(this.panelDateSign);
            this.Controls.Add(this.panelUserCode);
            this.Controls.Add(this.panelContractName);
            this.Controls.Add(this.panelDateExpire);
            this.Controls.Add(this.panelContractCode);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateContractGUI";
            this.Text = "UpdateContractForm";
            this.panelContent.ResumeLayout(false);
            this.borderPanelContent.ResumeLayout(false);
            this.borderPanelContent.PerformLayout();
            this.panelContractCode.ResumeLayout(false);
            this.borderPanelContractCode.ResumeLayout(false);
            this.borderPanelContractCode.PerformLayout();
            this.panelDateExpire.ResumeLayout(false);
            this.borderPanelDateExpire.ResumeLayout(false);
            this.panelContractName.ResumeLayout(false);
            this.borderPanelContractName.ResumeLayout(false);
            this.borderPanelContractName.PerformLayout();
            this.panelUserCode.ResumeLayout(false);
            this.panelAmount.ResumeLayout(false);
            this.borderPanelAmount.ResumeLayout(false);
            this.borderPanelAmount.PerformLayout();
            this.panelDateSign.ResumeLayout(false);
            this.borderPanelDateSign.ResumeLayout(false);
            this.panelCommissionPercentage.ResumeLayout(false);
            this.borderPanelCommissionPercentage.ResumeLayout(false);
            this.borderPanelCommissionPercentage.PerformLayout();
            this.panelOrganization.ResumeLayout(false);
            this.borderPanelOrganization.ResumeLayout(false);
            this.borderPanelOrganization.PerformLayout();
            this.panelContact.ResumeLayout(false);
            this.panelPartner.ResumeLayout(false);
            this.borderPanelPartner.ResumeLayout(false);
            this.borderPanelPartner.PerformLayout();
            this.panelPhone.ResumeLayout(false);
            this.borderPanelPhone.ResumeLayout(false);
            this.borderPanelPhone.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.borderPanelEmail.ResumeLayout(false);
            this.borderPanelEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel borderPanelContent;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbTitle;
        private CNPM_FINAL.GUI.CustomControl.BorderButton btnCancel;
        private CNPM_FINAL.GUI.CustomControl.BorderButton btnUpdate;
        private System.Windows.Forms.Panel panelContractCode;
        private System.Windows.Forms.Label lbContractCodeErr;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel borderPanelContractCode;
        private System.Windows.Forms.TextBox textBoxContractCode;
        private System.Windows.Forms.Label lbContractCode;
        private System.Windows.Forms.Panel panelDateExpire;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel borderPanelDateExpire;
        private System.Windows.Forms.DateTimePicker dateTimeExpire;
        private System.Windows.Forms.Label lbDateExpire;
        private System.Windows.Forms.Label lbContentErr;
        private System.Windows.Forms.Panel panelContractName;
        private System.Windows.Forms.Label lbContractNameErr;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel borderPanelContractName;
        private System.Windows.Forms.TextBox textBoxContractName;
        private System.Windows.Forms.Label lbContractName;
        private Panel panelUserCode;
        private Label lbUserCodeErr;
        private Label lbUserCode;
        private ComboBox comboBoxUserCode;
        private Timer debounceTimer;
        private Panel panelAmount;
        private CustomControl.BorderPanel borderPanelAmount;
        private TextBox textBoxAmount;
        private Label lbAmount;
        private Panel panelDateSign;
        private CustomControl.BorderPanel borderPanelDateSign;
        private DateTimePicker dateTimeSign;
        private Label lbDateSign;
        private Panel panelCommissionPercentage;
        private Label lbCommissionPercentageErr;
        private CustomControl.BorderPanel borderPanelCommissionPercentage;
        private TextBox textBoxCommissionPercentage;
        private Label lbCommissionPercentage;
        private Panel panelOrganization;
        private Label lbOrganizationErr;
        private CustomControl.BorderPanel borderPanelOrganization;
        private TextBox textBoxOrganization;
        private Label lbOrganization;
        private CustomControl.BorderPanel panelContact;
        private Label lbContact;
        private Panel panelPartner;
        private Label lbPartnerErr;
        private CustomControl.BorderPanel borderPanelPartner;
        private TextBox textBoxPartner;
        private Label lbPartner;
        private Panel panelPhone;
        private Label lbPhoneErr;
        private CustomControl.BorderPanel borderPanelPhone;
        private TextBox textBoxPhone;
        private Label lbPhone;
        private Panel panelEmail;
        private Label lbEmailErr;
        private CustomControl.BorderPanel borderPanelEmail;
        private TextBox textBoxEmail;
        private Label lbEmail;
    }
}