﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Collections.ObjectModel;

namespace ProjectManager.Core.UserManagement
{
    interface iUserManagement
    {
        ObservableCollection<User> Manage();
    }
}
