using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace CNPM_FINAL.DAL
{
    public class CommissionDAL : BaseDAL
    {
        public List<CommissionDTO> GetAll(Dictionary<string, object> parameters)
        {
            List<CommissionDTO> commissions = new List<CommissionDTO>();
            string query = @"
            SELECT 
                c.contract_code,
                ps.stage_name,
                cm.status,
                cm.commission_percentage,
                cm.commission_amount,
                cm.commission_date
            FROM commissions cm
            JOIN payment_stages ps ON cm.payment_stage_id = ps.id
            JOIN contracts c ON c.id = ps.contract_id
            WHERE 1=1 ";

            if (parameters.ContainsKey("@keyword"))
            {
                string keywordLike = "%" + parameters["@keyword"].ToString() + "%";
                parameters["@keyword"] = keywordLike;
                query += " AND (c.contract_code COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword " +
                    "OR ps.stage_name COLLATE SQL_Latin1_General_CP1_CI_AI  LIKE @keyword)";
            }

            if (parameters.ContainsKey("@dateFrom") && parameters.ContainsKey("@dateTo"))
            {
                query += " AND cm.commission_date BETWEEN @dateFrom AND @dateTo";
            }

            var data = this.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                commissions.Add(mapToDto(row));
            }

            return commissions;
        }

        private CommissionDTO mapToDto(DataRow dataRow)
        {
            return new CommissionDTO
            {
                contractCode = dataRow["contract_code"].ToString(),
                paymentStageName = dataRow["stage_name"].ToString(),
                status = dataRow["status"].ToString(),
                commissionPercentage = Convert.ToDecimal(dataRow["commission_percentage"]),
                commissionAmount = Convert.ToDouble(dataRow["commission_amount"]),
                commissionDate = Convert.ToDateTime(dataRow["commission_date"])
            };
        }
    }
}
