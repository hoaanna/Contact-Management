using System.Drawing;

namespace CNPM_FINAL.GUI.SubItem.Task
{
    partial class ListTaskGUI
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lbSearchErr = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.checkBoxExpirationDate = new System.Windows.Forms.CheckBox();
            this.lbSplit = new System.Windows.Forms.Label();
            this.checkBoxSignedDate = new System.Windows.Forms.CheckBox();
            this.lbFilterErr = new System.Windows.Forms.Label();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.columnContractCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnContractName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIconDetail = new System.Windows.Forms.DataGridViewImageColumn();
            this.debounceTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.fileContainer = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnFile = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.borderPanelDateExpire = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.borderPanelDateSign = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnGetAll = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.borderPanelSearch = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelSearch.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            this.fileContainer.SuspendLayout();
            this.borderPanelDateExpire.SuspendLayout();
            this.borderPanelDateSign.SuspendLayout();
            this.borderPanelSearch.SuspendLayout();
            this.SuspendLayout();
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
            this.lbSearch.Text = "Tìm theo tên công việc và mã hợp đồng";
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
            this.lbTitle.Text = "Danh sách hợp công việc đang quản lý";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.checkBoxExpirationDate);
            this.panelFilter.Controls.Add(this.lbSplit);
            this.panelFilter.Controls.Add(this.checkBoxSignedDate);
            this.panelFilter.Controls.Add(this.borderPanelDateExpire);
            this.panelFilter.Controls.Add(this.borderPanelDateSign);
            this.panelFilter.Controls.Add(this.lbFilterErr);
            this.panelFilter.Location = new System.Drawing.Point(75, 200);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(945, 85);
            this.panelFilter.TabIndex = 4;
            // 
            // checkBoxExpirationDate
            // 
            this.checkBoxExpirationDate.AutoSize = true;
            this.checkBoxExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExpirationDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxExpirationDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExpirationDate.Location = new System.Drawing.Point(550, 0);
            this.checkBoxExpirationDate.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxExpirationDate.Name = "checkBoxExpirationDate";
            this.checkBoxExpirationDate.Size = new System.Drawing.Size(180, 24);
            this.checkBoxExpirationDate.TabIndex = 4;
            this.checkBoxExpirationDate.Text = "Lọc theo ngày kết thúc";
            this.checkBoxExpirationDate.UseVisualStyleBackColor = false;
            this.checkBoxExpirationDate.CheckedChanged += new System.EventHandler(this.checkBoxEndDate_CheckedChanged);
            // 
            // lbSplit
            // 
            this.lbSplit.BackColor = System.Drawing.Color.Black;
            this.lbSplit.Location = new System.Drawing.Point(460, 42);
            this.lbSplit.Margin = new System.Windows.Forms.Padding(0);
            this.lbSplit.Name = "lbSplit";
            this.lbSplit.Size = new System.Drawing.Size(25, 1);
            this.lbSplit.TabIndex = 0;
            // 
            // checkBoxSignedDate
            // 
            this.checkBoxSignedDate.AutoSize = true;
            this.checkBoxSignedDate.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSignedDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSignedDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSignedDate.Location = new System.Drawing.Point(10, 0);
            this.checkBoxSignedDate.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSignedDate.Name = "checkBoxSignedDate";
            this.checkBoxSignedDate.Size = new System.Drawing.Size(179, 24);
            this.checkBoxSignedDate.TabIndex = 1;
            this.checkBoxSignedDate.Text = "Lọc theo ngày bắt đầu";
            this.checkBoxSignedDate.UseVisualStyleBackColor = false;
            this.checkBoxSignedDate.CheckedChanged += new System.EventHandler(this.checkBoxFilter_CheckedChanged);
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
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.AllowUserToAddRows = false;
            this.dataGridViewTask.AllowUserToDeleteRows = false;
            this.dataGridViewTask.AllowUserToResizeRows = false;
            this.dataGridViewTask.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnContractCode,
            this.columnContractName,
            this.columnSignedDate,
            this.columnExpirationDate,
            this.columnOrganization,
            this.columnPercentage,
            this.columnIconDetail});
            this.dataGridViewTask.EnableHeadersVisualStyles = false;
            this.dataGridViewTask.Location = new System.Drawing.Point(75, 300);
            this.dataGridViewTask.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.ReadOnly = true;
            this.dataGridViewTask.RowHeadersVisible = false;
            this.dataGridViewTask.RowHeadersWidth = 51;
            this.dataGridViewTask.RowTemplate.Height = 24;
            this.dataGridViewTask.Size = new System.Drawing.Size(945, 400);
            this.dataGridViewTask.TabIndex = 0;
            this.dataGridViewTask.TabStop = false;
            this.dataGridViewTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTask_CellContentClick);
            // 
            // columnContractCode
            // 
            this.columnContractCode.HeaderText = "Mã hợp đồng";
            this.columnContractCode.MinimumWidth = 6;
            this.columnContractCode.Name = "columnContractCode";
            this.columnContractCode.ReadOnly = true;
            this.columnContractCode.Width = 125;
            // 
            // columnContractName
            // 
            this.columnContractName.HeaderText = "Tên hợp đồng";
            this.columnContractName.MinimumWidth = 6;
            this.columnContractName.Name = "columnContractName";
            this.columnContractName.ReadOnly = true;
            this.columnContractName.Width = 125;
            // 
            // columnSignedDate
            // 
            this.columnSignedDate.HeaderText = "Ngày ký";
            this.columnSignedDate.MinimumWidth = 6;
            this.columnSignedDate.Name = "columnSignedDate";
            this.columnSignedDate.ReadOnly = true;
            this.columnSignedDate.Width = 125;
            // 
            // columnExpirationDate
            // 
            this.columnExpirationDate.HeaderText = "Ngày hết hạn";
            this.columnExpirationDate.MinimumWidth = 6;
            this.columnExpirationDate.Name = "columnExpirationDate";
            this.columnExpirationDate.ReadOnly = true;
            this.columnExpirationDate.Width = 125;
            // 
            // columnOrganization
            // 
            this.columnOrganization.HeaderText = "Tên tổ chức";
            this.columnOrganization.MinimumWidth = 6;
            this.columnOrganization.Name = "columnOrganization";
            this.columnOrganization.ReadOnly = true;
            this.columnOrganization.Width = 125;
            // 
            // columnPercentage
            // 
            this.columnPercentage.HeaderText = "Hoàn thiện (%)";
            this.columnPercentage.MinimumWidth = 6;
            this.columnPercentage.Name = "columnPercentage";
            this.columnPercentage.ReadOnly = true;
            this.columnPercentage.Width = 125;
            // 
            // columnIconDetail
            // 
            this.columnIconDetail.HeaderText = "Chi tiết";
            this.columnIconDetail.Image = global::CNPM_FINAL.Properties.Resources.information_icon;
            this.columnIconDetail.MinimumWidth = 6;
            this.columnIconDetail.Name = "columnIconDetail";
            this.columnIconDetail.ReadOnly = true;
            this.columnIconDetail.Width = 125;
            // 
            // debounceTimer
            // 
            this.debounceTimer.Interval = 400;
            this.debounceTimer.Tick += new System.EventHandler(this.debounceTimer_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Cập nhật";
            this.dataGridViewImageColumn1.Image = global::CNPM_FINAL.Properties.Resources.updateIcon_18x18;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Xóa";
            this.dataGridViewImageColumn2.Image = global::CNPM_FINAL.Properties.Resources.delete_remove_icon_18x18;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Chi tiết";
            this.dataGridViewImageColumn3.Image = global::CNPM_FINAL.Properties.Resources.information_icon;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 125;
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
            this.btnGetAll.TabIndex = 3;
            this.btnGetAll.Text = "Xem tất cả";
            this.btnGetAll.UseVisualStyleBackColor = false;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
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
            // ListTaskGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.ControlBox = false;
            this.Controls.Add(this.fileContainer);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.dataGridViewTask);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListTaskGUI";
            this.Text = "ListTaskGUI";
            this.panelSearch.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            this.fileContainer.ResumeLayout(false);
            this.borderPanelDateExpire.ResumeLayout(false);
            this.borderPanelDateSign.ResumeLayout(false);
            this.borderPanelSearch.ResumeLayout(false);
            this.borderPanelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lbSearchErr;
        private CustomControl.BorderPanel borderPanelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbTitle;
        private CustomControl.BorderButton btnGetAll;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.CheckBox checkBoxSignedDate;
        private CustomControl.BorderPanel borderPanelDateExpire;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private CustomControl.BorderPanel borderPanelDateSign;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lbFilterErr;
        private System.Windows.Forms.DataGridView dataGridViewTask;
        private System.Windows.Forms.Label lbSplit;
        private System.Windows.Forms.Timer debounceTimer;
        private System.Windows.Forms.CheckBox checkBoxExpirationDate;
        private CustomControl.BorderButton btnFile;
        private CustomControl.BorderPanel fileContainer;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnContractCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnContractName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSignedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOrganization;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPercentage;
        private System.Windows.Forms.DataGridViewImageColumn columnIconDetail;
    }
}