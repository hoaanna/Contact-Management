using CNPM_FINAL.DTO;
using System;

namespace CNPM_FINAL.Event
{
    public class ContractEventArgs : EventArgs
    {
        public ContractDTO contract {  get; set; }
        public ContractEventArgs(ContractDTO contrtactData)
        {
            contract = contrtactData;
        }
    }
}
