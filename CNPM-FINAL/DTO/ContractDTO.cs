using System;

namespace CNPM_FINAL.DTO
{
    public class ContractDTO
    {
        public int id;
        public string userCode;
        public string contractCode;
        public string contractName;
        public string contractContent;
        public string status;
        public DateTime signedDate;
        public DateTime expiredDate;
        public string origanizationName;
        public string partnerName;
        public string contactEmail;
        public string contactPhone;
        public double totalValue;
        public double commissionPercentage;
        public DateTime createdDate;
        public DateTime updatedDate;
    }
}
