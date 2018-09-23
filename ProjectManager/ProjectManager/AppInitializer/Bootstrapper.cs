using System.Windows;
using ProjectManager.Views;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using ProjectManager.Modules;

namespace ProjectManager.AppInitializer
{
    public class Bootstrapper: UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            //Container.RegisterInstances();
        }

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(MainModule));
        }
    }
}
