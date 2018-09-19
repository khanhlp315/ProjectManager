using ProjectManager.ViewModels.Bases;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.ViewModels
{
    class MainWindowViewModel: ViewModelBase
    {
        private readonly IRegionManager _regionManager;
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
    }
}
