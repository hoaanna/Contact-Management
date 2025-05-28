namespace CNPM_FINAL.GUI.SubItem.Payment
{
    partial class CreatePaymentGUI
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelStageName = new System.Windows.Forms.Panel();
            this.lbStageNameErr = new System.Windows.Forms.Label();
            this.borderPanelStageName = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxStageName = new System.Windows.Forms.TextBox();
            this.lbStageName = new System.Windows.Forms.Label();
            this.panelContractCode = new System.Windows.Forms.Panel();
            this.comboBoxContractCode = new System.Windows.Forms.ComboBox();
            this.lbContractCodeErr = new System.Windows.Forms.Label();
            this.lbContractCode = new System.Windows.Forms.Label();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.lbDescriptionErr = new System.Windows.Forms.Label();
            this.borderPanelDescription = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.lbAmountErr = new System.Windows.Forms.Label();
            this.borderPanelAmount = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.panelPaymentDate = new System.Windows.Forms.Panel();
            this.lbPaymentDateErr = new System.Windows.Forms.Label();
            this.borderPanelPaymentDate = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbPaymentDate = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnCreate = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.btnCancel = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.debounceTimer = new System.Windows.Forms.Timer(this.components);
            this.panelStageName.SuspendLayout();
            this.borderPanelStageName.SuspendLayout();
            this.panelContractCode.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.borderPanelDescription.SuspendLayout();
            this.panelAmount.SuspendLayout();
            this.borderPanelAmount.SuspendLayout();
            this.panelPaymentDate.SuspendLayout();
            this.borderPanelPaymentDate.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
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
            this.lbTitle.Text = "Thêm mới giai đoạn thanh toán";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStageName
            // 
            this.panelStageName.Controls.Add(this.lbStageNameErr);
            this.panelStageName.Controls.Add(this.borderPanelStageName);
            this.panelStageName.Controls.Add(this.lbStageName);
            this.panelStageName.Location = new System.Drawing.Point(620, 100);
            this.panelStageName.Margin = new System.Windows.Forms.Padding(0);
            this.panelStageName.Name = "panelStageName";
            this.panelStageName.Size = new System.Drawing.Size(400, 85);
            this.panelStageName.TabIndex = 2;
            // 
            // lbStageNameErr
            // 
            this.lbStageNameErr.BackColor = System.Drawing.Color.Transparent;
            this.lbStageNameErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStageNameErr.ForeColor = System.Drawing.Color.Red;
            this.lbStageNameErr.Location = new System.Drawing.Point(20, 55);
            this.lbStageNameErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbStageNameErr.Name = "lbStageNameErr";
            this.lbStageNameErr.Size = new System.Drawing.Size(350, 20);
            this.lbStageNameErr.TabIndex = 0;
            // 
            // borderPanelStageName
            // 
            this.borderPanelStageName.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelStageName.BorderColor = System.Drawing.Color.Black;
            this.borderPanelStageName.BorderRadius = 10;
            this.borderPanelStageName.BorderSize = 1;
            this.borderPanelStageName.Controls.Add(this.textBoxStageName);
            this.borderPanelStageName.Location = new System.Drawing.Point(10, 25);
            this.borderPanelStageName.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelStageName.Name = "borderPanelStageName";
            this.borderPanelStageName.Size = new System.Drawing.Size(380, 30);
            this.borderPanelStageName.TabIndex = 0;
            // 
            // textBoxStageName
            // 
            this.textBoxStageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStageName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStageName.Location = new System.Drawing.Point(13, 4);
            this.textBoxStageName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxStageName.Name = "textBoxStageName";
            this.textBoxStageName.Size = new System.Drawing.Size(350, 23);
            this.textBoxStageName.TabIndex = 1;
            this.textBoxStageName.Click += new System.EventHandler(this.textBoxStageName_Event);
            this.textBoxStageName.TextChanged += new System.EventHandler(this.textBoxStageName_Event);
            // 
            // lbStageName
            // 
            this.lbStageName.BackColor = System.Drawing.Color.Transparent;
            this.lbStageName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStageName.Location = new System.Drawing.Point(10, 0);
            this.lbStageName.Margin = new System.Windows.Forms.Padding(0);
            this.lbStageName.Name = "lbStageName";
            this.lbStageName.Size = new System.Drawing.Size(200, 25);
            this.lbStageName.TabIndex = 0;
            this.lbStageName.Text = "Tên giai đoạn";
            this.lbStageName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContractCode
            // 
            this.panelContractCode.Controls.Add(this.comboBoxContractCode);
            this.panelContractCode.Controls.Add(this.lbContractCodeErr);
            this.panelContractCode.Controls.Add(this.lbContractCode);
            this.panelContractCode.Location = new System.Drawing.Point(75, 100);
            this.panelContractCode.Margin = new System.Windows.Forms.Padding(0);
            this.panelContractCode.Name = "panelContractCode";
            this.panelContractCode.Size = new System.Drawing.Size(400, 85);
            this.panelContractCode.TabIndex = 1;
            // 
            // comboBoxContractCode
            // 
            this.comboBoxContractCode.BackColor = System.Drawing.Color.White;
            this.comboBoxContractCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBoxContractCode.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxContractCode.FormattingEnabled = true;
            this.comboBoxContractCode.Location = new System.Drawing.Point(10, 25);
            this.comboBoxContractCode.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxContractCode.Name = "comboBoxContractCode";
            this.comboBoxContractCode.Size = new System.Drawing.Size(375, 31);
            this.comboBoxContractCode.TabIndex = 2;
            this.comboBoxContractCode.TextChanged += new System.EventHandler(this.comboBoxContractCode_TextChanged);
            // 
            // lbContractCodeErr
            // 
            this.lbContractCodeErr.BackColor = System.Drawing.Color.Transparent;
            this.lbContractCodeErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContractCodeErr.ForeColor = System.Drawing.Color.Red;
            this.lbContractCodeErr.Location = new System.Drawing.Point(20, 55);
            this.lbContractCodeErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbContractCodeErr.Name = "lbContractCodeErr";
            this.lbContractCodeErr.Size = new System.Drawing.Size(370, 20);
            this.lbContractCodeErr.TabIndex = 0;
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
            // panelDescription
            // 
            this.panelDescription.Controls.Add(this.lbDescriptionErr);
            this.panelDescription.Controls.Add(this.borderPanelDescription);
            this.panelDescription.Controls.Add(this.lbDescription);
            this.panelDescription.Location = new System.Drawing.Point(75, 200);
            this.panelDescription.Margin = new System.Windows.Forms.Padding(0);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(945, 190);
            this.panelDescription.TabIndex = 3;
            // 
            // lbDescriptionErr
            // 
            this.lbDescriptionErr.BackColor = System.Drawing.Color.Transparent;
            this.lbDescriptionErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptionErr.ForeColor = System.Drawing.Color.Red;
            this.lbDescriptionErr.Location = new System.Drawing.Point(20, 170);
            this.lbDescriptionErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbDescriptionErr.Name = "lbDescriptionErr";
            this.lbDescriptionErr.Size = new System.Drawing.Size(650, 20);
            this.lbDescriptionErr.TabIndex = 0;
            // 
            // borderPanelDescription
            // 
            this.borderPanelDescription.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelDescription.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDescription.BorderRadius = 10;
            this.borderPanelDescription.BorderSize = 1;
            this.borderPanelDescription.Controls.Add(this.textBoxDescription);
            this.borderPanelDescription.Location = new System.Drawing.Point(10, 30);
            this.borderPanelDescription.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelDescription.Name = "borderPanelDescription";
            this.borderPanelDescription.Size = new System.Drawing.Size(930, 140);
            this.borderPanelDescription.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(10, 10);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(910, 120);
            this.textBoxDescription.TabIndex = 1;
            this.textBoxDescription.Click += new System.EventHandler(this.textBoxDescription_Event);
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_Event);
            // 
            // lbDescription
            // 
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(10, 0);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(200, 25);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Mô tả giai đoạn";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAmount
            // 
            this.panelAmount.Controls.Add(this.lbAmountErr);
            this.panelAmount.Controls.Add(this.borderPanelAmount);
            this.panelAmount.Controls.Add(this.lbAmount);
            this.panelAmount.Location = new System.Drawing.Point(620, 400);
            this.panelAmount.Margin = new System.Windows.Forms.Padding(0);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(400, 85);
            this.panelAmount.TabIndex = 5;
            // 
            // lbAmountErr
            // 
            this.lbAmountErr.BackColor = System.Drawing.Color.Transparent;
            this.lbAmountErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountErr.ForeColor = System.Drawing.Color.Red;
            this.lbAmountErr.Location = new System.Drawing.Point(20, 55);
            this.lbAmountErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbAmountErr.Name = "lbAmountErr";
            this.lbAmountErr.Size = new System.Drawing.Size(370, 20);
            this.lbAmountErr.TabIndex = 0;
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
            this.borderPanelAmount.Size = new System.Drawing.Size(385, 30);
            this.borderPanelAmount.TabIndex = 0;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(13, 4);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(360, 23);
            this.textBoxAmount.TabIndex = 1;
            this.textBoxAmount.Click += new System.EventHandler(this.textBoxAmount_Click);
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            // 
            // lbAmount
            // 
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(10, 0);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(200, 25);
            this.lbAmount.TabIndex = 0;
            this.lbAmount.Text = "Số tiền thanh toán";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelPaymentDate
            // 
            this.panelPaymentDate.Controls.Add(this.lbPaymentDateErr);
            this.panelPaymentDate.Controls.Add(this.borderPanelPaymentDate);
            this.panelPaymentDate.Controls.Add(this.lbPaymentDate);
            this.panelPaymentDate.Location = new System.Drawing.Point(75, 400);
            this.panelPaymentDate.Margin = new System.Windows.Forms.Padding(0);
            this.panelPaymentDate.Name = "panelPaymentDate";
            this.panelPaymentDate.Size = new System.Drawing.Size(400, 85);
            this.panelPaymentDate.TabIndex = 4;
            // 
            // lbPaymentDateErr
            // 
            this.lbPaymentDateErr.BackColor = System.Drawing.Color.Transparent;
            this.lbPaymentDateErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentDateErr.ForeColor = System.Drawing.Color.Red;
            this.lbPaymentDateErr.Location = new System.Drawing.Point(20, 55);
            this.lbPaymentDateErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbPaymentDateErr.Name = "lbPaymentDateErr";
            this.lbPaymentDateErr.Size = new System.Drawing.Size(370, 20);
            this.lbPaymentDateErr.TabIndex = 0;
            // 
            // borderPanelPaymentDate
            // 
            this.borderPanelPaymentDate.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelPaymentDate.BorderColor = System.Drawing.Color.Black;
            this.borderPanelPaymentDate.BorderRadius = 10;
            this.borderPanelPaymentDate.BorderSize = 1;
            this.borderPanelPaymentDate.Controls.Add(this.dateTimePicker);
            this.borderPanelPaymentDate.Location = new System.Drawing.Point(10, 25);
            this.borderPanelPaymentDate.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelPaymentDate.Name = "borderPanelPaymentDate";
            this.borderPanelPaymentDate.Size = new System.Drawing.Size(385, 30);
            this.borderPanelPaymentDate.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(10, 4);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker.Size = new System.Drawing.Size(360, 22);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2024, 11, 17, 0, 0, 0, 0);
            this.dateTimePicker.CloseUp += new System.EventHandler(this.dateTime_Event);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTime_Event);
            // 
            // lbPaymentDate
            // 
            this.lbPaymentDate.BackColor = System.Drawing.Color.Transparent;
            this.lbPaymentDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentDate.Location = new System.Drawing.Point(10, 0);
            this.lbPaymentDate.Margin = new System.Windows.Forms.Padding(0);
            this.lbPaymentDate.Name = "lbPaymentDate";
            this.lbPaymentDate.Size = new System.Drawing.Size(200, 25);
            this.lbPaymentDate.TabIndex = 0;
            this.lbPaymentDate.Text = "Ngày thanh toán";
            this.lbPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.comboBoxStatus);
            this.panelStatus.Controls.Add(this.lbStatus);
            this.panelStatus.Location = new System.Drawing.Point(75, 500);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(400, 85);
            this.panelStatus.TabIndex = 6;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.White;
            this.comboBoxStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(15, 25);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(375, 31);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(10, 0);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(200, 25);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Trạng thái thanh toán";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnCreate.BackgroundColor = System.Drawing.Color.White;
            this.btnCreate.BorderColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.BorderSize = 1;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(890, 650);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 40);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Thêm";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(720, 650);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // debounceTimer
            // 
            this.debounceTimer.Interval = 400;
            this.debounceTimer.Tick += new System.EventHandler(this.DebounceTimer_Tick);
            // 
            // CreatePaymentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.ControlBox = false;
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelPaymentDate);
            this.Controls.Add(this.panelAmount);
            this.Controls.Add(this.panelStageName);
            this.Controls.Add(this.panelContractCode);
            this.Controls.Add(this.panelDescription);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreatePaymentGUI";
            this.Text = "CreatePaymentGUI";
            this.panelStageName.ResumeLayout(false);
            this.borderPanelStageName.ResumeLayout(false);
            this.borderPanelStageName.PerformLayout();
            this.panelContractCode.ResumeLayout(false);
            this.panelDescription.ResumeLayout(false);
            this.borderPanelDescription.ResumeLayout(false);
            this.borderPanelDescription.PerformLayout();
            this.panelAmount.ResumeLayout(false);
            this.borderPanelAmount.ResumeLayout(false);
            this.borderPanelAmount.PerformLayout();
            this.panelPaymentDate.ResumeLayout(false);
            this.borderPanelPaymentDate.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelStageName;
        private System.Windows.Forms.Label lbStageNameErr;
        private CustomControl.BorderPanel borderPanelStageName;
        private System.Windows.Forms.TextBox textBoxStageName;
        private System.Windows.Forms.Label lbStageName;
        private System.Windows.Forms.Panel panelContractCode;
        private System.Windows.Forms.Label lbContractCodeErr;
        private System.Windows.Forms.Label lbContractCode;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Label lbDescriptionErr;
        private CustomControl.BorderPanel borderPanelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.Label lbAmountErr;
        private CustomControl.BorderPanel borderPanelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Panel panelPaymentDate;
        private System.Windows.Forms.Label lbPaymentDateErr;
        private CustomControl.BorderPanel borderPanelPaymentDate;
        private System.Windows.Forms.Label lbPaymentDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private CustomControl.BorderButton btnCreate;
        private CustomControl.BorderButton btnCancel;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox comboBoxContractCode;
        private System.Windows.Forms.Timer debounceTimer;
    }
}