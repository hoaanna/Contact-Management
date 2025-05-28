using System;

namespace CNPM_FINAL.DTO
{
    public class TaskProgressDTO
    {
        public int id;
        public string contractCode;
        public string contractName;
        public string contractOrganization;
        public double percentage;
        public DateTime signedDate;
        public DateTime expirationDate;

        public string taskName;
        public string assignedTo;
        public string assignedToName;
        public DateTime startDate;
        public DateTime endDate;
        public string status;
    }
}
