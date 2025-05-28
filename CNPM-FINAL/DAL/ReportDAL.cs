using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CNPM_FINAL.DAL
{
    public class ReportDAL : BaseDAL
    {
        private readonly string JOIN_TABLE = @"
        SELECT 
            c.contract_code,
            c.contract_name,
            c.organization_name,
            ps.stage_name,
            ps.amount,
            ROUND((ps.amount / c.total_value) * 100, 2) AS percentage_of_contract_value,
            ps.payment_date,
            ps.status
        FROM 
            contracts c
        JOIN 
            payment_stages ps
        ON 
            c.id = ps.contract_id
        ";

        public List<ReportDTO> GetContracts(Dictionary<string, object> parameters, bool hasSignedDate, bool hasExpirationDate)
        {
            List<ReportDTO> reports = new List<ReportDTO>();
            string query = "SELECT * FROM contracts WHERE 1 = 1 ";

            if (parameters.ContainsKey("@keyword"))
            {
                string keywordLike = "%" + parameters["@keyword"].ToString() + "%";
                parameters["@keyword"] = keywordLike;
                query += " AND (contract_code LIKE @keyword OR contract_name LIKE @keyword)";
            }

            if (hasSignedDate)
            {
                query += " AND (signed_date BETWEEN @dateFrom AND @dateTo)";
            }

            if (hasExpirationDate)
            {
                query += " AND (expiration_date BETWEEN @dateFrom AND @dateTo)";
            }

            if (parameters.ContainsKey("@status"))
            {
                query += " AND status = @status";
            }

            var data = this.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                reports.Add(mapToDto(row));
            }
            return reports;
        }

        public List<ReportDTO> GetPayments(Dictionary<string, object> parameters, bool hasPaymentDate)
        {
            List<ReportDTO> reports = new List<ReportDTO>();
            string query = $"{JOIN_TABLE} WHERE 1 = 1 ";

            if (parameters.ContainsKey("@keyword"))
            {
                string keywordLike = "%" + parameters["@keyword"].ToString() + "%";
                parameters["@keyword"] = keywordLike;
                query += " AND (c.contract_code LIKE @keyword OR c.contract_name LIKE @keyword)";
            }

            if (hasPaymentDate)
            {
                query += " AND (ps.payment_date BETWEEN @dateFrom AND @dateTo)";
            }

            var data = this.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                reports.Add(mapToDto(row, true));
            }

            return reports;
        }

        private ReportDTO mapToDto(DataRow row, bool isPayment = false)
        {
            var report = new ReportDTO
            {
                contractCode = row["contract_code"].ToString(),
                contractName = row["contract_name"].ToString(),
                organizationName = row["organization_name"].ToString()
            };


            if (isPayment)
            {
                report.stageName = row["stage_name"].ToString();
                report.paymentDate = Convert.ToDateTime(row["payment_date"]);
                report.paymentValue = Convert.ToDouble(row["amount"]);
                report.paymentPercentage = Math.Round(Convert.ToDouble(row["percentage_of_contract_value"]), 2);
                report.paymentStatus = row["status"].ToString();
            }
            else
            {
                report.contractValue = Convert.ToDouble(row["total_value"]);
                report.contractStatus = row["status"].ToString();
                report.phone = row["contact_phone"].ToString();
                report.email = row["contact_email"].ToString();
                report.partner = row["partner_name"].ToString();
                report.signedDate = Convert.ToDateTime(row["signed_date"]);
                report.expirationDate = Convert.ToDateTime(row["expiration_date"]);
            }

            return report;
        }
    }
}
