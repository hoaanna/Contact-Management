using CNPM_FINAL.Context;
using CNPM_FINAL.DAL;
using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;

namespace CNPM_FINAL.BLL
{
    public class PaymentStageBLL
    {
        private readonly PaymentStageDAL paymentStageDAL = new PaymentStageDAL();
        private readonly ContractDAL contractDAL = new ContractDAL();

        public void Insert(PaymentStageDTO paymentStage)
        {
            var contract = contractDAL.GetOneByCode(paymentStage.contractCode);
            if (contract == null)
            {
                var message = SettingContext.Language == "en" ? "Contract code is not exist" : "Mã hợp đồng không tồn tại";
                throw new BuisinessException(message);
            }

            var parameters = new Dictionary<string, object>
            {
                { "@contractId", contract.id },
                { "@stageName", paymentStage.stageName },
                { "@amount", paymentStage.amount },
                { "@paymentDate", paymentStage.paymentDate },
                { "@description", paymentStage.description },
                { "@status", paymentStage.status }
            };
            paymentStageDAL.Insert(parameters);
        }

        public void Delete(int id) => paymentStageDAL.Delete(id);

        public void Update(PaymentStageDTO paymentStage)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@stageName", paymentStage.stageName },
                { "@amount", paymentStage.amount },
                { "@paymentDate", paymentStage.paymentDate },
                { "@description", paymentStage.description },
                { "@id", paymentStage.id },
                { "@status", paymentStage.status }
            };
            paymentStageDAL.Update(parameters);
        }

        public List<PaymentStageDTO> GetAll(string keyword = null, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            var parameters = new Dictionary<string, object> { };
            if (!string.IsNullOrEmpty(keyword))
            {
                parameters.Add("@keyword", keyword);
            }

            if (dateFrom.HasValue && dateTo.HasValue)
            {
                parameters.Add("@dateFrom", dateFrom.Value);
                parameters.Add("@dateTo", dateTo.Value);
            }

            if (UserContext.GetRoleName() == "Sale")
            {
                parameters.Add("@userId", UserContext.GetUserId());
            }

            return paymentStageDAL.GetAll(parameters);
        }

        public PaymentStageDTO GetById(int id)
        {
            var parameters = new Dictionary<string, object> { };
            parameters.Add("@id", id);

            return paymentStageDAL.GetOneById(parameters);
        }
    }
}
