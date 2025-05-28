using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace CNPM_FINAL.DAL
{
    public class PaymentStageDAL : BaseDAL
    {
        private const string JOIN_TABLE = @"
            SELECT 
                ps.id,
                ps.contract_id,
                c.contract_code,
                ps.stage_name,
                ps.amount,
                ps.payment_date,
                ps.description,
                ps.status,
                ROUND((ps.amount / c.total_value) * 100, 2) 
                    AS percentage_of_contract_value
            FROM payment_stages ps
            JOIN contracts c ON ps.contract_id = c.id 
        ";
        public PaymentStageDTO GetOneById(Dictionary<string, object> parameters)
        {
            string query = $"{JOIN_TABLE} WHERE ps.id = @id";
            var data = this.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return mapToDto(data.Rows[0]);
            }
            return null;
        }

        public bool ExistByContractCode(Dictionary<string, object> parameters)
        {
            List<PaymentStageDTO> payments = new List<PaymentStageDTO>();
            string query = $"{JOIN_TABLE} WHERE c.contract_code = @contractCode";

            var data = this.ExecuteQuery(query, parameters);
            return data.Rows.Count > 0;
        }

        public List<PaymentStageDTO> GetAll(Dictionary<string, object> parameters)
        {
            List<PaymentStageDTO> payments = new List<PaymentStageDTO>();
            string query = $"{JOIN_TABLE} WHERE 1 = 1";

            if (parameters.ContainsKey("@keyword"))
            {
                string keywordLike = "%" + parameters["@keyword"].ToString() + "%";
                parameters["@keyword"] = keywordLike;
                query += " AND (c.contract_code COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword " +
                    "OR ps.stage_name COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword)";
            }

            if (parameters.ContainsKey("@userId"))
            {
                query += " AND c.user_id = @userId";
            }

            if (parameters.ContainsKey("@dateFrom") && parameters.ContainsKey("@dateTo"))
            {
                query += " AND ps.payment_date BETWEEN @dateFrom AND @dateTo";
            }

            var data = this.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                payments.Add(mapToDto(row));
            }
            return payments;
        }

        public void Insert(Dictionary<string, object> parameters)
        {
            string query = @"
            EXEC sp_create_payment_stage
                @contractId, @stageName, @amount, @paymentDate, @description, @status
            ";
            this.ExecuteNonQuery(query, parameters);
        }

        public void Update(Dictionary<string, object> parameters)
        {
            string query = @"
            EXEC sp_update_payment_stage
                @id, @amount, @paymentDate, @stageName, @description, @status
            ";
            this.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM payment_stages WHERE id = @id";
            var parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            this.ExecuteNonQuery(query, parameters);
        }

        private PaymentStageDTO mapToDto(DataRow dataRow)
        {
            return new PaymentStageDTO
            {
                id = Convert.ToInt32(dataRow["id"]),
                contractId = Convert.ToInt32(dataRow["contract_id"]),
                contractCode = dataRow["contract_code"].ToString(),
                stageName = dataRow["stage_name"].ToString(),
                amount = Convert.ToDecimal(dataRow["amount"]),
                percentage = Convert.ToDouble(dataRow["percentage_of_contract_value"]),
                paymentDate = Convert.ToDateTime(dataRow["payment_date"]),
                description = dataRow["description"].ToString(),
                status = dataRow["status"].ToString()
            };
        }
    }
}
