using System;

namespace CNPM_FINAL.Event
{
    public class TaskDetailEventArgs : EventArgs
    {
        public string contractCode { get; set; }
        public TaskDetailEventArgs(string contractCode)
        {
            this.contractCode = contractCode;
        }
    }
}
