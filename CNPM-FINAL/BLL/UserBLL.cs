using CNPM_FINAL.Context;
using CNPM_FINAL.DAL;
using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Resources;

namespace CNPM_FINAL.BLL
{
    public class UserBLL
    {
        private readonly UserDAL userDAL = new UserDAL();
        protected CultureInfo cultureInfo;
        protected ResourceManager resourceManager;
        private readonly string defaultPassword = ConfigurationManager.AppSettings["defaultPassword"];

        private string GetLocalizedString(string key)
        {
            cultureInfo = CultureInfo.GetCultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.USER_BLL, typeof(UserBLL).Assembly);
            return resourceManager.GetString(key, cultureInfo);
        }

        public bool Login(string username, string password)
        {
            var user = userDAL.GetOneByUserName(username);
            if (user == null)
                return false;

            bool valadate = BCrypt.Net.BCrypt.Verify(password, user.password);
            if (valadate)
            {
                UserContext.SetUserContext(user);
                return true;
            }

            return false;
        }

        public UserDTO GetOneByUserCode(string userCode) => userDAL.GetOneByUserCode(userCode);
        public UserDTO GetOneByUserName(string username)
        {
            if (UserContext.GetRoleName() != "Admin")
                throw new BuisinessException(GetLocalizedString("roleErr"));

            return userDAL.GetOneByUserName(username);
        }

        public List<UserDTO> GetAll(string keyword = null)
        {
            var parameters = new Dictionary<string, object> { };
            if (!string.IsNullOrEmpty(keyword))
            {
                parameters.Add("@keyword", "%" + keyword + "%");
            }

            return userDAL.GetAll(parameters);
        }

        public List<string> GetAllUserCode(string keyword) => userDAL.GetAllByUserCode(keyword);

        public void Insert(UserDTO userDTO)
        {
            var roleName = UserContext.GetRoleName();
            if (string.IsNullOrEmpty(roleName) || roleName != "Admin")
                throw new BuisinessException(GetLocalizedString("roleErr"));

            var parameters = new Dictionary<string, object>();
            parameters.Add("@username", userDTO.userName);
            parameters.Add("@user_code", userDTO.code);

            if (userDAL.GetOneByUserCode(userDTO.code) != null)
                throw new BuisinessException(GetLocalizedString("userCodeErr"));

            if (userDAL.GetOneByUserName(userDTO.userName) != null)
                throw new BuisinessException(GetLocalizedString("userNameErr"));

            parameters.Add("@full_name", userDTO.fullName);
            parameters.Add("@role_name", userDTO.roleName);
            parameters.Add("@email", userDTO.email);
            parameters.Add("@password", BCrypt.Net.BCrypt.HashPassword(defaultPassword));
            parameters.Add("@phone", userDTO.phone);

            userDAL.Insert(parameters);
        }

        public void UpdateInfo(UserDTO userDTO, bool isAdmin = false, string oldUserCode = null, string oldUsername = null)
        {
            var parameters = new Dictionary<string, object> { };
            parameters.Add("@user_code", isAdmin ? userDTO.code : UserContext.GetUserCode());
            if (isAdmin)
            {
                if (oldUserCode == null || oldUsername == null)
                    throw new BuisinessException(GetLocalizedString("oldUserErroldUserErr"));

                if (oldUserCode != userDTO.code)
                {
                    if (userDAL.GetOneByUserCode(userDTO.code) != null)
                        throw new BuisinessException(GetLocalizedString("userCodeErr"));
                }

                if (oldUsername != userDTO.userName)
                {
                    if (userDAL.GetOneByUserName(userDTO.userName) != null)
                        throw new BuisinessException(GetLocalizedString("userNameErr"));
                }
            }

            parameters.Add("@username", userDTO.userName);
            parameters.Add("@old_user_code", isAdmin ? oldUserCode : UserContext.GetUserCode());
            parameters.Add("@role_name", isAdmin ? userDTO.roleName : UserContext.GetRoleName());
            parameters.Add("@id", isAdmin ? userDTO.id : UserContext.GetUserId());
            parameters.Add("@full_name", userDTO.fullName);
            parameters.Add("@email", userDTO.email);
            parameters.Add("@phone", userDTO.phone);

            userDAL.UpdateInfo(parameters);
        }

        public void UpdateUserPermissions(string username, List<string> permissions)
        {
            if (UserContext.GetRoleName() != "Admin")
                throw new BuisinessException(GetLocalizedString("roleErr"));

            string permissionsString = string.Join(",", permissions);
            var parameters = new Dictionary<string, object> { };
            parameters.Add("@username", username);
            parameters.Add("@permissionsString", permissionsString);

            userDAL.UpdateUserPermissions(parameters);
        }

        public void ResetPassword(string userCode)
        {
            if (UserContext.GetRoleName() != "Admin")
                throw new BuisinessException(GetLocalizedString("roleErr"));

            var parameters = new Dictionary<string, object> { };
            parameters.Add("@user_code", userCode);
            parameters.Add("@password", BCrypt.Net.BCrypt.HashPassword(defaultPassword));

            userDAL.UpdatePassword(parameters);
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {
            var parameters = new Dictionary<string, object> { };
            parameters.Add("@user_code", UserContext.GetUserCode());

            var user = userDAL.GetOneByUserName(UserContext.GetUsername());
            if (user == null)
                throw new BuisinessException(GetLocalizedString("userNotFound"));

            bool valadate = BCrypt.Net.BCrypt.Verify(oldPassword, user.password);
            if (!valadate)
                throw new BuisinessException(GetLocalizedString("oldPasswordErr"));

            parameters.Add("@password", BCrypt.Net.BCrypt.HashPassword(newPassword));
            userDAL.UpdatePassword(parameters);
        }
    }
}
