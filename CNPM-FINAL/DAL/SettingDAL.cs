using CNPM_FINAL.DTO;
using System.Collections.Generic;
using System.Data;
using System;

namespace CNPM_FINAL.DAL
{
    public class SettingDAL : BaseDAL
    {
        public List<SettingDTO> GetAll(Dictionary<string, object> parameters = null)
        {
            List<SettingDTO> historyCommissionDate = new List<SettingDTO>();
            string query = @"SELECT * FROM settings";
            if (parameters != null)
            {
                if (parameters.ContainsKey("@dateFrom") && parameters.ContainsKey("@dateTo"))
                {
                    query += " WHERE effective_date BETWEEN @dateFrom AND @dateTo";
                }
            }

            var data = this.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                historyCommissionDate.Add(mapToDto(row));
            }
            return historyCommissionDate;
        }

        public SettingDTO GetCurrentDate(Dictionary<string, object> parameters)
        {
            string query = "SELECT TOP 1 * FROM settings ORDER BY effective_date DESC";
            var data = this.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return mapToDto(data.Rows[0]);
            }
            return null;
        }


        public void Insert(Dictionary<string, object> parameters)
        {
            string query = @"INSERT INTO settings (value, effective_date) VALUES (@value, @effectiveDate);";
            this.ExecuteNonQuery(query, parameters);
        }

        private SettingDTO mapToDto(DataRow dataRow)
        {
            return new SettingDTO
            {
                value = Convert.ToInt32(dataRow["value"]),
                effectiveDate = Convert.ToDateTime(dataRow["effective_date"])
            };
        }
    }
}
