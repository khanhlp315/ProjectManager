using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ProjectManager.Core.UserManagement
{
    interface iUserManagement
    {
        List<User> Manage();
    }
}
