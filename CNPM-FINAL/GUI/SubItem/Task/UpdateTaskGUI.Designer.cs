namespace CNPM_FINAL.GUI.SubItem.Task
{
    partial class UpdateTaskGUI
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
            this.panelTaskName = new System.Windows.Forms.Panel();
            this.lbTaskNameErr = new System.Windows.Forms.Label();
            this.borderPanelTaskName = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.lbTaskName = new System.Windows.Forms.Label();
            this.panelDateFinish = new System.Windows.Forms.Panel();
            this.lbDateFinishErr = new System.Windows.Forms.Label();
            this.borderPanelDateFinish = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimeFinish = new System.Windows.Forms.DateTimePicker();
            this.lbDateFinish = new System.Windows.Forms.Label();
            this.panelDateStart = new System.Windows.Forms.Panel();
            this.borderPanelDateStart = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.lbDateStart = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panelContract = new System.Windows.Forms.Panel();
            this.comboBoxContractCode = new System.Windows.Forms.ComboBox();
            this.lbContractErr = new System.Windows.Forms.Label();
            this.lbContract = new System.Windows.Forms.Label();
            this.panelSaleCode = new System.Windows.Forms.Panel();
            this.comboBoxUserCode = new System.Windows.Forms.ComboBox();
            this.lbSaleCodeErr = new System.Windows.Forms.Label();
            this.lbSaleCode = new System.Windows.Forms.Label();
            this.btnUpdate = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.btnCancel = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.debounceUserTimer = new System.Windows.Forms.Timer(this.components);
            this.debounceContractTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTaskName.SuspendLayout();
            this.borderPanelTaskName.SuspendLayout();
            this.panelDateFinish.SuspendLayout();
            this.borderPanelDateFinish.SuspendLayout();
            this.panelDateStart.SuspendLayout();
            this.borderPanelDateStart.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelContract.SuspendLayout();
            this.panelSaleCode.SuspendLayout();
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
            this.lbTitle.Text = "Cập nhật tiến độ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTaskName
            // 
            this.panelTaskName.Controls.Add(this.lbTaskNameErr);
            this.panelTaskName.Controls.Add(this.borderPanelTaskName);
            this.panelTaskName.Controls.Add(this.lbTaskName);
            this.panelTaskName.Location = new System.Drawing.Point(75, 230);
            this.panelTaskName.Margin = new System.Windows.Forms.Padding(0);
            this.panelTaskName.Name = "panelTaskName";
            this.panelTaskName.Size = new System.Drawing.Size(945, 85);
            this.panelTaskName.TabIndex = 3;
            // 
            // lbTaskNameErr
            // 
            this.lbTaskNameErr.BackColor = System.Drawing.Color.Transparent;
            this.lbTaskNameErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaskNameErr.ForeColor = System.Drawing.Color.Red;
            this.lbTaskNameErr.Location = new System.Drawing.Point(20, 55);
            this.lbTaskNameErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbTaskNameErr.Name = "lbTaskNameErr";
            this.lbTaskNameErr.Size = new System.Drawing.Size(450, 20);
            this.lbTaskNameErr.TabIndex = 0;
            // 
            // borderPanelTaskName
            // 
            this.borderPanelTaskName.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelTaskName.BorderColor = System.Drawing.Color.Black;
            this.borderPanelTaskName.BorderRadius = 10;
            this.borderPanelTaskName.BorderSize = 1;
            this.borderPanelTaskName.Controls.Add(this.textBoxTaskName);
            this.borderPanelTaskName.Location = new System.Drawing.Point(10, 25);
            this.borderPanelTaskName.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelTaskName.Name = "borderPanelTaskName";
            this.borderPanelTaskName.Size = new System.Drawing.Size(930, 30);
            this.borderPanelTaskName.TabIndex = 0;
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTaskName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaskName.Location = new System.Drawing.Point(13, 4);
            this.textBoxTaskName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(905, 23);
            this.textBoxTaskName.TabIndex = 1;
            this.textBoxTaskName.Click += new System.EventHandler(this.textBoxTask_Click);
            this.textBoxTaskName.TextChanged += new System.EventHandler(this.textBoxTask_TextChanged);
            // 
            // lbTaskName
            // 
            this.lbTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lbTaskName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaskName.Location = new System.Drawing.Point(10, 0);
            this.lbTaskName.Margin = new System.Windows.Forms.Padding(0);
            this.lbTaskName.Name = "lbTaskName";
            this.lbTaskName.Size = new System.Drawing.Size(200, 25);
            this.lbTaskName.TabIndex = 0;
            this.lbTaskName.Text = "Tên công việc";
            this.lbTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDateFinish
            // 
            this.panelDateFinish.Controls.Add(this.lbDateFinishErr);
            this.panelDateFinish.Controls.Add(this.borderPanelDateFinish);
            this.panelDateFinish.Controls.Add(this.lbDateFinish);
            this.panelDateFinish.Location = new System.Drawing.Point(620, 360);
            this.panelDateFinish.Margin = new System.Windows.Forms.Padding(0);
            this.panelDateFinish.Name = "panelDateFinish";
            this.panelDateFinish.Size = new System.Drawing.Size(450, 85);
            this.panelDateFinish.TabIndex = 5;
            // 
            // lbDateFinishErr
            // 
            this.lbDateFinishErr.BackColor = System.Drawing.Color.Transparent;
            this.lbDateFinishErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateFinishErr.ForeColor = System.Drawing.Color.Red;
            this.lbDateFinishErr.Location = new System.Drawing.Point(20, 55);
            this.lbDateFinishErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbDateFinishErr.Name = "lbDateFinishErr";
            this.lbDateFinishErr.Size = new System.Drawing.Size(430, 20);
            this.lbDateFinishErr.TabIndex = 0;
            // 
            // borderPanelDateFinish
            // 
            this.borderPanelDateFinish.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelDateFinish.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDateFinish.BorderRadius = 10;
            this.borderPanelDateFinish.BorderSize = 1;
            this.borderPanelDateFinish.Controls.Add(this.dateTimeFinish);
            this.borderPanelDateFinish.Location = new System.Drawing.Point(10, 25);
            this.borderPanelDateFinish.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelDateFinish.Name = "borderPanelDateFinish";
            this.borderPanelDateFinish.Size = new System.Drawing.Size(385, 30);
            this.borderPanelDateFinish.TabIndex = 0;
            // 
            // dateTimeFinish
            // 
            this.dateTimeFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFinish.Location = new System.Drawing.Point(10, 4);
            this.dateTimeFinish.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeFinish.Name = "dateTimeFinish";
            this.dateTimeFinish.Size = new System.Drawing.Size(360, 22);
            this.dateTimeFinish.TabIndex = 1;
            this.dateTimeFinish.CloseUp += new System.EventHandler(this.dateTimeFinish_Event);
            this.dateTimeFinish.ValueChanged += new System.EventHandler(this.dateTimeFinish_Event);
            // 
            // lbDateFinish
            // 
            this.lbDateFinish.BackColor = System.Drawing.Color.Transparent;
            this.lbDateFinish.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateFinish.Location = new System.Drawing.Point(10, 0);
            this.lbDateFinish.Margin = new System.Windows.Forms.Padding(0);
            this.lbDateFinish.Name = "lbDateFinish";
            this.lbDateFinish.Size = new System.Drawing.Size(200, 25);
            this.lbDateFinish.TabIndex = 0;
            this.lbDateFinish.Text = "Ngày kết thúc";
            this.lbDateFinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDateStart
            // 
            this.panelDateStart.Controls.Add(this.borderPanelDateStart);
            this.panelDateStart.Controls.Add(this.lbDateStart);
            this.panelDateStart.Location = new System.Drawing.Point(75, 360);
            this.panelDateStart.Margin = new System.Windows.Forms.Padding(0);
            this.panelDateStart.Name = "panelDateStart";
            this.panelDateStart.Size = new System.Drawing.Size(400, 85);
            this.panelDateStart.TabIndex = 4;
            // 
            // borderPanelDateStart
            // 
            this.borderPanelDateStart.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelDateStart.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDateStart.BorderRadius = 10;
            this.borderPanelDateStart.BorderSize = 1;
            this.borderPanelDateStart.Controls.Add(this.dateTimeStart);
            this.borderPanelDateStart.Location = new System.Drawing.Point(10, 25);
            this.borderPanelDateStart.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelDateStart.Name = "borderPanelDateStart";
            this.borderPanelDateStart.Size = new System.Drawing.Size(385, 30);
            this.borderPanelDateStart.TabIndex = 0;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStart.Location = new System.Drawing.Point(10, 4);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(360, 22);
            this.dateTimeStart.TabIndex = 1;
            this.dateTimeStart.CloseUp += new System.EventHandler(this.dateTimeStart_Event);
            this.dateTimeStart.ValueChanged += new System.EventHandler(this.dateTimeStart_Event);
            // 
            // lbDateStart
            // 
            this.lbDateStart.BackColor = System.Drawing.Color.Transparent;
            this.lbDateStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateStart.Location = new System.Drawing.Point(10, 0);
            this.lbDateStart.Margin = new System.Windows.Forms.Padding(0);
            this.lbDateStart.Name = "lbDateStart";
            this.lbDateStart.Size = new System.Drawing.Size(200, 25);
            this.lbDateStart.TabIndex = 0;
            this.lbDateStart.Text = "Ngày bắt đầu";
            this.lbDateStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.comboBoxStatus);
            this.panelStatus.Controls.Add(this.lbStatus);
            this.panelStatus.Location = new System.Drawing.Point(75, 490);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(400, 85);
            this.panelStatus.TabIndex = 6;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(10, 25);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(370, 31);
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
            this.lbStatus.Text = "Trạng thái công việc";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContract
            // 
            this.panelContract.Controls.Add(this.comboBoxContractCode);
            this.panelContract.Controls.Add(this.lbContractErr);
            this.panelContract.Controls.Add(this.lbContract);
            this.panelContract.Location = new System.Drawing.Point(75, 100);
            this.panelContract.Margin = new System.Windows.Forms.Padding(0);
            this.panelContract.Name = "panelContract";
            this.panelContract.Size = new System.Drawing.Size(400, 85);
            this.panelContract.TabIndex = 1;
            // 
            // comboBoxContractCode
            // 
            this.comboBoxContractCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxContractCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContractCode.FormattingEnabled = true;
            this.comboBoxContractCode.Location = new System.Drawing.Point(10, 25);
            this.comboBoxContractCode.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxContractCode.Name = "comboBoxContractCode";
            this.comboBoxContractCode.Size = new System.Drawing.Size(370, 31);
            this.comboBoxContractCode.TabIndex = 2;
            this.comboBoxContractCode.TextChanged += new System.EventHandler(this.comboBoxContractCode_TextChanged);
            // 
            // lbContractErr
            // 
            this.lbContractErr.BackColor = System.Drawing.Color.Transparent;
            this.lbContractErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContractErr.ForeColor = System.Drawing.Color.Red;
            this.lbContractErr.Location = new System.Drawing.Point(20, 55);
            this.lbContractErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbContractErr.Name = "lbContractErr";
            this.lbContractErr.Size = new System.Drawing.Size(370, 20);
            this.lbContractErr.TabIndex = 0;
            // 
            // lbContract
            // 
            this.lbContract.BackColor = System.Drawing.Color.Transparent;
            this.lbContract.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContract.Location = new System.Drawing.Point(10, 0);
            this.lbContract.Margin = new System.Windows.Forms.Padding(0);
            this.lbContract.Name = "lbContract";
            this.lbContract.Size = new System.Drawing.Size(200, 25);
            this.lbContract.TabIndex = 0;
            this.lbContract.Text = "Mã hợp đồng";
            this.lbContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSaleCode
            // 
            this.panelSaleCode.Controls.Add(this.comboBoxUserCode);
            this.panelSaleCode.Controls.Add(this.lbSaleCodeErr);
            this.panelSaleCode.Controls.Add(this.lbSaleCode);
            this.panelSaleCode.Location = new System.Drawing.Point(620, 100);
            this.panelSaleCode.Margin = new System.Windows.Forms.Padding(0);
            this.panelSaleCode.Name = "panelSaleCode";
            this.panelSaleCode.Size = new System.Drawing.Size(400, 85);
            this.panelSaleCode.TabIndex = 2;
            // 
            // comboBoxUserCode
            // 
            this.comboBoxUserCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxUserCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserCode.FormattingEnabled = true;
            this.comboBoxUserCode.Location = new System.Drawing.Point(10, 25);
            this.comboBoxUserCode.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxUserCode.Name = "comboBoxUserCode";
            this.comboBoxUserCode.Size = new System.Drawing.Size(380, 31);
            this.comboBoxUserCode.TabIndex = 2;
            this.comboBoxUserCode.TextChanged += new System.EventHandler(this.comboBoxUserCode_TextChanged);
            // 
            // lbSaleCodeErr
            // 
            this.lbSaleCodeErr.BackColor = System.Drawing.Color.Transparent;
            this.lbSaleCodeErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaleCodeErr.ForeColor = System.Drawing.Color.Red;
            this.lbSaleCodeErr.Location = new System.Drawing.Point(20, 55);
            this.lbSaleCodeErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbSaleCodeErr.Name = "lbSaleCodeErr";
            this.lbSaleCodeErr.Size = new System.Drawing.Size(370, 20);
            this.lbSaleCodeErr.TabIndex = 0;
            // 
            // lbSaleCode
            // 
            this.lbSaleCode.BackColor = System.Drawing.Color.Transparent;
            this.lbSaleCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaleCode.Location = new System.Drawing.Point(10, 0);
            this.lbSaleCode.Margin = new System.Windows.Forms.Padding(0);
            this.lbSaleCode.Name = "lbSaleCode";
            this.lbSaleCode.Size = new System.Drawing.Size(200, 25);
            this.lbSaleCode.TabIndex = 0;
            this.lbSaleCode.Text = "Mã người phụ trách";
            this.lbSaleCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.White;
            this.btnUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderSize = 1;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(900, 620);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(685, 620);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // debounceUserTimer
            // 
            this.debounceUserTimer.Interval = 400;
            this.debounceUserTimer.Tick += new System.EventHandler(this.debounceUserTimer_Tick);
            // 
            // debounceContractTimer
            // 
            this.debounceContractTimer.Interval = 400;
            this.debounceContractTimer.Tick += new System.EventHandler(this.debounceContractTimer_Tick);
            // 
            // UpdateTaskGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.ControlBox = false;
            this.Controls.Add(this.panelTaskName);
            this.Controls.Add(this.panelDateFinish);
            this.Controls.Add(this.panelDateStart);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelContract);
            this.Controls.Add(this.panelSaleCode);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateTaskGUI";
            this.Text = "UpdateJobForm";
            this.panelTaskName.ResumeLayout(false);
            this.borderPanelTaskName.ResumeLayout(false);
            this.borderPanelTaskName.PerformLayout();
            this.panelDateFinish.ResumeLayout(false);
            this.borderPanelDateFinish.ResumeLayout(false);
            this.panelDateStart.ResumeLayout(false);
            this.borderPanelDateStart.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelContract.ResumeLayout(false);
            this.panelSaleCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelTaskName;
        private System.Windows.Forms.Label lbTaskNameErr;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel borderPanelTaskName;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Label lbTaskName;
        private System.Windows.Forms.Panel panelDateFinish;
        private System.Windows.Forms.Label lbDateFinishErr;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel borderPanelDateFinish;
        private System.Windows.Forms.DateTimePicker dateTimeFinish;
        private System.Windows.Forms.Label lbDateFinish;
        private System.Windows.Forms.Panel panelDateStart;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel borderPanelDateStart;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label lbDateStart;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel panelContract;
        private System.Windows.Forms.Label lbContractErr;
        private System.Windows.Forms.Label lbContract;
        private System.Windows.Forms.Panel panelSaleCode;
        private System.Windows.Forms.Label lbSaleCodeErr;
        private System.Windows.Forms.Label lbSaleCode;
        private CNPM_FINAL.GUI.CustomControl.BorderButton btnUpdate;
        private CNPM_FINAL.GUI.CustomControl.BorderButton btnCancel;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxContractCode;
        private System.Windows.Forms.ComboBox comboBoxUserCode;
        private System.Windows.Forms.Timer debounceUserTimer;
        private System.Windows.Forms.Timer debounceContractTimer;
    }
}