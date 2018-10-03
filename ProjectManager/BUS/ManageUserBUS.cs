using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ManageUserBUS
    {
        private UserDAL _userDAL = new UserDAL();
        public List<User> Manage()
        {
            var listUser = _userDAL.GetAllUsers();
            return listUser;
        }
    }
}
