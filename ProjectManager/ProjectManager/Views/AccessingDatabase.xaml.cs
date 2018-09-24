using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectManager
{
    /// <summary>
    /// Interaction logic for AccessingDatabaseGUI.xaml
    /// </summary>
    public partial class AccessingDatabase : UserControl
    {
        public AccessingDatabase()
        {
            InitializeComponent();
        }
        public async Task BeingConnecting()
        {
            var isConnected = await BUS.AccessingDatabaseBUS.CreateConnection("Initial Catalog=QuanLyDuAn;Data Source=.;Integrated Security = True");
            if (isConnected)
            {
                //NavigationService.Navigate(new Uri("//ProjectManager;component//LoginGUI.xaml", UriKind.Relative));
                
            }
            else
            {
                MessageBox.Show("Cannot connect to database.",
                            "Error",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);
                MessageTextBlock.Text = "Cannot connect to database.";
                IndeterminateProgressBar.IsIndeterminate = false;
                RetryButton.Visibility = Visibility.Visible;
            }
        }

        //private void Grid_Loaded(object sender, RoutedEventArgs e)
        //{

        //}

        //private async void Page_Loaded(object sender, RoutedEventArgs e)
        //{
        //    //await BeingConnecting();
        //}

        private async void RetryButton_Click(object sender, RoutedEventArgs e)
        {
            MessageTextBlock.Text = "Kết nối đến cơ sở dữ liệu...";
            IndeterminateProgressBar.IsIndeterminate = true;
            RetryButton.Visibility = Visibility.Collapsed;
            await BeingConnecting();
        }
    }
}
