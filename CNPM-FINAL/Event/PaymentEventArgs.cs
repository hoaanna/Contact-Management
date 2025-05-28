using CNPM_FINAL.DTO;
using System;

namespace CNPM_FINAL.Event
{
    public class PaymentEventArgs : EventArgs
    {
        public PaymentStageDTO payment {  get; set; }
        public PaymentEventArgs(PaymentStageDTO paymentData)
        {
            payment = paymentData;
        }
    }
}
