using System.Collections.Generic;

namespace CNPM_FINAL.DTO
{
    public class UserDTO
    {
        public int id;
        public string code;
        public string fullName;
        public string userName;
        public string roleName;
        public string email;
        public string password;
        public string phone;
        public List<string> permissions = new List<string>();
    }
}
