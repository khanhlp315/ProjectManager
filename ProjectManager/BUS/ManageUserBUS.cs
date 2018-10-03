using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Collections.ObjectModel;

namespace BUS
{
    public class ManageUserBUS
    {
        private UserDAL _userDAL = new UserDAL();
        public ObservableCollection<User> Manage()
        {
            var listUser = _userDAL.GetAllUsers();
            return listUser;
        }
    }
}
