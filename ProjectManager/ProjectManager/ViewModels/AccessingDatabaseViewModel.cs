using Prism.Regions;
using ProjectManager.ViewModels.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.ViewModels
{
    class AccessingDatabaseViewModel: ViewModelBase
    {
        private IRegionManager _regionManager;

        public AccessingDatabaseViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            var t = BeginConnecting();
            t.ContinueWith(task =>
            {
                if(task.Result)
                {
                    _regionManager.RequestNavigate("ContentRegion", "Login");
                }
                else
                {
                    Retry();
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public async Task<bool> BeginConnecting()
        {
            return await BUS.AccessingDatabaseBUS.CreateConnection("Initial Catalog=QuanLyDuAn;Data Source=.;Integrated Security = True");
        }

        public void Retry()
        {

        }
    }
}
