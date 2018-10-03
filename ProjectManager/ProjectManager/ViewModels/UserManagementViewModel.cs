using DTO;
using Prism.Regions;
using ProjectManager.Core.UserManagement;
using ProjectManager.ViewModels.Bases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.ViewModels
{
    class UserManagementViewModel : ViewModelBase,INavigationAware, INotifyPropertyChanged
    {
        private UserManagementImpl _userManagement;
        private IRegionManager _regionManager;
        public ObservableCollection<User> UserList { get; set; }
        public string Textblock = "Binded this one";
        public string Username { get; set; }
        public int Permission { get; set; }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            UserList = (ObservableCollection<User>)navigationContext.Parameters["UserList"];
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public UserManagementViewModel(UserManagementImpl userManagement, IRegionManager regionManager)
        {
            //UserList = _userManagement.Manage();
            _userManagement = userManagement;
            _regionManager = regionManager;
            UserList = _userManagement.Manage();
            Console.WriteLine(UserList);
        }
        
    }
}
