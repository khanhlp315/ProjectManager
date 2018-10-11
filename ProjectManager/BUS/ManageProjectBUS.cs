using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ManageProjectBUS
    {
        private ProjectDAL _projectDAL = new ProjectDAL();
        public ObservableCollection<Project> Manage()
        {
            var listProject = _projectDAL.GetAllProjects();
            return listProject;
        }
    }
}
