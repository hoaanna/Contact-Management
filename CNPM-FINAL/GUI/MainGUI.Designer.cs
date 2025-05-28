namespace CNPM_FINAL.GUI
{
    partial class MainGUI
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
            this.contractTimer = new System.Windows.Forms.Timer(this.components);
            this.paymentTimer = new System.Windows.Forms.Timer(this.components);
            this.taskTimer = new System.Windows.Forms.Timer(this.components);
            this.controlBox = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinimize = new System.Windows.Forms.FlowLayoutPanel();
            this.headerBar = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelLanguage = new System.Windows.Forms.Panel();
            this.borderPanelLanguage = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnVietnamese = new System.Windows.Forms.Button();
            this.panelSetting = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.flowLayoutPanelAvatar = new System.Windows.Forms.FlowLayoutPanel();
            this.logoUser = new CNPM_FINAL.GUI.CustomControl.CircularPictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.logoApp = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.homeContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.contractContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContract = new System.Windows.Forms.Panel();
            this.btnContract = new System.Windows.Forms.Button();
            this.panelListContract = new System.Windows.Forms.Panel();
            this.btnListContract = new System.Windows.Forms.Button();
            this.panelCreateContract = new System.Windows.Forms.Panel();
            this.btnCreateContract = new System.Windows.Forms.Button();
            this.paymentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panelListPayment = new System.Windows.Forms.Panel();
            this.btnListPayment = new System.Windows.Forms.Button();
            this.panelUpdatePayment = new System.Windows.Forms.Panel();
            this.btnCreatePayment = new System.Windows.Forms.Button();
            this.taskContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTask = new System.Windows.Forms.Panel();
            this.btnTask = new System.Windows.Forms.Button();
            this.panelListTask = new System.Windows.Forms.Panel();
            this.btnListTask = new System.Windows.Forms.Button();
            this.panelCreateTask = new System.Windows.Forms.Panel();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.listUserContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnListUser = new System.Windows.Forms.Button();
            this.addUserContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.createUserContainer = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.commissionContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCommission = new System.Windows.Forms.Button();
            this.dateCommissionContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDateCommission = new System.Windows.Forms.Button();
            this.supportContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSupport = new System.Windows.Forms.Button();
            this.lbCopyRight = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            this.headerBar.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelLanguage.SuspendLayout();
            this.borderPanelLanguage.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.flowLayoutPanelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).BeginInit();
            this.sidebar.SuspendLayout();
            this.homeContainer.SuspendLayout();
            this.contractContainer.SuspendLayout();
            this.panelContract.SuspendLayout();
            this.panelListContract.SuspendLayout();
            this.panelCreateContract.SuspendLayout();
            this.paymentContainer.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.panelListPayment.SuspendLayout();
            this.panelUpdatePayment.SuspendLayout();
            this.taskContainer.SuspendLayout();
            this.panelTask.SuspendLayout();
            this.panelListTask.SuspendLayout();
            this.panelCreateTask.SuspendLayout();
            this.listUserContainer.SuspendLayout();
            this.addUserContainer.SuspendLayout();
            this.createUserContainer.SuspendLayout();
            this.commissionContainer.SuspendLayout();
            this.dateCommissionContainer.SuspendLayout();
            this.supportContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // contractTimer
            // 
            this.contractTimer.Interval = 1;
            this.contractTimer.Tick += new System.EventHandler(this.contractTimer_Tick);
            // 
            // paymentTimer
            // 
            this.paymentTimer.Interval = 5;
            this.paymentTimer.Tick += new System.EventHandler(this.paymentTimer_Tick);
            // 
            // taskTimer
            // 
            this.taskTimer.Interval = 5;
            this.taskTimer.Tick += new System.EventHandler(this.taskTimer_Tick);
            // 
            // controlBox
            // 
            this.controlBox.BackColor = System.Drawing.Color.Transparent;
            this.controlBox.Controls.Add(this.btnExit);
            this.controlBox.Controls.Add(this.btnMinimize);
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBox.Location = new System.Drawing.Point(0, 0);
            this.controlBox.Margin = new System.Windows.Forms.Padding(0);
            this.controlBox.Name = "controlBox";
            this.controlBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.controlBox.Size = new System.Drawing.Size(1600, 30);
            this.controlBox.TabIndex = 0;
            this.controlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlBox_MouseDown);
            this.controlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlBox_MouseMove);
            this.controlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlBox_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::CNPM_FINAL.Properties.Resources.x_icon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(1565, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnExit.Size = new System.Drawing.Size(35, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::CNPM_FINAL.Properties.Resources.minimize_icon;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Location = new System.Drawing.Point(1515, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // headerBar
            // 
            this.headerBar.Controls.Add(this.panelUser);
            this.headerBar.Controls.Add(this.logoApp);
            this.headerBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBar.Location = new System.Drawing.Point(0, 30);
            this.headerBar.Margin = new System.Windows.Forms.Padding(0);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new System.Drawing.Size(1600, 100);
            this.headerBar.TabIndex = 0;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Transparent;
            this.panelUser.Controls.Add(this.panelLanguage);
            this.panelUser.Controls.Add(this.panelSetting);
            this.panelUser.Controls.Add(this.flowLayoutPanelAvatar);
            this.panelUser.Controls.Add(this.lbName);
            this.panelUser.Controls.Add(this.lbRole);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUser.Location = new System.Drawing.Point(850, 0);
            this.panelUser.Margin = new System.Windows.Forms.Padding(0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelUser.Size = new System.Drawing.Size(750, 100);
            this.panelUser.TabIndex = 0;
            // 
            // panelLanguage
            // 
            this.panelLanguage.Controls.Add(this.borderPanelLanguage);
            this.panelLanguage.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLanguage.Location = new System.Drawing.Point(200, 10);
            this.panelLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.panelLanguage.Name = "panelLanguage";
            this.panelLanguage.Padding = new System.Windows.Forms.Padding(0, 40, 2, 0);
            this.panelLanguage.Size = new System.Drawing.Size(200, 90);
            this.panelLanguage.TabIndex = 0;
            // 
            // borderPanelLanguage
            // 
            this.borderPanelLanguage.BackgroundColor = System.Drawing.Color.Transparent;
            this.borderPanelLanguage.BorderColor = System.Drawing.Color.Transparent;
            this.borderPanelLanguage.BorderRadius = 10;
            this.borderPanelLanguage.BorderSize = 1;
            this.borderPanelLanguage.Controls.Add(this.btnEnglish);
            this.borderPanelLanguage.Controls.Add(this.btnVietnamese);
            this.borderPanelLanguage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderPanelLanguage.Location = new System.Drawing.Point(0, 30);
            this.borderPanelLanguage.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.borderPanelLanguage.Name = "borderPanelLanguage";
            this.borderPanelLanguage.Size = new System.Drawing.Size(198, 60);
            this.borderPanelLanguage.TabIndex = 0;
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.Transparent;
            this.btnEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnglish.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnglish.FlatAppearance.BorderSize = 0;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnglish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.Color.Black;
            this.btnEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnglish.Location = new System.Drawing.Point(0, 30);
            this.btnEnglish.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEnglish.Size = new System.Drawing.Size(198, 30);
            this.btnEnglish.TabIndex = 0;
            this.btnEnglish.Text = "English";
            this.btnEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnglish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnglish.UseVisualStyleBackColor = false;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnVietnamese
            // 
            this.btnVietnamese.BackColor = System.Drawing.Color.Transparent;
            this.btnVietnamese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVietnamese.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVietnamese.FlatAppearance.BorderSize = 0;
            this.btnVietnamese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVietnamese.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVietnamese.ForeColor = System.Drawing.Color.Black;
            this.btnVietnamese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVietnamese.Location = new System.Drawing.Point(0, 0);
            this.btnVietnamese.Margin = new System.Windows.Forms.Padding(0);
            this.btnVietnamese.Name = "btnVietnamese";
            this.btnVietnamese.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVietnamese.Size = new System.Drawing.Size(198, 30);
            this.btnVietnamese.TabIndex = 0;
            this.btnVietnamese.Text = "Tiếng Việt";
            this.btnVietnamese.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVietnamese.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVietnamese.UseVisualStyleBackColor = false;
            this.btnVietnamese.Click += new System.EventHandler(this.btnVietnamese_Click);
            // 
            // panelSetting
            // 
            this.panelSetting.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelSetting.BorderColor = System.Drawing.Color.Transparent;
            this.panelSetting.BorderRadius = 10;
            this.panelSetting.BorderSize = 1;
            this.panelSetting.Controls.Add(this.btnLogout);
            this.panelSetting.Controls.Add(this.btnLanguage);
            this.panelSetting.Controls.Add(this.btnUserInfo);
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSetting.Location = new System.Drawing.Point(400, 10);
            this.panelSetting.Margin = new System.Windows.Forms.Padding(0);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(250, 90);
            this.panelSetting.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 60);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 30);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.Transparent;
            this.btnLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.ForeColor = System.Drawing.Color.Black;
            this.btnLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLanguage.Location = new System.Drawing.Point(0, 30);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLanguage.Size = new System.Drawing.Size(250, 30);
            this.btnLanguage.TabIndex = 0;
            this.btnLanguage.Text = "Ngôn ngữ";
            this.btnLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLanguage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserInfo.FlatAppearance.BorderSize = 0;
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.ForeColor = System.Drawing.Color.Black;
            this.btnUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserInfo.Location = new System.Drawing.Point(0, 0);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUserInfo.Size = new System.Drawing.Size(250, 30);
            this.btnUserInfo.TabIndex = 0;
            this.btnUserInfo.Text = "Thông tin cá nhân";
            this.btnUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserInfo.UseVisualStyleBackColor = false;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // flowLayoutPanelAvatar
            // 
            this.flowLayoutPanelAvatar.Controls.Add(this.logoUser);
            this.flowLayoutPanelAvatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelAvatar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAvatar.Location = new System.Drawing.Point(650, 10);
            this.flowLayoutPanelAvatar.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.flowLayoutPanelAvatar.Name = "flowLayoutPanelAvatar";
            this.flowLayoutPanelAvatar.Size = new System.Drawing.Size(100, 90);
            this.flowLayoutPanelAvatar.TabIndex = 0;
            // 
            // logoUser
            // 
            this.logoUser.BackColor = System.Drawing.Color.White;
            this.logoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoUser.BorderColor = System.Drawing.Color.White;
            this.logoUser.BorderRadius = 0;
            this.logoUser.BorderSize = 0;
            this.logoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoUser.Image = global::CNPM_FINAL.Properties.Resources.defaultAvatar;
            this.logoUser.Location = new System.Drawing.Point(0, 5);
            this.logoUser.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.logoUser.Name = "logoUser";
            this.logoUser.Size = new System.Drawing.Size(70, 70);
            this.logoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoUser.TabIndex = 2;
            this.logoUser.TabStop = false;
            this.logoUser.Click += new System.EventHandler(this.logoUser_Click);
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(220, 50);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbName.Size = new System.Drawing.Size(420, 30);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Phạm Hữu Trường";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRole
            // 
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.White;
            this.lbRole.Location = new System.Drawing.Point(220, 15);
            this.lbRole.Margin = new System.Windows.Forms.Padding(0);
            this.lbRole.Name = "lbRole";
            this.lbRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbRole.Size = new System.Drawing.Size(420, 30);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "Người dùng";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoApp
            // 
            this.logoApp.BackColor = System.Drawing.Color.Transparent;
            this.logoApp.BackgroundImage = global::CNPM_FINAL.Properties.Resources.logoApp;
            this.logoApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoApp.Location = new System.Drawing.Point(0, 0);
            this.logoApp.Margin = new System.Windows.Forms.Padding(0);
            this.logoApp.Name = "logoApp";
            this.logoApp.Size = new System.Drawing.Size(100, 100);
            this.logoApp.TabIndex = 0;
            this.logoApp.TabStop = false;
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.homeContainer);
            this.sidebar.Controls.Add(this.contractContainer);
            this.sidebar.Controls.Add(this.paymentContainer);
            this.sidebar.Controls.Add(this.taskContainer);
            this.sidebar.Controls.Add(this.listUserContainer);
            this.sidebar.Controls.Add(this.addUserContainer);
            this.sidebar.Controls.Add(this.commissionContainer);
            this.sidebar.Controls.Add(this.dateCommissionContainer);
            this.sidebar.Controls.Add(this.supportContainer);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 130);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(400, 770);
            this.sidebar.TabIndex = 4;
            // 
            // homeContainer
            // 
            this.homeContainer.BackColor = System.Drawing.Color.Transparent;
            this.homeContainer.Controls.Add(this.btnHome);
            this.homeContainer.Location = new System.Drawing.Point(0, 0);
            this.homeContainer.Margin = new System.Windows.Forms.Padding(0);
            this.homeContainer.Name = "homeContainer";
            this.homeContainer.Size = new System.Drawing.Size(400, 50);
            this.homeContainer.TabIndex = 9;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::CNPM_FINAL.Properties.Resources.TrangChu_logo_24x24;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(400, 50);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "     Báo Cáo Doanh Thu";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // contractContainer
            // 
            this.contractContainer.BackColor = System.Drawing.Color.Transparent;
            this.contractContainer.Controls.Add(this.panelContract);
            this.contractContainer.Controls.Add(this.panelListContract);
            this.contractContainer.Controls.Add(this.panelCreateContract);
            this.contractContainer.Location = new System.Drawing.Point(0, 50);
            this.contractContainer.Margin = new System.Windows.Forms.Padding(0);
            this.contractContainer.Name = "contractContainer";
            this.contractContainer.Size = new System.Drawing.Size(400, 150);
            this.contractContainer.TabIndex = 0;
            // 
            // panelContract
            // 
            this.panelContract.Controls.Add(this.btnContract);
            this.panelContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelContract.Location = new System.Drawing.Point(0, 0);
            this.panelContract.Margin = new System.Windows.Forms.Padding(0);
            this.panelContract.Name = "panelContract";
            this.panelContract.Size = new System.Drawing.Size(400, 50);
            this.panelContract.TabIndex = 0;
            // 
            // btnContract
            // 
            this.btnContract.BackColor = System.Drawing.Color.Transparent;
            this.btnContract.FlatAppearance.BorderSize = 0;
            this.btnContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContract.ForeColor = System.Drawing.Color.White;
            this.btnContract.Image = global::CNPM_FINAL.Properties.Resources.HopDongVaDuAn_logo_24x24;
            this.btnContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.Location = new System.Drawing.Point(0, 0);
            this.btnContract.Margin = new System.Windows.Forms.Padding(0);
            this.btnContract.Name = "btnContract";
            this.btnContract.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnContract.Size = new System.Drawing.Size(400, 50);
            this.btnContract.TabIndex = 0;
            this.btnContract.Text = "     Hợp Đồng";
            this.btnContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContract.UseVisualStyleBackColor = false;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // panelListContract
            // 
            this.panelListContract.Controls.Add(this.btnListContract);
            this.panelListContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelListContract.Location = new System.Drawing.Point(0, 50);
            this.panelListContract.Margin = new System.Windows.Forms.Padding(0);
            this.panelListContract.Name = "panelListContract";
            this.panelListContract.Size = new System.Drawing.Size(400, 50);
            this.panelListContract.TabIndex = 0;
            // 
            // btnListContract
            // 
            this.btnListContract.BackColor = System.Drawing.Color.Transparent;
            this.btnListContract.FlatAppearance.BorderSize = 0;
            this.btnListContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListContract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListContract.ForeColor = System.Drawing.Color.White;
            this.btnListContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListContract.Location = new System.Drawing.Point(0, 0);
            this.btnListContract.Margin = new System.Windows.Forms.Padding(0);
            this.btnListContract.Name = "btnListContract";
            this.btnListContract.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnListContract.Size = new System.Drawing.Size(400, 50);
            this.btnListContract.TabIndex = 0;
            this.btnListContract.Text = "          Xem Các Hợp Đồng";
            this.btnListContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListContract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListContract.UseVisualStyleBackColor = false;
            this.btnListContract.Click += new System.EventHandler(this.btnListContract_Click);
            // 
            // panelCreateContract
            // 
            this.panelCreateContract.Controls.Add(this.btnCreateContract);
            this.panelCreateContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCreateContract.Location = new System.Drawing.Point(0, 100);
            this.panelCreateContract.Margin = new System.Windows.Forms.Padding(0);
            this.panelCreateContract.Name = "panelCreateContract";
            this.panelCreateContract.Size = new System.Drawing.Size(400, 50);
            this.panelCreateContract.TabIndex = 0;
            // 
            // btnCreateContract
            // 
            this.btnCreateContract.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateContract.FlatAppearance.BorderSize = 0;
            this.btnCreateContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateContract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateContract.ForeColor = System.Drawing.Color.White;
            this.btnCreateContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateContract.Location = new System.Drawing.Point(0, 0);
            this.btnCreateContract.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateContract.Name = "btnCreateContract";
            this.btnCreateContract.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCreateContract.Size = new System.Drawing.Size(400, 50);
            this.btnCreateContract.TabIndex = 0;
            this.btnCreateContract.Text = "          Tạo Hợp Đồng";
            this.btnCreateContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateContract.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateContract.UseVisualStyleBackColor = false;
            this.btnCreateContract.Click += new System.EventHandler(this.btnCreateContract_Click);
            // 
            // paymentContainer
            // 
            this.paymentContainer.BackColor = System.Drawing.Color.Transparent;
            this.paymentContainer.Controls.Add(this.panelPayment);
            this.paymentContainer.Controls.Add(this.panelListPayment);
            this.paymentContainer.Controls.Add(this.panelUpdatePayment);
            this.paymentContainer.Location = new System.Drawing.Point(0, 200);
            this.paymentContainer.Margin = new System.Windows.Forms.Padding(0);
            this.paymentContainer.Name = "paymentContainer";
            this.paymentContainer.Size = new System.Drawing.Size(400, 150);
            this.paymentContainer.TabIndex = 0;
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.btnPayment);
            this.panelPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPayment.Location = new System.Drawing.Point(0, 0);
            this.panelPayment.Margin = new System.Windows.Forms.Padding(0);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(400, 50);
            this.panelPayment.TabIndex = 0;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Image = global::CNPM_FINAL.Properties.Resources.TienDoThanhToan_24x24;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(0, 0);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPayment.Size = new System.Drawing.Size(400, 50);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "     Tiến Độ Thanh Toán";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // panelListPayment
            // 
            this.panelListPayment.Controls.Add(this.btnListPayment);
            this.panelListPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelListPayment.Location = new System.Drawing.Point(0, 50);
            this.panelListPayment.Margin = new System.Windows.Forms.Padding(0);
            this.panelListPayment.Name = "panelListPayment";
            this.panelListPayment.Size = new System.Drawing.Size(400, 50);
            this.panelListPayment.TabIndex = 6;
            // 
            // btnListPayment
            // 
            this.btnListPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnListPayment.FlatAppearance.BorderSize = 0;
            this.btnListPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPayment.ForeColor = System.Drawing.Color.White;
            this.btnListPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListPayment.Location = new System.Drawing.Point(0, 0);
            this.btnListPayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnListPayment.Name = "btnListPayment";
            this.btnListPayment.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnListPayment.Size = new System.Drawing.Size(400, 50);
            this.btnListPayment.TabIndex = 0;
            this.btnListPayment.Text = "          Xem Các Giai Đoạn";
            this.btnListPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListPayment.UseVisualStyleBackColor = false;
            this.btnListPayment.Click += new System.EventHandler(this.btnListPayment_Click);
            // 
            // panelUpdatePayment
            // 
            this.panelUpdatePayment.Controls.Add(this.btnCreatePayment);
            this.panelUpdatePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelUpdatePayment.Location = new System.Drawing.Point(0, 100);
            this.panelUpdatePayment.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdatePayment.Name = "panelUpdatePayment";
            this.panelUpdatePayment.Size = new System.Drawing.Size(400, 50);
            this.panelUpdatePayment.TabIndex = 0;
            // 
            // btnCreatePayment
            // 
            this.btnCreatePayment.BackColor = System.Drawing.Color.Transparent;
            this.btnCreatePayment.FlatAppearance.BorderSize = 0;
            this.btnCreatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePayment.ForeColor = System.Drawing.Color.White;
            this.btnCreatePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatePayment.Location = new System.Drawing.Point(0, 0);
            this.btnCreatePayment.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreatePayment.Name = "btnCreatePayment";
            this.btnCreatePayment.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCreatePayment.Size = new System.Drawing.Size(400, 50);
            this.btnCreatePayment.TabIndex = 0;
            this.btnCreatePayment.Text = "          Cập Nhật Thanh Toán";
            this.btnCreatePayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreatePayment.UseVisualStyleBackColor = false;
            this.btnCreatePayment.Click += new System.EventHandler(this.btnCreatePayment_Click);
            // 
            // taskContainer
            // 
            this.taskContainer.BackColor = System.Drawing.Color.Transparent;
            this.taskContainer.Controls.Add(this.panelTask);
            this.taskContainer.Controls.Add(this.panelListTask);
            this.taskContainer.Controls.Add(this.panelCreateTask);
            this.taskContainer.Location = new System.Drawing.Point(0, 350);
            this.taskContainer.Margin = new System.Windows.Forms.Padding(0);
            this.taskContainer.Name = "taskContainer";
            this.taskContainer.Size = new System.Drawing.Size(400, 150);
            this.taskContainer.TabIndex = 0;
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.btnTask);
            this.panelTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTask.Location = new System.Drawing.Point(0, 0);
            this.panelTask.Margin = new System.Windows.Forms.Padding(0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(400, 50);
            this.panelTask.TabIndex = 0;
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.Transparent;
            this.btnTask.FlatAppearance.BorderSize = 0;
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.Color.White;
            this.btnTask.Image = global::CNPM_FINAL.Properties.Resources.TienDoCongViec_logo_24x24;
            this.btnTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.Location = new System.Drawing.Point(0, 0);
            this.btnTask.Margin = new System.Windows.Forms.Padding(0);
            this.btnTask.Name = "btnTask";
            this.btnTask.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTask.Size = new System.Drawing.Size(400, 50);
            this.btnTask.TabIndex = 0;
            this.btnTask.Text = "     Tiến Độ Công Việc";
            this.btnTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // panelListTask
            // 
            this.panelListTask.Controls.Add(this.btnListTask);
            this.panelListTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelListTask.Location = new System.Drawing.Point(0, 50);
            this.panelListTask.Margin = new System.Windows.Forms.Padding(0);
            this.panelListTask.Name = "panelListTask";
            this.panelListTask.Size = new System.Drawing.Size(400, 50);
            this.panelListTask.TabIndex = 0;
            // 
            // btnListTask
            // 
            this.btnListTask.BackColor = System.Drawing.Color.Transparent;
            this.btnListTask.FlatAppearance.BorderSize = 0;
            this.btnListTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListTask.ForeColor = System.Drawing.Color.White;
            this.btnListTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListTask.Location = new System.Drawing.Point(0, 0);
            this.btnListTask.Margin = new System.Windows.Forms.Padding(0);
            this.btnListTask.Name = "btnListTask";
            this.btnListTask.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnListTask.Size = new System.Drawing.Size(400, 50);
            this.btnListTask.TabIndex = 0;
            this.btnListTask.Text = "          Xem Các Tiến Độ";
            this.btnListTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListTask.UseVisualStyleBackColor = false;
            this.btnListTask.Click += new System.EventHandler(this.btnListTask_Click);
            // 
            // panelCreateTask
            // 
            this.panelCreateTask.Controls.Add(this.btnCreateTask);
            this.panelCreateTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCreateTask.Location = new System.Drawing.Point(0, 100);
            this.panelCreateTask.Margin = new System.Windows.Forms.Padding(0);
            this.panelCreateTask.Name = "panelCreateTask";
            this.panelCreateTask.Size = new System.Drawing.Size(400, 50);
            this.panelCreateTask.TabIndex = 0;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateTask.FlatAppearance.BorderSize = 0;
            this.btnCreateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTask.ForeColor = System.Drawing.Color.White;
            this.btnCreateTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateTask.Location = new System.Drawing.Point(0, 0);
            this.btnCreateTask.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCreateTask.Size = new System.Drawing.Size(400, 50);
            this.btnCreateTask.TabIndex = 0;
            this.btnCreateTask.Text = "          Tạo Công Việc";
            this.btnCreateTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateTask.UseVisualStyleBackColor = false;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // listUserContainer
            // 
            this.listUserContainer.BackColor = System.Drawing.Color.Transparent;
            this.listUserContainer.Controls.Add(this.btnListUser);
            this.listUserContainer.Location = new System.Drawing.Point(0, 500);
            this.listUserContainer.Margin = new System.Windows.Forms.Padding(0);
            this.listUserContainer.Name = "listUserContainer";
            this.listUserContainer.Size = new System.Drawing.Size(400, 50);
            this.listUserContainer.TabIndex = 7;
            // 
            // btnListUser
            // 
            this.btnListUser.BackColor = System.Drawing.Color.Transparent;
            this.btnListUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListUser.FlatAppearance.BorderSize = 0;
            this.btnListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUser.ForeColor = System.Drawing.Color.White;
            this.btnListUser.Image = global::CNPM_FINAL.Properties.Resources.logo_chinhSuaThongTinNguoiDung_24x24;
            this.btnListUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUser.Location = new System.Drawing.Point(0, 0);
            this.btnListUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnListUser.Size = new System.Drawing.Size(400, 50);
            this.btnListUser.TabIndex = 0;
            this.btnListUser.Text = "     Danh sách người dùng";
            this.btnListUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListUser.UseVisualStyleBackColor = false;
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // addUserContainer
            // 
            this.addUserContainer.BackColor = System.Drawing.Color.Transparent;
            this.addUserContainer.Controls.Add(this.createUserContainer);
            this.addUserContainer.Location = new System.Drawing.Point(0, 550);
            this.addUserContainer.Margin = new System.Windows.Forms.Padding(0);
            this.addUserContainer.Name = "addUserContainer";
            this.addUserContainer.Size = new System.Drawing.Size(400, 50);
            this.addUserContainer.TabIndex = 6;
            // 
            // createUserContainer
            // 
            this.createUserContainer.Controls.Add(this.btnAddUser);
            this.createUserContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createUserContainer.Location = new System.Drawing.Point(0, 0);
            this.createUserContainer.Margin = new System.Windows.Forms.Padding(0);
            this.createUserContainer.Name = "createUserContainer";
            this.createUserContainer.Size = new System.Drawing.Size(400, 50);
            this.createUserContainer.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::CNPM_FINAL.Properties.Resources.user_plus_icon_white_24x24;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(0, 0);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(400, 50);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "     Thêm người dùng";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // commissionContainer
            // 
            this.commissionContainer.BackColor = System.Drawing.Color.Transparent;
            this.commissionContainer.Controls.Add(this.btnCommission);
            this.commissionContainer.Location = new System.Drawing.Point(0, 600);
            this.commissionContainer.Margin = new System.Windows.Forms.Padding(0);
            this.commissionContainer.Name = "commissionContainer";
            this.commissionContainer.Size = new System.Drawing.Size(400, 50);
            this.commissionContainer.TabIndex = 0;
            // 
            // btnCommission
            // 
            this.btnCommission.BackColor = System.Drawing.Color.Transparent;
            this.btnCommission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommission.FlatAppearance.BorderSize = 0;
            this.btnCommission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommission.ForeColor = System.Drawing.Color.White;
            this.btnCommission.Image = global::CNPM_FINAL.Properties.Resources.BaoCaoVaThongKe_logo__24x24;
            this.btnCommission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommission.Location = new System.Drawing.Point(0, 0);
            this.btnCommission.Margin = new System.Windows.Forms.Padding(0);
            this.btnCommission.Name = "btnCommission";
            this.btnCommission.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCommission.Size = new System.Drawing.Size(400, 50);
            this.btnCommission.TabIndex = 0;
            this.btnCommission.Text = "     Báo Cáo Hoa Hồng";
            this.btnCommission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommission.UseVisualStyleBackColor = false;
            this.btnCommission.Click += new System.EventHandler(this.btnCommission_Click);
            // 
            // dateCommissionContainer
            // 
            this.dateCommissionContainer.BackColor = System.Drawing.Color.Transparent;
            this.dateCommissionContainer.Controls.Add(this.btnDateCommission);
            this.dateCommissionContainer.Location = new System.Drawing.Point(0, 650);
            this.dateCommissionContainer.Margin = new System.Windows.Forms.Padding(0);
            this.dateCommissionContainer.Name = "dateCommissionContainer";
            this.dateCommissionContainer.Size = new System.Drawing.Size(400, 50);
            this.dateCommissionContainer.TabIndex = 6;
            // 
            // btnDateCommission
            // 
            this.btnDateCommission.BackColor = System.Drawing.Color.Transparent;
            this.btnDateCommission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDateCommission.FlatAppearance.BorderSize = 0;
            this.btnDateCommission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateCommission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateCommission.ForeColor = System.Drawing.Color.White;
            this.btnDateCommission.Image = global::CNPM_FINAL.Properties.Resources.BaoCaoVaThongKe_logo__24x24;
            this.btnDateCommission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDateCommission.Location = new System.Drawing.Point(0, 0);
            this.btnDateCommission.Margin = new System.Windows.Forms.Padding(0);
            this.btnDateCommission.Name = "btnDateCommission";
            this.btnDateCommission.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDateCommission.Size = new System.Drawing.Size(400, 50);
            this.btnDateCommission.TabIndex = 0;
            this.btnDateCommission.Text = "     Ngày hoa hồng";
            this.btnDateCommission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDateCommission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDateCommission.UseVisualStyleBackColor = false;
            this.btnDateCommission.Click += new System.EventHandler(this.btnDateCommission_Click);
            // 
            // supportContainer
            // 
            this.supportContainer.BackColor = System.Drawing.Color.Transparent;
            this.supportContainer.Controls.Add(this.btnSupport);
            this.supportContainer.Location = new System.Drawing.Point(0, 700);
            this.supportContainer.Margin = new System.Windows.Forms.Padding(0);
            this.supportContainer.Name = "supportContainer";
            this.supportContainer.Size = new System.Drawing.Size(400, 50);
            this.supportContainer.TabIndex = 8;
            // 
            // btnSupport
            // 
            this.btnSupport.BackColor = System.Drawing.Color.Transparent;
            this.btnSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupport.FlatAppearance.BorderSize = 0;
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupport.ForeColor = System.Drawing.Color.White;
            this.btnSupport.Image = global::CNPM_FINAL.Properties.Resources.help_info_mark_question_support_icon;
            this.btnSupport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupport.Location = new System.Drawing.Point(0, 0);
            this.btnSupport.Margin = new System.Windows.Forms.Padding(0);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSupport.Size = new System.Drawing.Size(400, 50);
            this.btnSupport.TabIndex = 0;
            this.btnSupport.Text = "     Trợ giúp";
            this.btnSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupport.UseVisualStyleBackColor = false;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // lbCopyRight
            // 
            this.lbCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lbCopyRight.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopyRight.ForeColor = System.Drawing.Color.White;
            this.lbCopyRight.Location = new System.Drawing.Point(0, 880);
            this.lbCopyRight.Margin = new System.Windows.Forms.Padding(0);
            this.lbCopyRight.Name = "lbCopyRight";
            this.lbCopyRight.Size = new System.Drawing.Size(400, 25);
            this.lbCopyRight.TabIndex = 0;
            this.lbCopyRight.Text = "Copyright: ©2024 STAR. All rights reserved.";
            this.lbCopyRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.ControlBox = false;
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.lbCopyRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainGUI";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.controlBox.ResumeLayout(false);
            this.headerBar.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelLanguage.ResumeLayout(false);
            this.borderPanelLanguage.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            this.flowLayoutPanelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.homeContainer.ResumeLayout(false);
            this.contractContainer.ResumeLayout(false);
            this.panelContract.ResumeLayout(false);
            this.panelListContract.ResumeLayout(false);
            this.panelCreateContract.ResumeLayout(false);
            this.paymentContainer.ResumeLayout(false);
            this.panelPayment.ResumeLayout(false);
            this.panelListPayment.ResumeLayout(false);
            this.panelUpdatePayment.ResumeLayout(false);
            this.taskContainer.ResumeLayout(false);
            this.panelTask.ResumeLayout(false);
            this.panelListTask.ResumeLayout(false);
            this.panelCreateTask.ResumeLayout(false);
            this.listUserContainer.ResumeLayout(false);
            this.addUserContainer.ResumeLayout(false);
            this.createUserContainer.ResumeLayout(false);
            this.commissionContainer.ResumeLayout(false);
            this.dateCommissionContainer.ResumeLayout(false);
            this.supportContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer contractTimer;
        private System.Windows.Forms.Timer paymentTimer;
        private System.Windows.Forms.Timer taskTimer;
        private System.Windows.Forms.FlowLayoutPanel controlBox;
        private System.Windows.Forms.FlowLayoutPanel btnExit;
        private System.Windows.Forms.FlowLayoutPanel btnMinimize;
        private System.Windows.Forms.Panel headerBar;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbRole;
        private CNPM_FINAL.GUI.CustomControl.CircularPictureBox logoUser;
        private System.Windows.Forms.PictureBox logoApp;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.FlowLayoutPanel taskContainer;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Panel panelCreateTask;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Panel panelListTask;
        private System.Windows.Forms.Button btnListTask;
        private System.Windows.Forms.FlowLayoutPanel paymentContainer;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.FlowLayoutPanel commissionContainer;
        private System.Windows.Forms.Button btnCommission;
        private System.Windows.Forms.Panel panelListContract;
        private System.Windows.Forms.Button btnListContract;
        private System.Windows.Forms.Panel panelCreateContract;
        private System.Windows.Forms.Button btnCreateContract;
        private System.Windows.Forms.Panel panelContract;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.FlowLayoutPanel contractContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAvatar;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel panelSetting;
        private CNPM_FINAL.GUI.CustomControl.BorderPanel borderPanelLanguage;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.Panel panelListPayment;
        private System.Windows.Forms.Button btnListPayment;
        private System.Windows.Forms.Panel panelUpdatePayment;
        private System.Windows.Forms.Button btnCreatePayment;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnVietnamese;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.FlowLayoutPanel addUserContainer;
        private System.Windows.Forms.Panel createUserContainer;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.FlowLayoutPanel listUserContainer;
        private System.Windows.Forms.Button btnListUser;
        private System.Windows.Forms.FlowLayoutPanel supportContainer;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.FlowLayoutPanel homeContainer;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel dateCommissionContainer;
        private System.Windows.Forms.Button btnDateCommission;
        private System.Windows.Forms.Label lbCopyRight;
    }
}