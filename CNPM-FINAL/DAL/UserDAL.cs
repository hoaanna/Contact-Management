using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CNPM_FINAL.DAL
{
    public class UserDAL : BaseDAL
    {
        public UserDTO GetOneByUserName(string username)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@username", username }
            };
            string query = @"
            SELECT u.id, u.username, u.user_code, u.full_name, u.role_name, u.email, u.password, u.phone, STRING_AGG(p.name, ', ') AS permissions
            FROM users u
            LEFT JOIN user_permissions up ON u.id = up.user_id
            LEFT JOIN permissions p ON up.permission_id = p.id
            WHERE u.username = @username
            GROUP BY u.id, u.username, u.user_code, u.full_name, u.role_name, u.email, u.password, u.phone";
            var data = this.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                var user = mapToDto(data.Rows[0]);
                List<string> permissions = new List<string>();
                if (data.Rows[0]["permissions"] != null && !string.IsNullOrWhiteSpace(data.Rows[0]["permissions"].ToString()))
                {
                    permissions = data.Rows[0]["permissions"]
                        .ToString()
                        .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                }
                user.permissions = permissions;
                return user;
            }
            return null;
        }

        public List<string> GetAllByUserCode(string userCode)
        {
            List<string> userCodes = new List<string>();
            string userCodeLike = "%" + userCode + "%";
            string query = $"SELECT user_code FROM users WHERE " +
                $"user_code COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @userCodeLike AND role_name != 'Admin'";

            var data = this.ExecuteQuery(query, new Dictionary<string, object> {
                { "@userCodeLike", userCodeLike }
            });
            foreach (DataRow row in data.Rows)
            {
                userCodes.Add(row["user_code"].ToString());
            }
            return userCodes;
        }

        public UserDTO GetOneByUserCode(string userCode)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@userCode", userCode }
            };
            string query = "SELECT * FROM users WHERE user_code = @userCode";
            var data = this.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return mapToDto(data.Rows[0]);
            }
            return null;
        }

        public List<UserDTO> GetAll(Dictionary<string, object> parameters = null)
        {
            List<UserDTO> list = new List<UserDTO>();
            string query = "SELECT * FROM users WHERE 1 = 1 ";

            if (parameters != null && parameters.ContainsKey("@keyword"))
            {
                query += " AND (username COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword " +
                    "OR user_code COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword " +
                    "OR full_name COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword)";
            }

            var data = this.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                list.Add(mapToDto(row));
            }
            return list;
        }

        public List<string> GetAdminEmail()
        {
            List<string> emails = new List<string>();
            string query = "SELECT email FROM users WHERE role_name = 'Admin'";
            var data = this.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                emails.Add(row["email"].ToString());
            }
            return emails;
        }

        public void Insert(Dictionary<string, object> parameters)
        {
            string query = @"EXEC sp_create_user @user_code, @role_name, @full_name, @username, @password, @email, @phone";
            this.ExecuteNonQuery(query, parameters);
        }

        public void UpdateInfo(Dictionary<string, object> parameters)
        {
            string query = @"EXEC sp_update_user @old_user_code, @user_code, @role_name, @full_name, @username, @email, @phone";
            this.ExecuteNonQuery(query, parameters);
        }

        public void UpdatePassword(Dictionary<string, object> parameters)
        {
            string query = @"
            UPDATE users 
            SET password = @password
            WHERE user_code = @user_code";
            this.ExecuteNonQuery(query, parameters);
        }

        public void UpdateUserPermissions(Dictionary<string, object> parameters)
        {
            string query = @"EXEC sp_update_user_permissions @username, @permissionsString";
            this.ExecuteNonQuery(query, parameters);
        }

        private UserDTO mapToDto(DataRow dataRow)
        {
            return new UserDTO
            {
                id = (int)dataRow["id"],
                code = dataRow["user_code"].ToString(),
                fullName = dataRow["full_name"].ToString(),
                userName = dataRow["username"].ToString(),
                roleName = dataRow["role_name"].ToString(),
                email = dataRow["email"].ToString(),
                password = dataRow["password"].ToString(),
                phone = dataRow["phone"].ToString()
            };
        }
    }
}
