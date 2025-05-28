using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_FINAL.Context
{
    public class ResourceContext
    {
        public readonly static string LIST_COMMISSION = "CNPM_FINAL.GUI.SubItem.Commission.ListCommissionGUI";
        public readonly static string LIST_USER = "CNPM_FINAL.GUI.SubItem.User.ListUserGUI";
        public readonly static string LIST_CONTRACT = "CNPM_FINAL.GUI.SubItem.Contract.ListContractGUI";
        public readonly static string LIST_TASK = "CNPM_FINAL.GUI.SubItem.Task.ListTaskGUI";
        public readonly static string LIST_TASK_DETAIL = "CNPM_FINAL.GUI.SubItem.Task.ListTaskDetailGUI";
        public readonly static string LIST_PAYMENT = "CNPM_FINAL.GUI.SubItem.Payment.ListPaymentGUI";

        public readonly static string CREATE_CONTRACT = "CNPM_FINAL.GUI.SubItem.Contract.CreateContractGUI";
        public readonly static string CREATE_TASK = "CNPM_FINAL.GUI.SubItem.Task.CreateTaskGUI";
        public readonly static string CREATE_PAYMENT = "CNPM_FINAL.GUI.SubItem.Payment.CreatePaymentGUI";
        public readonly static string CREATE_USER = "CNPM_FINAL.GUI.SubItem.User.CreateUserGUI";

        public readonly static string UPDATE_CONTRACT = "CNPM_FINAL.GUI.SubItem.Contract.UpdateContractGUI";
        public readonly static string UPDATE_USER = "CNPM_FINAL.GUI.SubItem.User.UpdateUserGUI";
        public readonly static string UPDATE_PERMISSION = "CNPM_FINAL.GUI.SubItem.User.UpdatePermissionGUI";
        public readonly static string UPDATE_TASK = "CNPM_FINAL.GUI.SubItem.Task.UpdateTaskGUI";
        public readonly static string UPDATE_PAYMENT = "CNPM_FINAL.GUI.SubItem.Payment.UpdatePaymentGUI";

        public readonly static string MAIN_GUI = "CNPM_FINAL.GUI.MainGUI";
        public readonly static string LOGIN_GUI = "CNPM_FINAL.GUI.LoginGUI";
        public readonly static string USER_INFO_GUI = "CNPM_FINAL.GUI.SubItem.User.UserInfoGUI";
        public readonly static string DASHBOARD_GUI = "CNPM_FINAL.GUI.DashboardGUI";

        public readonly static string STATUS_REPORT_GUI = "CNPM_FINAL.GUI.SubItem.Report.StatusReportGUI";
        public readonly static string QUANTITY_REPORT_GUI = "CNPM_FINAL.GUI.SubItem.Report.QuantityReportGUI";
        public readonly static string PAYMENT_REPORT_GUI = "CNPM_FINAL.GUI.SubItem.Report.PaymentReportGUI";
        public readonly static string REVENUE_REPORT_GUI = "CNPM_FINAL.GUI.SubItem.Report.RevenueReportGUI";

        public readonly static string DATE_COMMISSION = "CNPM_FINAL.GUI.SubItem.Commission.DateCommissionGUI";

        public readonly static string CHATBOT_GUI = "CNPM_FINAL.GUI.SubItem.Support.ChatbotGUI";

        public readonly static string BASE_DAL = "CNPM_FINAL.DAL.BaseDAL";
        public readonly static string USER_BLL = "CNPM_FINAL.BLL.UserBLL";
    }
}
