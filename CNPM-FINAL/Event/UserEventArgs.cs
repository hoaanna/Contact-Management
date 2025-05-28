using CNPM_FINAL.DTO;
using System;

namespace CNPM_FINAL.Event
{
    public class UserEventArgs : EventArgs
    {
        public UserDTO user { get; set; }
        public UserEventArgs(UserDTO userDTO)
        {
            user = userDTO;
        }
    }
}
