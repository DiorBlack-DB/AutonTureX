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

namespace WPFUIKitProfessional.Pages.InformationPage
{
    /// <summary>
    /// Логика взаимодействия для InformationShipPage.xaml
    /// </summary>
    public partial class InformationShipPage : Page
    {
        public static SpaceXShips.Root Ship;
        public InformationShipPage(SpaceXShips.Root ship)
        {
            Ship = ship;
            InitializeComponent();
            this.DataContext = Ship;
            lstvMission.ItemsSource = Ship.missions.ToList();
        }

        private void btnTrace_Click(object sender, RoutedEventArgs e)
        {
            if (Ship.url != null)
            {
                string url = Ship.url;
                string LastUrl = url.Substring(0, url.LastIndexOf('/'));
                string FirstUrl = LastUrl.Remove(0, 51);
                string result = "https://www.marinetraffic.com/en/ais/home/" + FirstUrl + "/zoom:14";
                NavigationService.Navigate(new WebBrowserPage(result));
            }
        }

        private void btnAddFavorite_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
