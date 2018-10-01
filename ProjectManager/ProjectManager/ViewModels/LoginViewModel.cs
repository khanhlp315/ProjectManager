using System.Windows;
using System;
using BUS;
using ProjectManager.Core.Login;
using ProjectManager.ViewModels.Bases;
using Prism.Commands;
using Prism.Regions;
using CommonBUS;
using System.Globalization;

namespace ProjectManager.ViewModels
{
    class LoginViewModel: ViewModelBase
    {
        private string _username;
        private string _password;

        private LoginImpl _login;

        private IRegionManager _regionManager;

        public LoginViewModel(LoginImpl login, IRegionManager regionManager)
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
            //StringValidationRule rule = new StringValidationRule(false,false,StringValidationRule.LimitComparisionType.MoreThanOrEqual,6);
            if(user == null)
            {
                Console.WriteLine("Fail");
                MessageBox.Show("Wrong Username or Password","Login Fail",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                var navigationParameter = new NavigationParameters();
                navigationParameter.Add("id", 1);
                navigationParameter.Add("name", "Khanh");
                navigationParameter.Add("name", new DTO.Member());
                _regionManager.RequestNavigate("ContentRegion", "ProjectList", navigationParameter);
            }
        }
    }
}
