using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using CNPM_FINAL.Context;
using System.Globalization;
using System.Resources;

namespace CNPM_FINAL.DAL
{
    public class BaseDAL
    {
        protected string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        protected CultureInfo cultureInfo;
        protected ResourceManager resourceManager;

        private string GetLocalizedString(string key)
        {
            cultureInfo = CultureInfo.GetCultureInfo(SettingContext.Language);
            resourceManager = new ResourceManager(ResourceContext.BASE_DAL, typeof(BaseDAL).Assembly);
            return resourceManager.GetString(key, cultureInfo);
        }

        protected int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        AddParameters(command, parameters);
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw HandleSqlException(ex);
            }
            catch (InvalidOperationException)
            {
                throw new BuisinessException(GetLocalizedString("invalidOperationErr"));
            }
            catch (Exception)
            {
                throw new BuisinessException(GetLocalizedString("undefinedErr"));
            }
        }

        protected DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        AddParameters(command, parameters);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw HandleSqlException(ex);
            }
            catch (InvalidOperationException)
            {
                throw new BuisinessException(GetLocalizedString("invalidOperationErr"));
            }
            catch (Exception)
            {
                throw new BuisinessException(GetLocalizedString("undefinedErr"));
            }
        }

        private void AddParameters(SqlCommand command, Dictionary<string, object> parameters)
        {
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }
        }

        public BuisinessException HandleSqlException(SqlException ex)
        {
            switch (ex.Number)
            {
                case -1:
                    return new BuisinessException(GetLocalizedString("connectErr"));
                case 547:
                    return new BuisinessException(GetLocalizedString("constraintErr"));
                case 2627:
                    return new BuisinessException(GetLocalizedString("duplicateErr"));
                case 2601:
                    return new BuisinessException(GetLocalizedString("duplicateErr"));
                case 208:
                    return new BuisinessException(GetLocalizedString("notExistErr"));
                case 1205:  
                    return new BuisinessException(GetLocalizedString("deadlockErr"));
                case 18456:
                    return new BuisinessException(GetLocalizedString("loginErr"));
                case 16:
                    return new BuisinessException(ex.Message);
                default:
                    return new BuisinessException(ex.Message);
            }
        }
    }
}
