using CNPM_FINAL.Context;
using CNPM_FINAL.DAL;
using CNPM_FINAL.DTO;
using System;
using System.Collections.Generic;

namespace CNPM_FINAL.BLL
{
    public class ContractBLL
    {
        private readonly ContractDAL contractDAL = new ContractDAL();
        private readonly TaskProgressDAL taskProgressDAL = new TaskProgressDAL();
        private readonly PaymentStageDAL paymentStageDAL = new PaymentStageDAL();
        private readonly CommissionDAL commissionDAL = new CommissionDAL();
        private readonly UserDAL userDAL = new UserDAL();

        public void Insert(ContractDTO contract)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@contractCode", contract.contractCode },
                { "@userId", UserContext.GetUserId() },
                { "@commissionPercentage", contract.commissionPercentage },
                { "@contractName", contract.contractName },
                { "@contractContent", contract.contractContent },
                { "@signedDate", contract.signedDate },
                { "@expiredDate", contract.expiredDate },
                { "@partnerName", contract.partnerName },
                { "@contactEmail", contract.contactEmail },
                { "@contactPhone", contract.contactPhone },
                { "@totalValue", contract.totalValue },
                { "@organizationName", contract.origanizationName }
            };

            contractDAL.Insert(parameters);
        }

        public void Update(ContractDTO contract, string oldContractCode)
        {
            var user = userDAL.GetOneByUserCode(contract.userCode);
            if (user == null)
            {
                var message = SettingContext.Language == "en" ? "User not found" : "Không tìm thấy người dùng";
                throw new BuisinessException(message);
            }

            var parameters = new Dictionary<string, object>
            {
                { "@oldContractCode", oldContractCode },
                { "@newContractCode", contract.contractCode },
                { "@userId", user.id },
                { "@commissionPercentage", contract.commissionPercentage },
                { "@contractName", contract.contractName },
                { "@contractContent", contract.contractContent },
                { "@signedDate", contract.signedDate },
                { "@expiredDate", contract.expiredDate },
                { "@partnerName", contract.partnerName },
                { "@contactEmail", contract.contactEmail },
                { "@contactPhone", contract.contactPhone },
                { "@organizationName", contract.origanizationName }
            };
            contractDAL.Update(parameters);
        }

        public void Delete(string contractCode)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@contractCode", contractCode }
            };

            if (paymentStageDAL.ExistByContractCode(parameters))
            {
                var message = SettingContext.Language == "en" ? 
                    "Contract has payment stage, cannot delete" : "Hợp đồng đã có lịch thanh toán, không thể xóa";
                throw new BuisinessException(message);
            }

            if (taskProgressDAL.ExistByContractCode(parameters))
            {
                var message = SettingContext.Language == "en" ?
                    "Contract has task progress, cannot delete" : "Hợp đồng đã có tiến độ công việc, không thể xóa";
                throw new BuisinessException(message);
            }

            contractDAL.Delete(contractCode);
        }

        public ContractDTO GetOneByCode(string contractCode) =>  contractDAL.GetOneByCode(contractCode);

        public List<ContractDTO> GetAll(string keyword, DateTime dateFrom, DateTime dateTo, bool hasSignedDate, bool hasExpirarionDate)
        {
            var parameters = new Dictionary<string, object> {
                {"@keyword", keyword }
            };

            if (hasSignedDate || hasExpirarionDate)
            {
                parameters.Add("@dateFrom", dateFrom);
                parameters.Add("@dateTo", dateTo);
            }

            if (UserContext.GetRoleName() == "Sale" || UserContext.GetRoleName() == "Accountant")
            {
                parameters.Add("@userId", UserContext.GetUserId());
            }

            return contractDAL.GetAll(parameters, hasSignedDate, hasExpirarionDate);
        }

        public List<string> GetAllContractCodes(string keyword)
        {
            var parameters = new Dictionary<string, object> { };
            parameters.Add("@keyword", keyword);

            if (UserContext.GetRoleName() == "Sale")
            {
                parameters.Add("@userId", UserContext.GetUserId());
            }

            return contractDAL.GetAllContractCode(parameters);
        }
    }
}
