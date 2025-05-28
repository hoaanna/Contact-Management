using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace CNPM_FINAL.DAL
{
    public class ContractDAL : BaseDAL
    {
        private readonly string JOIN_TABLE = @"
        SELECT 
                c.id, 
                c.contract_code, 
                c.status,
                u.user_code,
                c.user_id, 
                c.commission_percentage,
                c.contract_name,
                c.contract_content,
                c.signed_date,
                c.expiration_date,
                c.partner_name,
                c.contact_email,
                c.contact_phone,
                c.total_value,
                c.created_at,
                c.updated_at,
                c.organization_name
        FROM contracts c
        JOIN users u ON c.user_id = u.id
        ";
        public void Insert(Dictionary<string, object> parameters)
        {
            string query = @"
            INSERT INTO contracts 
                (contract_code, user_id, commission_percentage, contract_name, contract_content, 
                    signed_date, expiration_date, partner_name, contact_email, contact_phone, 
                    total_value, status, organization_name)
            VALUES 
                (@contractCode, @userId, @commissionPercentage, @contractName, @contractContent, 
                    @signedDate, @expiredDate, @partnerName, @contactEmail, @contactPhone, 
                    @totalValue, N'New', @organizationName)
            ";
            this.ExecuteNonQuery(query, parameters);
        }

        public void Update(Dictionary<string, object> parameters)
        {
            string query = @"
            EXEC sp_update_contract
                @oldContractCode, @newContractCode, @userId, @commissionPercentage, @contractName, 
                @contractContent, @signedDate, @expiredDate, @partnerName, @contactEmail, 
                @contactPhone, @organizationName
            ";
            this.ExecuteNonQuery(query, parameters);
        }
        public void Delete(string contractCode)
        {
            string query = "DELETE FROM contracts WHERE contract_code = @contractCode";
            var parameters = new Dictionary<string, object>
            {
                { "@contractCode", contractCode }
            };
            this.ExecuteNonQuery(query, parameters);
        }

        public ContractDTO GetOneByCode(string contractCode)
        {
            List<ContractDTO> contracts = new List<ContractDTO>();
            string query = $"{JOIN_TABLE} WHERE c.contract_code = @contractCode";
            var parameters = new Dictionary<string, object>
            {
                { "@contractCode", contractCode }
            };

            var data = this.ExecuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                return mapToDto(data.Rows[0]);
            }

            return null;
        }

        public List<string> GetAllContractCode(Dictionary<string, object> parameters = null)
        {
            List<string> contractCodes = new List<string>();
            string query = $"{JOIN_TABLE} WHERE 1=1";

            if (parameters != null)
            {
                if (parameters.ContainsKey("@keyword"))
                {
                    string keywordLike = "%" + parameters["@keyword"].ToString() + "%";
                    parameters["@keyword"] = keywordLike;
                    query += " AND c.contract_code COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword";
                }

                if (parameters.ContainsKey("@userId"))
                {
                    query += " AND c.user_id = @userId";
                }
            }

            var data = this.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                contractCodes.Add(mapToDto(row).contractCode);
            }
            return contractCodes;
        }

        public List<ContractDTO> GetAll(Dictionary<string, object> parameters, bool hasSignedDate, bool hasExpirarionDate)
        {
            List<ContractDTO> contracts = new List<ContractDTO>();
            string query = $"{JOIN_TABLE} WHERE 1=1";

            if (parameters.ContainsKey("@keyword"))
            {
                string keywordLike = "%" + parameters["@keyword"].ToString() + "%";
                parameters["@keyword"] = keywordLike;
                query += " AND (c.contract_code COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword " +
                    "OR c.contract_name COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @keyword)";
            }

            if (parameters.ContainsKey("@userId"))
            {
                query += " AND c.user_id = @userId";
            }

            if (hasSignedDate)
            {
                query += " AND (c.signed_date BETWEEN @dateFrom AND @dateTo)";
            }

            if (hasExpirarionDate)
            {
                query += " AND (c.expiration_date BETWEEN @dateFrom AND @dateTo)";
            }

            var data = this.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                contracts.Add(mapToDto(row));
            }
            return contracts;
        }

        private ContractDTO mapToDto(DataRow row)
        {
            return new ContractDTO
            {
                id = Convert.ToInt32(row["id"]),
                userCode = row["user_code"].ToString(),
                contractCode = row["contract_code"].ToString(),
                contractName = row["contract_name"].ToString(),
                contractContent = row["contract_content"].ToString(),
                signedDate = Convert.ToDateTime(row["signed_date"]),
                expiredDate = Convert.ToDateTime(row["expiration_date"]),
                partnerName = row["partner_name"].ToString(),
                contactEmail = row["contact_email"].ToString(),
                contactPhone = row["contact_phone"].ToString(),
                totalValue = Convert.ToDouble(row["total_value"]),
                commissionPercentage = Convert.ToDouble(row["commission_percentage"]),
                status = row["status"].ToString(),
                origanizationName = row["organization_name"].ToString()
            };
        }
    }
}
