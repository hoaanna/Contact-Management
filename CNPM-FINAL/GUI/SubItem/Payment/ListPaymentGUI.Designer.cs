namespace CNPM_FINAL.GUI.SubItem.Payment
{
    partial class ListPaymentGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lbSplit = new System.Windows.Forms.Label();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.borderPanelDateExpire = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.borderPanelDateSign = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lbFilterErr = new System.Windows.Forms.Label();
            this.dataGridViewPaymentStage = new System.Windows.Forms.DataGridView();
            this.columnPaymentStageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnContractCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIconUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnIconDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lbSearchErr = new System.Windows.Forms.Label();
            this.borderPanelSearch = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.debounceTimer = new System.Windows.Forms.Timer(this.components);
            this.fileContainer = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnFile = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.btnGetAll = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.panelFilter.SuspendLayout();
            this.borderPanelDateExpire.SuspendLayout();
            this.borderPanelDateSign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentStage)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.borderPanelSearch.SuspendLayout();
            this.fileContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.lbSplit);
            this.panelFilter.Controls.Add(this.checkBoxFilter);
            this.panelFilter.Controls.Add(this.borderPanelDateExpire);
            this.panelFilter.Controls.Add(this.borderPanelDateSign);
            this.panelFilter.Controls.Add(this.lbFilterErr);
            this.panelFilter.Location = new System.Drawing.Point(75, 200);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(945, 85);
            this.panelFilter.TabIndex = 4;
            // 
            // lbSplit
            // 
            this.lbSplit.BackColor = System.Drawing.Color.Black;
            this.lbSplit.Location = new System.Drawing.Point(460, 42);
            this.lbSplit.Margin = new System.Windows.Forms.Padding(0);
            this.lbSplit.Name = "lbSplit";
            this.lbSplit.Size = new System.Drawing.Size(25, 1);
            this.lbSplit.TabIndex = 4;
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFilter.Location = new System.Drawing.Point(10, 0);
            this.checkBoxFilter.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(143, 24);
            this.checkBoxFilter.TabIndex = 1;
            this.checkBoxFilter.Text = "Bộ lọc theo ngày";
            this.checkBoxFilter.UseVisualStyleBackColor = false;
            this.checkBoxFilter.CheckedChanged += new System.EventHandler(this.checkBoxFilter_CheckedChanged);
            // 
            // borderPanelDateExpire
            // 
            this.borderPanelDateExpire.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelDateExpire.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDateExpire.BorderRadius = 10;
            this.borderPanelDateExpire.BorderSize = 1;
            this.borderPanelDateExpire.Controls.Add(this.dateTimePickerTo);
            this.borderPanelDateExpire.Location = new System.Drawing.Point(550, 25);
            this.borderPanelDateExpire.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelDateExpire.Name = "borderPanelDateExpire";
            this.borderPanelDateExpire.Size = new System.Drawing.Size(385, 30);
            this.borderPanelDateExpire.TabIndex = 3;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerTo.Enabled = false;
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(10, 4);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(360, 22);
            this.dateTimePickerTo.TabIndex = 1;
            this.dateTimePickerTo.CloseUp += new System.EventHandler(this.dateTimePicker_Event);
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePicker_Event);
            // 
            // borderPanelDateSign
            // 
            this.borderPanelDateSign.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelDateSign.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDateSign.BorderRadius = 10;
            this.borderPanelDateSign.BorderSize = 1;
            this.borderPanelDateSign.Controls.Add(this.dateTimePickerFrom);
            this.borderPanelDateSign.Location = new System.Drawing.Point(10, 25);
            this.borderPanelDateSign.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelDateSign.Name = "borderPanelDateSign";
            this.borderPanelDateSign.Size = new System.Drawing.Size(385, 30);
            this.borderPanelDateSign.TabIndex = 2;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerFrom.Enabled = false;
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(10, 4);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(360, 22);
            this.dateTimePickerFrom.TabIndex = 1;
            this.dateTimePickerFrom.CloseUp += new System.EventHandler(this.dateTimePicker_Event);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePicker_Event);
            // 
            // lbFilterErr
            // 
            this.lbFilterErr.BackColor = System.Drawing.Color.Transparent;
            this.lbFilterErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterErr.ForeColor = System.Drawing.Color.Red;
            this.lbFilterErr.Location = new System.Drawing.Point(20, 55);
            this.lbFilterErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbFilterErr.Name = "lbFilterErr";
            this.lbFilterErr.Size = new System.Drawing.Size(480, 20);
            this.lbFilterErr.TabIndex = 0;
            this.lbFilterErr.Visible = false;
            // 
            // dataGridViewPaymentStage
            // 
            this.dataGridViewPaymentStage.AllowUserToAddRows = false;
            this.dataGridViewPaymentStage.AllowUserToDeleteRows = false;
            this.dataGridViewPaymentStage.AllowUserToResizeRows = false;
            this.dataGridViewPaymentStage.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaymentStage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPaymentStage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaymentStage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnPaymentStageId,
            this.columnContractCode,
            this.columnStageName,
            this.columnDescription,
            this.columnPaymentDate,
            this.columnAmount,
            this.columnPercentage,
            this.columnStatus,
            this.columnIconUpdate,
            this.columnIconDelete});
            this.dataGridViewPaymentStage.EnableHeadersVisualStyles = false;
            this.dataGridViewPaymentStage.Location = new System.Drawing.Point(75, 300);
            this.dataGridViewPaymentStage.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPaymentStage.Name = "dataGridViewPaymentStage";
            this.dataGridViewPaymentStage.ReadOnly = true;
            this.dataGridViewPaymentStage.RowHeadersVisible = false;
            this.dataGridViewPaymentStage.RowHeadersWidth = 51;
            this.dataGridViewPaymentStage.RowTemplate.Height = 24;
            this.dataGridViewPaymentStage.Size = new System.Drawing.Size(945, 400);
            this.dataGridViewPaymentStage.TabIndex = 0;
            this.dataGridViewPaymentStage.TabStop = false;
            this.dataGridViewPaymentStage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaymentStage_CellContentClick);
            // 
            // columnPaymentStageId
            // 
            this.columnPaymentStageId.HeaderText = "Mã giai đoạn";
            this.columnPaymentStageId.MinimumWidth = 6;
            this.columnPaymentStageId.Name = "columnPaymentStageId";
            this.columnPaymentStageId.ReadOnly = true;
            this.columnPaymentStageId.Visible = false;
            this.columnPaymentStageId.Width = 125;
            // 
            // columnContractCode
            // 
            this.columnContractCode.HeaderText = "Mã hợp đồng";
            this.columnContractCode.MinimumWidth = 6;
            this.columnContractCode.Name = "columnContractCode";
            this.columnContractCode.ReadOnly = true;
            this.columnContractCode.Width = 125;
            // 
            // columnStageName
            // 
            this.columnStageName.HeaderText = "Tên giai đoạn";
            this.columnStageName.MinimumWidth = 6;
            this.columnStageName.Name = "columnStageName";
            this.columnStageName.ReadOnly = true;
            this.columnStageName.Width = 125;
            // 
            // columnDescription
            // 
            this.columnDescription.HeaderText = "Mô tả";
            this.columnDescription.MinimumWidth = 6;
            this.columnDescription.Name = "columnDescription";
            this.columnDescription.ReadOnly = true;
            this.columnDescription.Width = 125;
            // 
            // columnPaymentDate
            // 
            this.columnPaymentDate.HeaderText = "Ngày thực hiện";
            this.columnPaymentDate.MinimumWidth = 6;
            this.columnPaymentDate.Name = "columnPaymentDate";
            this.columnPaymentDate.ReadOnly = true;
            this.columnPaymentDate.Width = 125;
            // 
            // columnAmount
            // 
            this.columnAmount.HeaderText = "Số tiền";
            this.columnAmount.MinimumWidth = 6;
            this.columnAmount.Name = "columnAmount";
            this.columnAmount.ReadOnly = true;
            this.columnAmount.Width = 125;
            // 
            // columnPercentage
            // 
            this.columnPercentage.HeaderText = "Phần trăm";
            this.columnPercentage.MinimumWidth = 6;
            this.columnPercentage.Name = "columnPercentage";
            this.columnPercentage.ReadOnly = true;
            this.columnPercentage.Width = 125;
            // 
            // columnStatus
            // 
            this.columnStatus.HeaderText = "Trạng thái";
            this.columnStatus.MinimumWidth = 6;
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.ReadOnly = true;
            this.columnStatus.Width = 125;
            // 
            // columnIconUpdate
            // 
            this.columnIconUpdate.HeaderText = "Cập nhật";
            this.columnIconUpdate.Image = global::CNPM_FINAL.Properties.Resources.updateIcon_18x18;
            this.columnIconUpdate.MinimumWidth = 6;
            this.columnIconUpdate.Name = "columnIconUpdate";
            this.columnIconUpdate.ReadOnly = true;
            this.columnIconUpdate.Width = 125;
            // 
            // columnIconDelete
            // 
            this.columnIconDelete.HeaderText = "Xóa";
            this.columnIconDelete.Image = global::CNPM_FINAL.Properties.Resources.delete_remove_icon_18x18;
            this.columnIconDelete.MinimumWidth = 6;
            this.columnIconDelete.Name = "columnIconDelete";
            this.columnIconDelete.ReadOnly = true;
            this.columnIconDelete.Width = 125;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.lbSearchErr);
            this.panelSearch.Controls.Add(this.borderPanelSearch);
            this.panelSearch.Controls.Add(this.lbSearch);
            this.panelSearch.Location = new System.Drawing.Point(75, 100);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(520, 85);
            this.panelSearch.TabIndex = 1;
            // 
            // lbSearchErr
            // 
            this.lbSearchErr.BackColor = System.Drawing.Color.Transparent;
            this.lbSearchErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchErr.ForeColor = System.Drawing.Color.Red;
            this.lbSearchErr.Location = new System.Drawing.Point(20, 55);
            this.lbSearchErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbSearchErr.Name = "lbSearchErr";
            this.lbSearchErr.Size = new System.Drawing.Size(480, 20);
            this.lbSearchErr.TabIndex = 0;
            this.lbSearchErr.Visible = false;
            // 
            // borderPanelSearch
            // 
            this.borderPanelSearch.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelSearch.BorderColor = System.Drawing.Color.Black;
            this.borderPanelSearch.BorderRadius = 10;
            this.borderPanelSearch.BorderSize = 1;
            this.borderPanelSearch.Controls.Add(this.textBoxSearch);
            this.borderPanelSearch.Location = new System.Drawing.Point(10, 25);
            this.borderPanelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelSearch.Name = "borderPanelSearch";
            this.borderPanelSearch.Size = new System.Drawing.Size(490, 30);
            this.borderPanelSearch.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(13, 4);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(465, 23);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Event);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(10, 0);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(450, 25);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Tìm kiếm theo mã hợp đồng";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbTitle.Text = "Các giai đoạn thanh toán";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // debounceTimer
            // 
            this.debounceTimer.Interval = 400;
            this.debounceTimer.Tick += new System.EventHandler(this.debounceTimer_Tick);
            // 
            // fileContainer
            // 
            this.fileContainer.BackgroundColor = System.Drawing.Color.White;
            this.fileContainer.BorderColor = System.Drawing.Color.Transparent;
            this.fileContainer.BorderRadius = 10;
            this.fileContainer.BorderSize = 1;
            this.fileContainer.Controls.Add(this.btnPDF);
            this.fileContainer.Controls.Add(this.btnExcel);
            this.fileContainer.Location = new System.Drawing.Point(865, 165);
            this.fileContainer.Margin = new System.Windows.Forms.Padding(0);
            this.fileContainer.Name = "fileContainer";
            this.fileContainer.Size = new System.Drawing.Size(150, 80);
            this.fileContainer.TabIndex = 0;
            this.fileContainer.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnPDF.Location = new System.Drawing.Point(0, 40);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(0);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(150, 40);
            this.btnPDF.TabIndex = 0;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnExcel.Location = new System.Drawing.Point(0, 0);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(150, 40);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnFile.BackgroundColor = System.Drawing.Color.White;
            this.btnFile.BorderColor = System.Drawing.Color.Transparent;
            this.btnFile.BorderRadius = 10;
            this.btnFile.BorderSize = 1;
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.ForeColor = System.Drawing.Color.Black;
            this.btnFile.Location = new System.Drawing.Point(865, 120);
            this.btnFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(150, 40);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "Xuất dữ liệu";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.btnGetAll.BackgroundColor = System.Drawing.Color.White;
            this.btnGetAll.BorderColor = System.Drawing.Color.Transparent;
            this.btnGetAll.BorderRadius = 10;
            this.btnGetAll.BorderSize = 1;
            this.btnGetAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetAll.FlatAppearance.BorderSize = 0;
            this.btnGetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAll.ForeColor = System.Drawing.Color.White;
            this.btnGetAll.Location = new System.Drawing.Point(660, 120);
            this.btnGetAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(150, 40);
            this.btnGetAll.TabIndex = 2;
            this.btnGetAll.Text = "Xem tất cả";
            this.btnGetAll.UseVisualStyleBackColor = false;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // ListPaymentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.ControlBox = false;
            this.Controls.Add(this.fileContainer);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.dataGridViewPaymentStage);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListPaymentGUI";
            this.Text = "ListPaymentGUI";
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.borderPanelDateExpire.ResumeLayout(false);
            this.borderPanelDateSign.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentStage)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.borderPanelSearch.ResumeLayout(false);
            this.borderPanelSearch.PerformLayout();
            this.fileContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.CheckBox checkBoxFilter;
        private CustomControl.BorderPanel borderPanelDateExpire;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private CustomControl.BorderPanel borderPanelDateSign;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lbFilterErr;
        private CustomControl.BorderButton btnGetAll;
        private System.Windows.Forms.DataGridView dataGridViewPaymentStage;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lbSearchErr;
        private CustomControl.BorderPanel borderPanelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSplit;
        private System.Windows.Forms.Timer debounceTimer;
        private CustomControl.BorderButton btnFile;
        private CustomControl.BorderPanel fileContainer;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPaymentStageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnContractCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewImageColumn columnIconUpdate;
        private System.Windows.Forms.DataGridViewImageColumn columnIconDelete;
    }
}