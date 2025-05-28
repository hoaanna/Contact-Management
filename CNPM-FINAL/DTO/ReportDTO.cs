using System;

namespace CNPM_FINAL.DTO
{
    public class ReportDTO
    {
        public string contractCode { get; set; }
        public string contractName { get; set; }
        public string contractStatus { get; set; }
        public double contractValue { get; set; }
        public DateTime signedDate { get; set; }
        public DateTime expirationDate { get; set; }
        public string organizationName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string partner { get; set; }



        public string stageName { get; set; }
        public string stageDescription { get; set; }
        public string paymentStatus { get; set; }
        public DateTime paymentDate { get; set; }
        public double paymentValue { get; set; }
        public double paymentPercentage { get; set; }


    }
}
