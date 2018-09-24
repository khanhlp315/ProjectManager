using Prism.Regions;
using ProjectManager.ViewModels.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectManager.ViewModels
{
    class AccessingDatabaseViewModel : ViewModelBase
    {
        private IRegionManager _regionManager;
        public async Task<bool> BeingConnecting()
        {
            var isConnected = await BUS.AccessingDatabaseBUS.CreateConnection("Initial Catalog=QuanLyDuAn;Data Source=.;Integrated Security = True");
            return isConnected;
        }

        public AccessingDatabaseViewModel(IRegionManager regionManager)
        {
             _regionManager = regionManager;
            var t = BeingConnecting();
            t.Start();

            t.ContinueWith(task=> {
                if(task.Result)
                    _regionManager.RequestNavigate("ContentRegion", "Login");
             });
        }

        
    }
}
