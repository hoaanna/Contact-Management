using CNPM_FINAL.DTO;
using System;

namespace CNPM_FINAL.Event
{
    public class TaskEventArgs : EventArgs
    {
        public TaskProgressDTO task {  get; set; }
        public TaskEventArgs(TaskProgressDTO taskData)
        {
            task = taskData;
        }
    }
}
