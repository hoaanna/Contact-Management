using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CNPM_FINAL.DAL
{
    public class ChartDAL : BaseDAL
    {
        public List<KeyValuePair<string, int>> GetTotalContractByMonth(int year, int month)
        {
            List<KeyValuePair<string, int>> contractsByWeek = new List<KeyValuePair<string, int>>();

            string query = @"
            SELECT 
                CASE 
                    WHEN DAY(signed_date) BETWEEN 1 AND 7 THEN '1'
                    WHEN DAY(signed_date) BETWEEN 8 AND 14 THEN '2'
                    WHEN DAY(signed_date) BETWEEN 15 AND 21 THEN '3'
                    WHEN DAY(signed_date) BETWEEN 22 AND 31 THEN '4'
                END AS ContractWeek,
                COUNT(*) AS ContractCount
            FROM  
                contracts  
            WHERE 
                YEAR(signed_date) = @year
                AND MONTH(signed_date) = @month
                AND DAY(signed_date) BETWEEN 1 AND 31 
            GROUP BY 
                CASE 
                    WHEN DAY(signed_date) BETWEEN 1 AND 7 THEN '1'
                    WHEN DAY(signed_date) BETWEEN 8 AND 14 THEN '2'
                    WHEN DAY(signed_date) BETWEEN 15 AND 21 THEN '3'
                    WHEN DAY(signed_date) BETWEEN 22 AND 31 THEN '4'
                END
            ORDER BY ContractWeek;";

            var data = ExecuteQuery(query, new Dictionary<string, object>
            {
                {"@year", year },
                {"@month", month }
            });

            foreach (DataRow row in data.Rows)
            {
                string week = row["ContractWeek"].ToString();
                int count = Convert.ToInt32(row["ContractCount"]);
                contractsByWeek.Add(new KeyValuePair<string, int>(week, count));
            }

            return contractsByWeek;
        }

        public List<KeyValuePair<string, int>> GetContractStatusCountByMonth(int year, int month)
        {
            List<KeyValuePair<string, int>> statusCounts = new List<KeyValuePair<string, int>>();

            string query = @"
            SELECT 
                status, COUNT(*) AS count 
            FROM  
                contracts 
            WHERE 
                YEAR(signed_date) = @year AND MONTH(signed_date) = @month
            GROUP BY   
                status";

            var data = ExecuteQuery(query, new Dictionary<string, object>
            {
                {"@year", year },
                {"@month", month }
            });

            foreach (DataRow row in data.Rows)
            {
                string status = row["status"].ToString();
                int count = Convert.ToInt32(row["count"]);
                statusCounts.Add(new KeyValuePair<string, int>(status, count));
            }

            return statusCounts;
        }

        public List<KeyValuePair<string, int>> GetRevenueByMonth(int year, int month)
        {
            List<KeyValuePair<string, int>> statusCounts = new List<KeyValuePair<string, int>>();

            string query = @"
             SELECT 
                CASE 
                    WHEN DAY(payment_date) BETWEEN 1 AND 7 THEN '1'
                    WHEN DAY(payment_date) BETWEEN 8 AND 14 THEN '2'
                    WHEN DAY(payment_date) BETWEEN 15 AND 21 THEN '3'
                    WHEN DAY(payment_date) BETWEEN 22 AND 31 THEN '4'
                END AS payment_period,
                SUM(amount) AS sum_amount
             FROM  
                payment_stages  
             WHERE 
                YEAR(payment_date) = @year
                AND MONTH(payment_date) = @month
                AND DAY(payment_date) BETWEEN 1 AND 31 
             GROUP BY 
                CASE 
                    WHEN DAY(payment_date) BETWEEN 1 AND 7 THEN '1'
                    WHEN DAY(payment_date) BETWEEN 8 AND 14 THEN '2'
                    WHEN DAY(payment_date) BETWEEN 15 AND 21 THEN '3'
                    WHEN DAY(payment_date) BETWEEN 22 AND 31 THEN '4'
                END
             ORDER BY payment_period;";

            var data = ExecuteQuery(query, new Dictionary<string, object>
            {
                {"@year", year },
                {"@month", month }
            });

            foreach (DataRow row in data.Rows)
            {
                string status = row["payment_period"].ToString();
                int count = Convert.ToInt32(row["sum_amount"]);
                statusCounts.Add(new KeyValuePair<string, int>(status, count));
            }

            return statusCounts;
        }

        public List<PaymentStage> GetPaymentStages(int year, int month)
        {
            List<PaymentStage> paymentStages = new List<PaymentStage>();

            string query = @"
            SELECT 
                ps.contract_id,
                c.contract_code,
                ps.amount,
                ps.payment_date,
                SUM(ps.amount) OVER (PARTITION BY ps.contract_id ORDER BY ps.payment_date) AS cumulative_amount,
                c.total_value,
                c.expiration_date
            FROM 
                payment_stages ps
            INNER JOIN 
                contracts c ON ps.contract_id = c.id
            WHERE 
                YEAR(ps.payment_date) = @year AND MONTH(ps.payment_date) = @month
            ORDER BY 
                ps.contract_id, ps.payment_date, ps.amount";

            var data = ExecuteQuery(query, new Dictionary<string, object>
            {
                {"@year", year },
                {"@month", month }
            });

            foreach (DataRow row in data.Rows)
            {
                var stage = new PaymentStage
                {
                    contractId = Convert.ToInt32(row["contract_id"]),
                    amount = Convert.ToDouble(row["amount"]),
                    paymentDate = Convert.ToDateTime(row["payment_date"]),
                    cumulativeAmount = Convert.ToDouble(row["cumulative_amount"]),
                    totalValue = Convert.ToDouble(row["total_value"]),
                    expirationDate = Convert.ToDateTime(row["expiration_date"]),
                    contractCode = row["contract_code"].ToString(),
                };
                paymentStages.Add(stage);
            }

            return paymentStages;
        }
    }

    public class PaymentStage
    {
        public int contractId { get; set; }
        public string contractCode { get; set; }
        public double amount { get; set; }
        public DateTime paymentDate { get; set; }
        public double cumulativeAmount { get; set; }
        public double totalValue { get; set; }
        public DateTime expirationDate { get; set; }
    }
}
