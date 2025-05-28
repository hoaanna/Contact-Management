using CNPM_FINAL.DAL;
using CNPM_FINAL.DTO;
using System.Collections.Generic;
using System;

namespace CNPM_FINAL.BLL
{
    public class SettingBLL
    {
        private readonly SettingDAL settingDAL = new SettingDAL();

        public List<SettingDTO> GetAll(DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            var parameters = new Dictionary<string, object> { };
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                parameters.Add("@dateFrom", dateFrom);
                parameters.Add("@dateTo", dateTo);
            }
            return settingDAL.GetAll(parameters);
        }

        public SettingDTO GetCurrentDate()
        {
            var parameters = new Dictionary<string, object> { };

            return settingDAL.GetCurrentDate(parameters);
        }

        public void Insert(SettingDTO historyCommission)
        {
            var parameters = new Dictionary<string, object>
            {
                {"@value", historyCommission.value },
                {"@effectiveDate", historyCommission.effectiveDate }
            };
            settingDAL.Insert(parameters);
        }
    }
}
