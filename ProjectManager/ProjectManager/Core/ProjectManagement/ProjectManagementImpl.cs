using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;

namespace ProjectManager.Core.ProjectManagement
{
    public class ProjectManagementImpl : iProjectManagement
    {
        private readonly ManageProjectBUS _manageProjectBUS = new ManageProjectBUS();
        public ObservableCollection<Project> Manage()
        {
            try
            {
                var listProject = _manageProjectBUS.Manage();
                return listProject;
            }
            catch (Exception e)
            {
                return null;
            }
    }
    }
}
