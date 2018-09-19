using ProjectManager.Core.Login;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Regions;
using Prism.Unity;
using ProjectManager.Views;

namespace ProjectManager.AppInitializer
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            container.RegisterType<ILogin, LoginImpl>();
            return container;
        }
    }
}
