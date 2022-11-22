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
    /// Логика взаимодействия для AstronautPage.xaml
    /// </summary>
    public partial class AstronautPage : Page
    {
        public static Account Account;
        public AstronautPage(Account account)
        {
            Account = account;
            InitializeComponent();
            SendRequest();
        }
        private void SendRequest()
        {
            var request = ConnectMethods.ReadJsonFile("Astronaut.json");
            var result = ConnectMethods.Astronaut(request);
            lstvAstronaut.ItemsSource = result.results;
        }

        private void lstvAstronaut_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectAstronaut = lstvAstronaut.SelectedItem as Astronauts.Result;
            NavigationService.Navigate(new InformationAstronautPage(selectAstronaut));
        }
    }
}
