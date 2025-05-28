using CNPM_FINAL.DAL;
using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;

namespace CNPM_FINAL.BLL
{
    public class ReportBLL
    {
        private readonly ReportDAL reportDAL = new ReportDAL();

        public List<ReportDTO> GetContracts(string keyword, DateTime dateFrom, DateTime dateTo, 
            bool hasSignedDate, bool hasExpirationDate, string status = null)
        {
            var parameters = new Dictionary<string, object>{
                {"@keyword", keyword }
            };
            if (hasSignedDate || hasExpirationDate)
            {
                parameters.Add("@dateFrom", dateFrom);
                parameters.Add("@dateTo", dateTo);
            }

            if (status != null)
            {
                parameters.Add("@status", status);
            }


            return reportDAL.GetContracts(parameters, hasSignedDate, hasExpirationDate);
        }

        public List<ReportDTO> GetPayments(string keyword, DateTime dateFrom, DateTime dateTo, bool hasDate)
        {
            var parameters = new Dictionary<string, object>{
                {"@keyword", keyword }
            };
            if (hasDate)
            {
                parameters.Add("@dateFrom", dateFrom);
                parameters.Add("@dateTo", dateTo);
            }


            var payments =  reportDAL.GetPayments(parameters, hasDate);
            return payments;
        }
    }
}
