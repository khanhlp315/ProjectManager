using System;
using BUS;
using ProjectManager.Core.Login;
using ProjectManager.ViewModels.Bases;
using Prism.Commands;
using Prism.Regions;

namespace ProjectManager.ViewModels
{
    class LoginViewModel: ViewModelBase
    {
        private string _username;
        private string _password;

        private ILogin _login;

        private IRegionManager _regionManager;

        public LoginViewModel(ILogin login, IRegionManager regionManager)
        {
            _login = login;
            _regionManager = regionManager;
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                SetProperty(ref _username, value);
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                SetProperty(ref _password, value);
            }
        }

        public DelegateCommand LoginCommand
        {
            get;
            set;
        }

        protected override void RegisterCommands()
        {
            LoginCommand = new DelegateCommand(Login);
        }

        private void Login()
        {
            var user = _login.Login(Username, Password);
            if(user == null)
            {
                
            }
            else
            {
                _regionManager.RequestNavigate("ContentRegion", "ProjectList");
            }
        }
    }
}
