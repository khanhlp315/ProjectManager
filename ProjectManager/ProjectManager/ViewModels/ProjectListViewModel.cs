using Prism.Regions;
using ProjectManager.ViewModels.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.ViewModels
{
    class ProjectListViewModel: ViewModelBase
    {
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            string id = (string)navigationContext.Parameters["Id"];
        }

    }
}
