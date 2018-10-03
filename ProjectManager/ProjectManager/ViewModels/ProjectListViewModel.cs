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

namespace ProjectManager.ViewModels
{
    class ProjectListViewModel: ViewModelBase
    {
        private UserManagementImpl _userManagement;

        private IRegionManager _regionManager;
        

        public ProjectListViewModel(UserManagementImpl userManagement, IRegionManager regionManager)
        {
            _userManagement = userManagement;
            _regionManager = regionManager;
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
            var UserList = _userManagement.Manage();
            var navigationParameter = new NavigationParameters();
            navigationParameter.Add("UserList", UserList);
            _regionManager.RequestNavigate("ContentRegion", "UserManagement", navigationParameter);
        }

    }
}
