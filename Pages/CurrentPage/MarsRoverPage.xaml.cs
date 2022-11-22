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
using WPFUIKitProfessional.Data.Classes;
using WPFUIKitProfessional.Data.Model;
using static WPFUIKitProfessional.Data.Classes.DataClasses.MarsRover;

namespace WPFUIKitProfessional.Pages.CurrentPage
{
    /// <summary>
    /// Логика взаимодействия для MarsRoverPage.xaml
    /// </summary>
    public partial class MarsRoverPage : Page
    {
        public static Account Account;
        public MarsRoverPage(Account account)
        {
            Account = account;
            InitializeComponent();
            SendRequest();
        }
        public void SendRequest()
        {
            var request = ConnectMethods.CreateRequest(URLGenerator.MarsRoverAllPhoto);
            var photo = ConnectMethods.MarsRover(request);
            lstvRover.ItemsSource = photo.photos;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = cbSolDay.SelectedIndex.ToString();
            string url = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=" + selected + "&api_key=" + $"{APIKEY.NASAKEY}";
            var request = ConnectMethods.CreateRequest(url);
            var photo = ConnectMethods.MarsRover(request);
            lstvRover.ItemsSource = photo.photos;
        }
    }
}
