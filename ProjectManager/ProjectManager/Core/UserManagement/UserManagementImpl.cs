using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;
using System.Collections.ObjectModel;

namespace ProjectManager.Core.UserManagement
{
    class UserManagementImpl : iUserManagement
    {
        private readonly ManageUserBUS _manageUserBUS = new ManageUserBUS();
        public ObservableCollection<User> Manage()
        {
            try
            {
                var listUser = _manageUserBUS.Manage();
                return listUser;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
