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
    /// Логика взаимодействия для ShipsXPage.xaml
    /// </summary>
    public partial class ShipsXPage : Page
    {
        public static Account Account;
        public ShipsXPage(Account account)
        {
            Account = account;
            InitializeComponent();
            SendRequest();
        }
        private void SendRequest()
        {
            var request = ConnectMethods.CreateRequest(URLGenerator.SpaceXAllShips);
            var result = ConnectMethods.ShipsX(request);
            lstvShipsX.ItemsSource = result;
        }

        private void lstvShipsX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectShip = lstvShipsX.SelectedItem as SpaceXShips.Root;
            NavigationService.Navigate(new InformationShipPage(selectShip, Account));
        }
    }
}
