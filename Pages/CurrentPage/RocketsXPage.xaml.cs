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
using WPFUIKitProfessional.Data.DBClasses;
using WPFUIKitProfessional.Data.Classes;
using WPFUIKitProfessional.Data.Model;
using WPFUIKitProfessional.Data.Classes.DataClasses;
using WPFUIKitProfessional.Pages.InformationPage;
using System.Security.Principal;

namespace WPFUIKitProfessional.Pages.CurrentPage
{
    /// <summary>
    /// Логика взаимодействия для RocketsXPage.xaml
    /// </summary>
    public partial class RocketsXPage : Page
    {
        public static Account Account;
        public RocketsXPage(Account account)
        {
            Account = account;
            InitializeComponent();
            SendRequest();
        }
        private void SendRequest()
        {
            var request = ConnectMethods.CreateRequest(URLGenerator.SpaceXAllRocket);
            var rocket = ConnectMethods.RocketsX(request);
            lstvRocketX.ItemsSource = rocket;
        }

        private void lstvRocketX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectRocket = lstvRocketX.SelectedItem as SpaceXRockets.Root;
            NavigationService.Navigate(new InformationRocketPage(selectRocket));
        }
    }
}
