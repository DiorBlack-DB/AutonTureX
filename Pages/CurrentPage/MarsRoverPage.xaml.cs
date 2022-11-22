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
            //var request = ConnectMethods.CreateRequest(URLGenerator.MarsRoverAllPhoto);
            //var photo = ConnectMethods.MarsRover(request);
            //itemsControl.ItemsSource = photo.photos;

        }
    }
}
