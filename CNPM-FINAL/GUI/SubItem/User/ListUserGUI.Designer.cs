using System.Drawing;

namespace CNPM_FINAL.GUI.SubItem.User
{
    partial class ListUserGUI
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
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.columnTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIconUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnIconResetPassword = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnPermission = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lbSearchErr = new System.Windows.Forms.Label();
            this.borderPanelSearch = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.debounceTimer = new System.Windows.Forms.Timer(this.components);
            this.btnGetAll = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.borderPanelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.AllowUserToResizeRows = false;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTaskId,
            this.columnUserCode,
            this.columnUsername,
            this.columnFullName,
            this.columnRole,
            this.columnEmail,
            this.columnPhone,
            this.columnIconUpdate,
            this.columnIconResetPassword,
            this.columnPermission});
            this.dataGridViewUser.EnableHeadersVisualStyles = false;
            this.dataGridViewUser.Location = new System.Drawing.Point(75, 230);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersVisible = false;
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(945, 450);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.TabStop = false;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // columnTaskId
            // 
            this.columnTaskId.HeaderText = "ID";
            this.columnTaskId.MinimumWidth = 6;
            this.columnTaskId.Name = "columnTaskId";
            this.columnTaskId.ReadOnly = true;
            this.columnTaskId.Visible = false;
            this.columnTaskId.Width = 125;
            // 
            // columnUserCode
            // 
            this.columnUserCode.HeaderText = "Mã người dùng";
            this.columnUserCode.MinimumWidth = 6;
            this.columnUserCode.Name = "columnUserCode";
            this.columnUserCode.ReadOnly = true;
            this.columnUserCode.Width = 125;
            // 
            // columnUsername
            // 
            this.columnUsername.HeaderText = "Tên đăng nhập";
            this.columnUsername.MinimumWidth = 6;
            this.columnUsername.Name = "columnUsername";
            this.columnUsername.ReadOnly = true;
            this.columnUsername.Width = 125;
            // 
            // columnFullName
            // 
            this.columnFullName.HeaderText = "Họ và tên";
            this.columnFullName.MinimumWidth = 6;
            this.columnFullName.Name = "columnFullName";
            this.columnFullName.ReadOnly = true;
            this.columnFullName.Width = 125;
            // 
            // columnRole
            // 
            this.columnRole.HeaderText = "Vai trò";
            this.columnRole.MinimumWidth = 6;
            this.columnRole.Name = "columnRole";
            this.columnRole.ReadOnly = true;
            this.columnRole.Width = 125;
            // 
            // columnEmail
            // 
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.MinimumWidth = 6;
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            this.columnEmail.Width = 125;
            // 
            // columnPhone
            // 
            this.columnPhone.HeaderText = "Số điện thoại";
            this.columnPhone.MinimumWidth = 6;
            this.columnPhone.Name = "columnPhone";
            this.columnPhone.ReadOnly = true;
            this.columnPhone.Width = 125;
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
            // columnIconResetPassword
            // 
            this.columnIconResetPassword.HeaderText = "Cấp lại mật khẩu";
            this.columnIconResetPassword.Image = global::CNPM_FINAL.Properties.Resources.key_fill_icon_20x20;
            this.columnIconResetPassword.MinimumWidth = 6;
            this.columnIconResetPassword.Name = "columnIconResetPassword";
            this.columnIconResetPassword.ReadOnly = true;
            this.columnIconResetPassword.Width = 125;
            // 
            // columnPermission
            // 
            this.columnPermission.HeaderText = "Phân quyền";
            this.columnPermission.Image = global::CNPM_FINAL.Properties.Resources.security_user_half_icon_20x20;
            this.columnPermission.MinimumWidth = 6;
            this.columnPermission.Name = "columnPermission";
            this.columnPermission.ReadOnly = true;
            this.columnPermission.Width = 125;
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
            this.lbTitle.Text = "Danh sách người dùng";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbSearch.Text = "Tìm theo mã nhân viên và tên người dùng";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // debounceTimer
            // 
            this.debounceTimer.Interval = 400;
            this.debounceTimer.Tick += new System.EventHandler(this.debounceTimer_Tick);
            // 
            // btnGetAll
            // 
            this.btnGetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(82)))), ((int)(((byte)(115)))));
            this.btnGetAll.BackgroundColor = System.Drawing.Color.White;
            this.btnGetAll.BorderColor = System.Drawing.Color.Transparent;
            this.btnGetAll.BorderRadius = 10;
            this.btnGetAll.BorderSize = 1;
            this.btnGetAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetAll.FlatAppearance.BorderSize = 0;
            this.btnGetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAll.ForeColor = System.Drawing.Color.White;
            this.btnGetAll.Location = new System.Drawing.Point(630, 120);
            this.btnGetAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(150, 40);
            this.btnGetAll.TabIndex = 2;
            this.btnGetAll.Text = "Xem tất cả";
            this.btnGetAll.UseVisualStyleBackColor = false;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // ListUserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListUserGUI";
            this.Text = "ListUserGUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.borderPanelSearch.ResumeLayout(false);
            this.borderPanelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUser;
        private CustomControl.BorderButton btnGetAll;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lbSearchErr;
        private CustomControl.BorderPanel borderPanelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUserCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
        private System.Windows.Forms.DataGridViewImageColumn columnIconUpdate;
        private System.Windows.Forms.DataGridViewImageColumn columnIconResetPassword;
        private System.Windows.Forms.DataGridViewImageColumn columnPermission;
        private System.Windows.Forms.Timer debounceTimer;
    }
}