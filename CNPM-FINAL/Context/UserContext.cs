using CNPM_FINAL.DTO;
using System.Collections.Generic;

namespace CNPM_FINAL.Context
{
    public class UserContext
    {
        private static string FullName { get; set; }
        private static string Username { get; set; }
        private static string RoleName { get; set; }
        private static string Email { get; set; }
        private static string Phone { get; set; }
        private static string UserCode { get; set; }
        private static int UserId { get; set; }
        private static List<string> Permissions { get; set; }

        public static int GetUserId()
        {
            return UserId;
        }

        public static string GetUserCode()
        {
            return UserCode;
        }

        public static string GetName()
        {
            return FullName;
        }

        public static string GetUsername()
        {
            return Username;
        }

        public static string GetRoleName()
        {
            return RoleName;
        }

        public static string GetEmail()
        {
            return Email;
        }

        public static string GetPhone()
        {
            return Phone;
        }

        public static List<string> GetPermissions()
        {
            return Permissions;
        }

        public static void ClearUserContext()
        {
            FullName = null;
            Username = null;
            RoleName = null;
            Email = null;
            Phone = null;
            UserCode = null;
            UserId = -1;
            Permissions = new List<string>();
        }

        public static void SetUserContext(UserDTO user)
        {
            UserId = user.id;
            FullName = user.fullName;
            Username = user.userName;
            RoleName = user.roleName;
            Email = user.email;
            Phone = user.phone;
            UserCode = user.code;
            Permissions = user.permissions == null ? new List<string>() : user.permissions;
        }

        public static bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(UserCode) || !string.IsNullOrEmpty(RoleName)
                || !string.IsNullOrEmpty(Username);
        }

        public static bool HasAnyRole(List<string> roles)
        {
            return roles.Contains(RoleName);
        }
    }
}
