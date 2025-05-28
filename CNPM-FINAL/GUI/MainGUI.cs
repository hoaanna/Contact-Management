using CNPM_FINAL.Context;
using CNPM_FINAL.Event;
using CNPM_FINAL.GUI.SubItem.Commission;
using CNPM_FINAL.GUI.SubItem.Contract;
using CNPM_FINAL.GUI.SubItem.Payment;
using CNPM_FINAL.GUI.SubItem.Report;
using CNPM_FINAL.GUI.SubItem.Support;
using CNPM_FINAL.GUI.SubItem.Task;
using CNPM_FINAL.GUI.SubItem.User;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace CNPM_FINAL.GUI
{
    public partial class MainGUI : Form
    {
        #region properties
        private static bool contractExpand = true;
        private static bool jobExpand = true;
        private static bool paymentExpand = true;

        private CultureInfo cultureInfo;
        private ResourceManager resourceManager;

        private static int MAX_HEIGHT_CONTRACT = 120;
        private static int MAX_HEIGHT_JOB = 120;
        private static int MAX_HEIGHT_PAYMENT = 120;

        private Form createContractForm = null;
        private Form createTaskForm = null;
        private Form createPaymentForm = null;
        private Form createUserForm = null;
        private Form dashboardForm = null;

        private Form listTaskForm = null;
        private Form listCommissionForm = null;
        private Form listPaymentForm = null;
        private Form listContractForm = null;
        private Form listUserForm = null;

        private Form dateCommissionForm = null;
        private Form supportForm = null;
        private Form infoUserForm = null;

        private ContactGUI contactGUI = null;
        private ChatbotGUI chatbotGUI = null;
        private ListTaskDetailGUI listTaskDetailGUI = null;

        private UpdateContractGUI updateContractForm = null;
        private UpdateTaskGUI updateTaskForm = null;
        private UpdatePaymentGUI updatePaymentForm = null;
        private UpdateUserGUI updateUserForm = null;
        private UpdatePermissionGUI updatePermissionForm = null;

        private StatusReportGUI statusReportGUI = null;
        private RevenueReportGUI revenueReportGUI = null;
        private QuantityReportGUI quantityReportGUI = null;
        private PaymentReportGUI paymentReportGUI = null;


        private bool inUpdateForm = false;

        public event EventHandler LanguageChanged;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private readonly Dictionary<string, string> roleVi = new Dictionary<string, string>
        {
            { "Director", "Giám đốc" },
            { "Sale", "Nhân viên bán hàng" },
            { "Admin", "Quản trị viên" },
            { "Accountant", "Kế toán" }
        };
        #endregion
        public MainGUI()
        {
            InitializeComponent();
            InitColor();
            InitHoverBackColorButton();
            InitMaxSizeContainer();
            InitTextContent();
        }

        #region methods
        private Color rgba(int r, int g, int b, double a) => Color.FromArgb((int)(a * 255), r, g, b);

        private string GetLocalizedString(string key) => resourceManager.GetString(key, cultureInfo);

        private void HandleExpandCollapse(Timer timer, ref bool expandFlag, Control control, int changeAmount, int minHeigh, int maxHeigh)
        {
            if (!expandFlag)
            {
                if (control.Height <= maxHeigh)
                {
                    control.Height += changeAmount;
                    return;
                }
                control.Height = maxHeigh;
                expandFlag = true;
                timer.Stop();

            }
            else
            {
                if (control.Height >= minHeigh)
                {
                    control.Height -= changeAmount;
                    return;
                }
                control.Height = minHeigh;
                expandFlag = false;
                timer.Stop();

            }

            control.Parent.PerformLayout();
        }

        private void ShowForm(ref Form form, Type formType)
        {
            if (inUpdateForm)
            {
                DialogResult result = MessageBox.Show(GetLocalizedString("confirmCancel"), "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                inUpdateForm = false;
            }

            if (form != null)
            {
                form.Activate();
                return;
            }

            form = (Form)Activator.CreateInstance(formType);
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void SetBackGround(Control control)
        {
            if (inUpdateForm)
                return;

            this.contractContainer.BackColor = this.taskContainer.BackColor
                = this.paymentContainer.BackColor = this.commissionContainer.BackColor
                = this.addUserContainer.BackColor = this.listUserContainer.BackColor
                = this.supportContainer.BackColor = this.homeContainer.BackColor
                = this.dateCommissionContainer.BackColor
                = Color.Transparent;
            control.BackColor = rgba(57, 82, 115, 0.75F);
        }
        #endregion

        #region init
        private void InitTextContent()
        {
            cultureInfo = new CultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.MAIN_GUI, typeof(ListCommissionGUI).Assembly);

            this.btnAddUser.Text = GetLocalizedString("btnCreateUser");
            this.btnCommission.Text = GetLocalizedString("btnCommission");
            this.btnContract.Text = GetLocalizedString("btnContract");
            this.btnCreateContract.Text = GetLocalizedString("btnCreateContract");
            this.btnCreatePayment.Text = GetLocalizedString("btnCreatePayment");
            this.btnCreateTask.Text = GetLocalizedString("btnCreateTask");
            this.btnLanguage.Text = GetLocalizedString("lnLanguage");
            this.btnListContract.Text = GetLocalizedString("btnListContract");
            this.btnListPayment.Text = GetLocalizedString("btnListStage");
            this.btnListTask.Text = GetLocalizedString("btnListTask");
            this.btnListUser.Text = GetLocalizedString("btnListUser");
            this.btnLogout.Text = GetLocalizedString("lbLogut");
            this.btnPayment.Text = GetLocalizedString("btnPaymentStage");
            this.btnHome.Text = GetLocalizedString("btnHome");
            this.btnSupport.Text = GetLocalizedString("btnSupport");
            this.btnTask.Text = GetLocalizedString("btnTaskProgress");
            this.btnUserInfo.Text = GetLocalizedString("lbInfo");
            this.btnDateCommission.Text = GetLocalizedString("btnDateCommission");

            this.lbRole.Text = SettingContext.Language == "vi" ? 
                roleVi[UserContext.GetRoleName()] : UserContext.GetRoleName();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (!UserContext.IsLoggedIn())
            {
                MessageBox.Show(GetLocalizedString("loginErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                LoginGUI loginForm = new LoginGUI();
                loginForm.Show();
                return;
            }

            this.homeContainer.Visible = this.contractContainer.Visible
                = this.taskContainer.Visible = this.dateCommissionContainer.Visible
                = this.paymentContainer.Visible = this.commissionContainer.Visible
                = this.addUserContainer.Visible = this.listUserContainer.Visible
                = false;

            if (string.Equals(UserContext.GetRoleName(), "Director", StringComparison.OrdinalIgnoreCase))
            {
                this.homeContainer.Visible = true;
                btnHome.PerformClick();
            }

            else if (string.Equals(UserContext.GetRoleName(), "Sale", StringComparison.OrdinalIgnoreCase))
            {
                this.contractContainer.Visible = this.taskContainer.Visible
                    = this.commissionContainer.Visible = true;
                btnListContract.PerformClick();
            }

            else if (string.Equals(UserContext.GetRoleName(), "Admin", StringComparison.OrdinalIgnoreCase))
            {
                this.addUserContainer.Visible = this.listUserContainer.Visible
                    = this.dateCommissionContainer.Visible = true;
                btnListUser.PerformClick();
            }

            else if (string.Equals(UserContext.GetRoleName(), "Accountant", StringComparison.OrdinalIgnoreCase))
            {
                this.paymentContainer.Visible = true;
                btnListPayment.PerformClick();
            }

            else
            {
                MessageBox.Show(GetLocalizedString("roleErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                LoginGUI loginForm = new LoginGUI();
                loginForm.Show();
                return;
            }

            foreach (string p in UserContext.GetPermissions())
            {
                if (p.Contains("Contract"))
                {
                    this.contractContainer.Visible = true;
                }
                else if (p.Contains("Task"))
                {
                    this.taskContainer.Visible = true;
                }
                else if (p.Contains("Payment"))
                {
                    this.paymentContainer.Visible = true;
                }
                else if (p.Equals("CommissionReport"))
                {
                    this.commissionContainer.Visible = true;
                }
                else if (p.Equals("BusinessReport"))
                {
                    this.homeContainer.Visible = true;
                }
            }
            this.lbName.Text = UserContext.GetName();

            this.panelSetting.Visible = this.panelLanguage.Visible = false;
            int startY = this.Height - this.lbCopyRight.Height;
            this.lbCopyRight.Location = new Point(0, startY);
            this.lbCopyRight.Width = this.sidebar.Width;
            this.lbCopyRight.BackColor = this.sidebar.BackColor;
            this.lbCopyRight.BringToFront();
        }

        private void InitMaxSizeContainer()
        {
            MAX_HEIGHT_CONTRACT = contractContainer.Height;
            MAX_HEIGHT_JOB = taskContainer.Height;
            MAX_HEIGHT_PAYMENT = paymentContainer.Height;
        }

        private void InitHoverBackColorButton()
        {
            this.btnContract.FlatAppearance.MouseOverBackColor = this.btnCreateContract.FlatAppearance.MouseOverBackColor
                = this.btnListContract.FlatAppearance.MouseOverBackColor = this.btnTask.FlatAppearance.MouseOverBackColor
                = this.btnCreateTask.FlatAppearance.MouseOverBackColor = this.btnListTask.FlatAppearance.MouseOverBackColor
                = this.btnCommission.FlatAppearance.MouseOverBackColor = this.btnPayment.FlatAppearance.MouseOverBackColor
                = this.btnCreatePayment.FlatAppearance.MouseOverBackColor = this.btnListPayment.FlatAppearance.MouseOverBackColor
                = this.btnAddUser.FlatAppearance.MouseOverBackColor = this.btnListUser.FlatAppearance.MouseOverBackColor
                = this.btnSupport.FlatAppearance.MouseOverBackColor = this.btnHome.FlatAppearance.MouseOverBackColor
                = this.btnDateCommission.FlatAppearance.MouseOverBackColor = rgba(57, 82, 115, 0.75F);
        }

        private void InitColor()
        {
            this.controlBox.BackColor = rgba(255, 255, 255, 1);
            this.headerBar.BackColor = rgba(46, 79, 123, 0.95);
            this.sidebar.BackColor = rgba(129, 151, 179, 0.8);
            this.borderPanelLanguage.BackColor = this.panelSetting.BackColor = rgba(200, 211, 226, 1);
        }
        #endregion

        #region controlBox
        private void controlBox_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void controlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void controlBox_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnMinimize_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region sidebar
        private void contractTimer_Tick(object sender, EventArgs e) => HandleExpandCollapse(contractTimer, ref contractExpand,
            contractContainer, 3, 50, MAX_HEIGHT_CONTRACT);
        private void btnContract_Click(object sender, EventArgs e)
        {
            if (!contractTimer.Enabled)
                contractTimer.Start();
        }

        private void paymentTimer_Tick(object sender, EventArgs e) => HandleExpandCollapse(paymentTimer, ref paymentExpand,
            paymentContainer, 3, 50, MAX_HEIGHT_PAYMENT);
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (!paymentTimer.Enabled)
                paymentTimer.Start();
        }

        private void taskTimer_Tick(object sender, EventArgs e) => HandleExpandCollapse(taskTimer, ref jobExpand,
            taskContainer, 3, 50, MAX_HEIGHT_JOB);
        private void btnTask_Click(object sender, EventArgs e)
        {
            if (!taskTimer.Enabled)
                taskTimer.Start();
        }
        #endregion

        #region button
        private void btnCreateContract_Click(object sender, EventArgs e)
        {
            if (!UserContext.GetPermissions().Contains("CREATE_Contract"))
            {
                MessageBox.Show(GetLocalizedString("permissionErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowForm(ref createContractForm, typeof(CreateContractGUI));
            SetBackGround(contractContainer);
        }

        private void btnListContract_Click(object sender, EventArgs e)
        {
            ShowForm(ref listContractForm, typeof(ListContractGUI));
            SetBackGround(contractContainer);
            if (!inUpdateForm && listContractForm is ListContractGUI contractForm)
            {
                contractForm.UpdateContractEvent -= ShowUpdateContract;
                contractForm.UpdateContractEvent += ShowUpdateContract;
            }
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            if (!UserContext.GetPermissions().Contains("CREATE_Task"))
            {
                MessageBox.Show(GetLocalizedString("permissionErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowForm(ref createTaskForm, typeof(CreateTaskGUI));
            SetBackGround(taskContainer);
        }

        private void btnListTask_Click(object sender, EventArgs e)
        {
            ShowForm(ref listTaskForm, typeof(ListTaskGUI));
            SetBackGround(taskContainer);
            if (!inUpdateForm && listTaskForm is ListTaskGUI taskForm)
            {
                taskForm.OpenTaskDetail -= ShowTaskDetail;
                taskForm.OpenTaskDetail += ShowTaskDetail;
            }
        }

        private void btnCommission_Click(object sender, EventArgs e)
        {
            ShowForm(ref listCommissionForm, typeof(ListCommissionGUI));
            SetBackGround(commissionContainer);
        }

        private void btnListPayment_Click(object sender, EventArgs e)
        {
            ShowForm(ref listPaymentForm, typeof(ListPaymentGUI));
            SetBackGround(paymentContainer);
            if (!inUpdateForm && listPaymentForm is ListPaymentGUI paymentForm)
            {
                paymentForm.UpdatePaymentEvent -= ShowUpdatePayment;
                paymentForm.UpdatePaymentEvent += ShowUpdatePayment;
            }
        }

        private void btnCreatePayment_Click(object sender, EventArgs e)
        {
            if (!UserContext.GetPermissions().Contains("CREATE_Payment"))
            {
                MessageBox.Show(GetLocalizedString("permissionErr"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowForm(ref createPaymentForm, typeof(CreatePaymentGUI));
            SetBackGround(paymentContainer);
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            ShowForm(ref createUserForm, typeof(CreateUserGUI));
            SetBackGround(addUserContainer);
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            ShowForm(ref listUserForm, typeof(ListUserGUI));
            SetBackGround(listUserContainer);
            if (!inUpdateForm && listUserForm is ListUserGUI userForm)
            {
                userForm.UpdateUserEvent -= ShowUpdateUser;
                userForm.UpdateUserEvent += ShowUpdateUser;

                userForm.UpdatePermissionEvent -= ShowUpdatePermission;
                userForm.UpdatePermissionEvent += ShowUpdatePermission;
            }
        }

        private void logoUser_Click(object sender, EventArgs e)
        {
            this.panelSetting.Visible = !this.panelSetting.Visible;
            this.panelLanguage.Visible = false;
        }
        private void btnLanguage_Click(object sender, EventArgs e)
        {
            this.panelLanguage.Visible = !this.panelLanguage.Visible;
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            this.panelLanguage.Visible = this.panelSetting.Visible = false;
            ShowForm(ref infoUserForm, typeof(UserInfoGUI));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.panelLanguage.Visible = this.panelSetting.Visible = false;
            DialogResult result = MessageBox.Show(GetLocalizedString("confirmLogout"), "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserContext.ClearUserContext();
                this.Hide();
                LoginGUI loginForm = new LoginGUI();
                loginForm.Show();
            }
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            ShowForm(ref dashboardForm, typeof(DashboardGUI));
            SetBackGround(homeContainer);

            if (dashboardForm != null && dashboardForm is DashboardGUI dashboard)
            {
                dashboard.OpenStatusReport -= ShowStatusReport;
                dashboard.OpenStatusReport += ShowStatusReport;

                dashboard.OpenRevenueReport -= ShowRevenueReport;
                dashboard.OpenRevenueReport += ShowRevenueReport;

                dashboard.OpenQuantityReport -= ShowQuantityReport;
                dashboard.OpenQuantityReport += ShowQuantityReport;

                dashboard.OpenPaymentReport -= ShowPaymentReport;
                dashboard.OpenPaymentReport += ShowPaymentReport;
            }
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            ShowForm(ref supportForm, typeof(MainSupportGUI));
            SetBackGround(supportContainer);

            if (supportForm != null && supportForm is MainSupportGUI support)
            {
                support.OpenContact -= ShowContact;
                support.OpenContact += ShowContact;

                support.OpenChatbot -= ShowChatbot;
                support.OpenChatbot += ShowChatbot;
            }
        }

        private void btnDateCommission_Click(object sender, EventArgs e)
        {
            ShowForm(ref dateCommissionForm, typeof(DateCommissionGUI));
            SetBackGround(dateCommissionContainer);
        }
        #endregion

        #region update form event
        private void ShowUpdateContract(object sender, ContractEventArgs e)
        {
            inUpdateForm = true;
            updateContractForm = new UpdateContractGUI(e.contract);
            updateContractForm.OpenListGUI -= OpenListContract;
            updateContractForm.OpenListGUI += OpenListContract;
            updateContractForm.MdiParent = this;
            updateContractForm.Dock = DockStyle.Fill;
            updateContractForm.Show();

        }

        private void ShowUpdateTaskProgress(object sender, TaskEventArgs e)
        {
            inUpdateForm = true;
            updateTaskForm = new UpdateTaskGUI(e.task);
            updateTaskForm.OpenListGUI -= OpenListTask;
            updateTaskForm.OpenListGUI += OpenListTask;
            updateTaskForm.MdiParent = this;
            updateTaskForm.Dock = DockStyle.Fill;
            updateTaskForm.Show();
        }

        private void ShowTaskDetail(object sender, TaskDetailEventArgs e)
        {
            listTaskDetailGUI = new ListTaskDetailGUI(e.contractCode);
            listTaskDetailGUI.UpdateTaskEvent -= ShowUpdateTaskProgress;
            listTaskDetailGUI.UpdateTaskEvent += ShowUpdateTaskProgress;
            listTaskDetailGUI.MdiParent = this;
            listTaskDetailGUI.Dock = DockStyle.Fill;
            listTaskDetailGUI.Show();
        }

        private void ShowUpdatePayment(object sender, PaymentEventArgs e)
        {
            inUpdateForm = true;
            updatePaymentForm = new UpdatePaymentGUI(e.payment);
            updatePaymentForm.OpenListGUI -= OpenListPayment;
            updatePaymentForm.OpenListGUI += OpenListPayment;
            updatePaymentForm.MdiParent = this;
            updatePaymentForm.Dock = DockStyle.Fill;
            updatePaymentForm.Show();
        }

        private void ShowUpdateUser(object sender, UserEventArgs e)
        {
            inUpdateForm = true;
            updateUserForm = new UpdateUserGUI(e.user);
            updateUserForm.OpenListGUI -= OpenListUser;
            updateUserForm.OpenListGUI += OpenListUser;
            updateUserForm.MdiParent = this;
            updateUserForm.Dock = DockStyle.Fill;
            updateUserForm.Show();
        }

        private void ShowUpdatePermission(object sender, UserEventArgs e)
        {
            inUpdateForm = true;
            updatePermissionForm = new UpdatePermissionGUI(e.user);
            updatePermissionForm.OpenListGUI -= OpenListUser;
            updatePermissionForm.OpenListGUI += OpenListUser;
            updatePermissionForm.MdiParent = this;
            updatePermissionForm.Dock = DockStyle.Fill;
            updatePermissionForm.Show();
        }

        private void ShowStatusReport(object sender, EventArgs e)
        {
            statusReportGUI = new StatusReportGUI();
            statusReportGUI.MdiParent = this;
            statusReportGUI.Dock = DockStyle.Fill;
            statusReportGUI.Show();
        }

        private void ShowRevenueReport(object sender, EventArgs e)
        {
            revenueReportGUI = new RevenueReportGUI();
            revenueReportGUI.MdiParent = this;
            revenueReportGUI.Dock = DockStyle.Fill;
            revenueReportGUI.Show();
        }

        private void ShowQuantityReport(object sender, EventArgs e)
        {
            quantityReportGUI = new QuantityReportGUI();
            quantityReportGUI.MdiParent = this;
            quantityReportGUI.Dock = DockStyle.Fill;
            quantityReportGUI.Show();
        }

        private void ShowPaymentReport(object sender, EventArgs e)
        {
            paymentReportGUI = new PaymentReportGUI();
            paymentReportGUI.MdiParent = this;
            paymentReportGUI.Dock = DockStyle.Fill;
            paymentReportGUI.Show();
        }

        private void OpenListContract(object sender, EventArgs e)
        {
            inUpdateForm = false;
            ShowForm(ref listContractForm, typeof(ListContractGUI));
            if (listContractForm != null && listContractForm is ListContractGUI contractForm)
            {
                contractForm.ClearRows();
            }
            SetBackGround(contractContainer);
        }

        private void OpenListTask(object sender, EventArgs e)
        {
            inUpdateForm = false;
            ShowForm(ref listTaskForm, typeof(ListTaskGUI));
            if (listTaskForm != null && listTaskForm is ListTaskGUI taskForm)
            {
                taskForm.ClearRows();
            }
            SetBackGround(taskContainer);
        }

        private void OpenListPayment(object sender, EventArgs e)
        {
            inUpdateForm = false;
            ShowForm(ref listPaymentForm, typeof(ListPaymentGUI));
            if (listPaymentForm != null && listPaymentForm is ListPaymentGUI paymentForm)
            {
                paymentForm.ClearRows();
            }
            SetBackGround(paymentContainer);
        }

        private void OpenListUser(object sender, EventArgs e)
        {
            inUpdateForm = false;
            ShowForm(ref listUserForm, typeof(ListUserGUI));
            if (listUserForm != null && listUserForm is ListUserGUI userForm)
            {
                userForm.ClearRows();
            }
            SetBackGround(listUserContainer);
        }

        private void ShowContact(object sender, EventArgs e)
        {
            contactGUI = new ContactGUI();
            contactGUI.MdiParent = this;
            contactGUI.Dock = DockStyle.Fill;
            contactGUI.Show();
        }

        private void ShowChatbot(object sender, EventArgs e)
        {
            chatbotGUI = new ChatbotGUI();
            chatbotGUI.MdiParent = this;
            chatbotGUI.Dock = DockStyle.Fill;
            chatbotGUI.Show();
        }
        #endregion

        #region language
        protected virtual void OnLanguageChanged()
        {
            LanguageChanged?.Invoke(this, EventArgs.Empty);
            InitTextContent();
        }

        private void btnVietnamese_Click(object sender, EventArgs e)
        {
            if (SettingContext.Language != "vi")
            {
                SettingContext.Language = "vi";
                OnLanguageChanged();
            }
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            if (SettingContext.Language != "en")
            {
                SettingContext.Language = "en";
                OnLanguageChanged();
            }
        }
        #endregion
    }
}
