using ProjectManager.Views;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Modules
{
    class MainModule: IModule
    {
        IRegionManager _regionManager;
        IUnityContainer _container;

        public MainModule(RegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<AccessingDatabase>();

            _container.RegisterTypeForNavigation<Login>();
            _container.RegisterTypeForNavigation<ProjectList>();

            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ProjectList));
        }
    }
}
