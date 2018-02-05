using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLayer
{
    public class UserManagement
    {
        public bool LoginUser(string Username, string Password)
        {
            if (Username.ToLower() == "admin" && Password == "password")
            {
                return true;
            }
            else
                return false;
        }
    }
}
