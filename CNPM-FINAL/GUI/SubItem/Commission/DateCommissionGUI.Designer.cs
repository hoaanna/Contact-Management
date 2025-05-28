using CNPM_FINAL.DTO;
using System;

namespace CNPM_FINAL.GUI.SubItem.Commission
{
    partial class DateCommissionGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lbFilterErr = new System.Windows.Forms.Label();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.borderPanelDateEnd = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.borderPanelDateStart = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewCommission = new System.Windows.Forms.DataGridView();
            this.columnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChangeDate = new System.Windows.Forms.Panel();
            this.btnSave = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.btnCancel = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.lbNewDate = new System.Windows.Forms.Label();
            this.borderPanelNewDate = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxNewDate = new System.Windows.Forms.TextBox();
            this.lbHistory = new System.Windows.Forms.Label();
            this.lbCurrentDate = new System.Windows.Forms.Label();
            this.btnChangeDate = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.panelFilter.SuspendLayout();
            this.borderPanelDateEnd.SuspendLayout();
            this.borderPanelDateStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommission)).BeginInit();
            this.panelChangeDate.SuspendLayout();
            this.borderPanelNewDate.SuspendLayout();
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
            this.lbTitle.Text = "Đổi ngày tính hoa hồng";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.lbFilterErr);
            this.panelFilter.Controls.Add(this.checkBoxFilter);
            this.panelFilter.Controls.Add(this.borderPanelDateEnd);
            this.panelFilter.Controls.Add(this.borderPanelDateStart);
            this.panelFilter.Location = new System.Drawing.Point(75, 183);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(945, 85);
            this.panelFilter.TabIndex = 10;
            // 
            // lbFilterErr
            // 
            this.lbFilterErr.BackColor = System.Drawing.Color.Transparent;
            this.lbFilterErr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterErr.ForeColor = System.Drawing.Color.Red;
            this.lbFilterErr.Location = new System.Drawing.Point(17, 55);
            this.lbFilterErr.Margin = new System.Windows.Forms.Padding(0);
            this.lbFilterErr.Name = "lbFilterErr";
            this.lbFilterErr.Size = new System.Drawing.Size(480, 20);
            this.lbFilterErr.TabIndex = 13;
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFilter.Location = new System.Drawing.Point(10, 0);
            this.checkBoxFilter.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(182, 24);
            this.checkBoxFilter.TabIndex = 1;
            this.checkBoxFilter.Text = "Lọc theo ngày thay đổi";
            this.checkBoxFilter.UseVisualStyleBackColor = false;
            this.checkBoxFilter.CheckedChanged += new System.EventHandler(this.checkBoxFilter_CheckedChanged);
            // 
            // borderPanelDateEnd
            // 
            this.borderPanelDateEnd.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelDateEnd.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDateEnd.BorderRadius = 10;
            this.borderPanelDateEnd.BorderSize = 1;
            this.borderPanelDateEnd.Controls.Add(this.dateTimePickerTo);
            this.borderPanelDateEnd.Location = new System.Drawing.Point(458, 25);
            this.borderPanelDateEnd.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelDateEnd.Name = "borderPanelDateEnd";
            this.borderPanelDateEnd.Size = new System.Drawing.Size(385, 30);
            this.borderPanelDateEnd.TabIndex = 3;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(12, 4);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(360, 22);
            this.dateTimePickerTo.TabIndex = 2;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePicker_Event);
            // 
            // borderPanelDateStart
            // 
            this.borderPanelDateStart.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelDateStart.BorderColor = System.Drawing.Color.Black;
            this.borderPanelDateStart.BorderRadius = 10;
            this.borderPanelDateStart.BorderSize = 1;
            this.borderPanelDateStart.Controls.Add(this.dateTimePickerFrom);
            this.borderPanelDateStart.Location = new System.Drawing.Point(10, 25);
            this.borderPanelDateStart.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelDateStart.Name = "borderPanelDateStart";
            this.borderPanelDateStart.Size = new System.Drawing.Size(385, 30);
            this.borderPanelDateStart.TabIndex = 2;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 4);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(360, 22);
            this.dateTimePickerFrom.TabIndex = 2;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePicker_Event);
            // 
            // dataGridViewCommission
            // 
            this.dataGridViewCommission.AllowUserToAddRows = false;
            this.dataGridViewCommission.AllowUserToDeleteRows = false;
            this.dataGridViewCommission.AllowUserToResizeRows = false;
            this.dataGridViewCommission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCommission.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(85)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCommission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCommission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnValue,
            this.columnDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCommission.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCommission.EnableHeadersVisualStyles = false;
            this.dataGridViewCommission.Location = new System.Drawing.Point(75, 305);
            this.dataGridViewCommission.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCommission.Name = "dataGridViewCommission";
            this.dataGridViewCommission.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCommission.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCommission.RowHeadersVisible = false;
            this.dataGridViewCommission.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCommission.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCommission.RowTemplate.Height = 24;
            this.dataGridViewCommission.Size = new System.Drawing.Size(945, 400);
            this.dataGridViewCommission.TabIndex = 9;
            this.dataGridViewCommission.TabStop = false;
            // 
            // columnValue
            // 
            this.columnValue.HeaderText = "Ngày tính hoa hồng";
            this.columnValue.MinimumWidth = 6;
            this.columnValue.Name = "columnValue";
            this.columnValue.ReadOnly = true;
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "Ngày thực hiện thay đổi";
            this.columnDate.MinimumWidth = 6;
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            // 
            // panelChangeDate
            // 
            this.panelChangeDate.Controls.Add(this.btnSave);
            this.panelChangeDate.Controls.Add(this.btnCancel);
            this.panelChangeDate.Controls.Add(this.lbNewDate);
            this.panelChangeDate.Controls.Add(this.borderPanelNewDate);
            this.panelChangeDate.Location = new System.Drawing.Point(197, 271);
            this.panelChangeDate.Name = "panelChangeDate";
            this.panelChangeDate.Size = new System.Drawing.Size(733, 302);
            this.panelChangeDate.TabIndex = 11;
            this.panelChangeDate.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.White;
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderSize = 1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(568, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(420, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbNewDate
            // 
            this.lbNewDate.AutoSize = true;
            this.lbNewDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewDate.Location = new System.Drawing.Point(65, 34);
            this.lbNewDate.Name = "lbNewDate";
            this.lbNewDate.Size = new System.Drawing.Size(218, 31);
            this.lbNewDate.TabIndex = 0;
            this.lbNewDate.Text = "Nhập ngày tính mới";
            // 
            // borderPanelNewDate
            // 
            this.borderPanelNewDate.BackgroundColor = System.Drawing.Color.White;
            this.borderPanelNewDate.BorderColor = System.Drawing.Color.Black;
            this.borderPanelNewDate.BorderRadius = 10;
            this.borderPanelNewDate.BorderSize = 2;
            this.borderPanelNewDate.Controls.Add(this.textBoxNewDate);
            this.borderPanelNewDate.Location = new System.Drawing.Point(71, 110);
            this.borderPanelNewDate.Margin = new System.Windows.Forms.Padding(0);
            this.borderPanelNewDate.Name = "borderPanelNewDate";
            this.borderPanelNewDate.Size = new System.Drawing.Size(590, 53);
            this.borderPanelNewDate.TabIndex = 0;
            // 
            // textBoxNewDate
            // 
            this.textBoxNewDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewDate.Location = new System.Drawing.Point(14, 11);
            this.textBoxNewDate.Name = "textBoxNewDate";
            this.textBoxNewDate.Size = new System.Drawing.Size(560, 31);
            this.textBoxNewDate.TabIndex = 0;
            // 
            // lbHistory
            // 
            this.lbHistory.AutoSize = true;
            this.lbHistory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistory.Location = new System.Drawing.Point(69, 268);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(174, 31);
            this.lbHistory.TabIndex = 12;
            this.lbHistory.Text = "Lịch sử thay đổi";
            // 
            // lbCurrentDate
            // 
            this.lbCurrentDate.AutoSize = true;
            this.lbCurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.lbCurrentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentDate.Location = new System.Drawing.Point(80, 120);
            this.lbCurrentDate.Margin = new System.Windows.Forms.Padding(0);
            this.lbCurrentDate.Name = "lbCurrentDate";
            this.lbCurrentDate.Size = new System.Drawing.Size(128, 31);
            this.lbCurrentDate.TabIndex = 0;
            this.lbCurrentDate.Text = "Show ngày";
            // 
            // btnChangeDate
            // 
            this.btnChangeDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.btnChangeDate.BackgroundColor = System.Drawing.Color.White;
            this.btnChangeDate.BorderColor = System.Drawing.Color.Transparent;
            this.btnChangeDate.BorderRadius = 10;
            this.btnChangeDate.BorderSize = 1;
            this.btnChangeDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeDate.FlatAppearance.BorderSize = 0;
            this.btnChangeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDate.ForeColor = System.Drawing.Color.White;
            this.btnChangeDate.Location = new System.Drawing.Point(780, 109);
            this.btnChangeDate.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeDate.Name = "btnChangeDate";
            this.btnChangeDate.Size = new System.Drawing.Size(150, 40);
            this.btnChangeDate.TabIndex = 3;
            this.btnChangeDate.Text = "Đổi ngày";
            this.btnChangeDate.UseVisualStyleBackColor = false;
            this.btnChangeDate.Click += new System.EventHandler(this.btnChangeDate_Click);
            // 
            // DateCommissionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.lbCurrentDate);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.panelChangeDate);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.btnChangeDate);
            this.Controls.Add(this.dataGridViewCommission);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DateCommissionGUI";
            this.Text = "ListCommissionGUI";
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.borderPanelDateEnd.ResumeLayout(false);
            this.borderPanelDateStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommission)).EndInit();
            this.panelChangeDate.ResumeLayout(false);
            this.panelChangeDate.PerformLayout();
            this.borderPanelNewDate.ResumeLayout(false);
            this.borderPanelNewDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.CheckBox checkBoxFilter;
        private CustomControl.BorderPanel borderPanelDateEnd;
        private CustomControl.BorderPanel borderPanelDateStart;
        private CustomControl.BorderButton btnChangeDate;
        private System.Windows.Forms.DataGridView dataGridViewCommission;
        private CustomControl.BorderPanel borderPanelNewDate;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.Panel panelChangeDate;
        private System.Windows.Forms.Label lbNewDate;
        private CustomControl.BorderButton btnSave;
        private CustomControl.BorderButton btnCancel;
        private System.Windows.Forms.TextBox textBoxNewDate;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.Label lbFilterErr;
        private System.Windows.Forms.Label lbCurrentDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    }
}