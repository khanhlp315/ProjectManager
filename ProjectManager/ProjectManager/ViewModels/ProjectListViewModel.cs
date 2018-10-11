using Prism.Commands;
using Prism.Regions;
using ProjectManager.Core.UserManagement;
using ProjectManager.ViewModels.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DTO;
using System.Collections.ObjectModel;
using ProjectManager.Core.ProjectManagement;

namespace ProjectManager.ViewModels
{
    class ProjectListViewModel: ViewModelBase
    {
        private IRegionManager _regionManager;
        private ProjectManagementImpl _projectManament;
        public ObservableCollection<Project> ProjectList { get; set; }
        
        

        public ProjectListViewModel(ProjectManagementImpl projectManagement, IRegionManager regionManager)
        {
            _projectManament = projectManagement;
            _regionManager = regionManager;
            ProjectList = _projectManament.Manage();
            
            Console.WriteLine(ProjectList);
        }

        public DelegateCommand UserManagementCommand
        {
            get;
            set;
        }
        protected override void RegisterCommands()
        {
            UserManagementCommand = new DelegateCommand(UserManagement);
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            string id = (string)navigationContext.Parameters["Id"];
        }
        private void UserManagement()
        {
            
            _regionManager.RequestNavigate("ContentRegion", "UserManagement");
        }

    }
}
