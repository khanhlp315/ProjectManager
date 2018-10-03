using ProjectManager.AppInitializer;
using System;
using System.Windows;
using System.Windows.Controls;

using System.Collections.ObjectModel;

namespace GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new Bootstrapper().Run();
        }
        private void SelectAll_Checked(object sender, RoutedEventArgs e)
        {
            //DataGrid dataGrid = ((CheckBox)sender).DataContext;
            //dataGrid.SelectAll();
        }
    }
}
