using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;
using BUS.Exceptions;

namespace ProjectManager.Core.Login
{
    public class LoginImpl  
    {
        private readonly LoginBUS _loginBUS = new LoginBUS();
        public User Login(string username, string password)
        {
            try
            {
                //var user = _loginBUS.Login(username, password);
                //return user;
            }
            catch (CheckedException)
            {
                return null;
            }
        }
    }
}
