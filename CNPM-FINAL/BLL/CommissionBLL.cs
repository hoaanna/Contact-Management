using CNPM_FINAL.DAL;
using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;

namespace CNPM_FINAL.BLL
{
    public class CommissionBLL
    {
        private readonly CommissionDAL commissionDAL = new CommissionDAL();
        private readonly ContractBLL contractBLL = new ContractBLL();

        public List<CommissionDTO> GetAll(string keyword = null, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            var parameters = new Dictionary<string, object> { };
            if (!string.IsNullOrEmpty(keyword))
            {
                parameters.Add("@keyword", keyword);
            }

            if (dateFrom.HasValue && dateTo.HasValue)
            {
                DateTime startDate = new DateTime(dateFrom.Value.Year, dateFrom.Value.Month, 1);
                DateTime endDate = new DateTime(dateTo.Value.Year, dateTo.Value.Month, 1)
                    .AddMonths(1).AddDays(-1);
                parameters.Add("@dateFrom", startDate);
                parameters.Add("@dateTo", endDate);
            }

            return commissionDAL.GetAll(parameters);
        }
    }
}
