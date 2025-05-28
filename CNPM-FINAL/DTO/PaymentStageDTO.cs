using System;

namespace CNPM_FINAL.DTO
{
    public class PaymentStageDTO
    {
        public int id;
        public int contractId;
        public string contractCode;
        public string stageName;
        public decimal amount;
        public string status;
        public DateTime paymentDate;
        public string description;
        public double percentage;
    }
}
