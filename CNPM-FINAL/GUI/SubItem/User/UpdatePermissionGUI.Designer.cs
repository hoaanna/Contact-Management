using System.Drawing;

namespace CNPM_FINAL.GUI.SubItem.User
{
    partial class UpdatePermissionGUI
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbbUsercode = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.columnElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnCreate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnLock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCancel = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.btnConfirm = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.lbTitle.Text = "Phân quyền người dùng";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbbUsercode
            // 
            this.lbbUsercode.AutoSize = true;
            this.lbbUsercode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbUsercode.Location = new System.Drawing.Point(75, 100);
            this.lbbUsercode.Margin = new System.Windows.Forms.Padding(0);
            this.lbbUsercode.Name = "lbbUsercode";
            this.lbbUsercode.Size = new System.Drawing.Size(157, 28);
            this.lbbUsercode.TabIndex = 0;
            this.lbbUsercode.Text = "Mã người dùng: ";
            this.lbbUsercode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(75, 200);
            this.lbRole.Margin = new System.Windows.Forms.Padding(0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(78, 28);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "Vai trò: ";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullname.Location = new System.Drawing.Point(75, 150);
            this.lbFullname.Margin = new System.Windows.Forms.Padding(0);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(158, 28);
            this.lbFullname.TabIndex = 0;
            this.lbFullname.Text = "Tên người dùng: ";
            this.lbFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnElement,
            this.columnGet,
            this.columnCreate,
            this.columnUpdate,
            this.columnDelete,
            this.columnLock});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(85, 300);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(935, 250);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_CurrentCellDirtyStateChanged);
            // 
            // columnElement
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnElement.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnElement.HeaderText = "Thành phần";
            this.columnElement.MinimumWidth = 6;
            this.columnElement.Name = "columnElement";
            this.columnElement.ReadOnly = true;
            // 
            // columnGet
            // 
            this.columnGet.HeaderText = "Xem";
            this.columnGet.MinimumWidth = 6;
            this.columnGet.Name = "columnGet";
            // 
            // columnCreate
            // 
            this.columnCreate.HeaderText = "Thêm";
            this.columnCreate.MinimumWidth = 6;
            this.columnCreate.Name = "columnCreate";
            // 
            // columnUpdate
            // 
            this.columnUpdate.HeaderText = "Sửa ";
            this.columnUpdate.MinimumWidth = 6;
            this.columnUpdate.Name = "columnUpdate";
            // 
            // columnDelete
            // 
            this.columnDelete.HeaderText = "Xóa";
            this.columnDelete.MinimumWidth = 6;
            this.columnDelete.Name = "columnDelete";
            // 
            // columnLock
            // 
            this.columnLock.HeaderText = "Khóa";
            this.columnLock.MinimumWidth = 6;
            this.columnLock.Name = "columnLock";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(129)))), ((int)(((byte)(151)))), ((int)(((byte)(179)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(675, 640);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.btnConfirm.BackgroundColor = System.Drawing.Color.White;
            this.btnConfirm.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BorderRadius = 10;
            this.btnConfirm.BorderSize = 1;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(870, 640);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 40);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // UpdatePermissionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbFullname);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbbUsercode);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePermissionGUI";
            this.Text = "UpdatePermission";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbbUsercode;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.DataGridView dataGridView;
        private CustomControl.BorderButton btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnElement;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnGet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnCreate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnLock;
        private CustomControl.BorderButton btnCancel;
    }
}