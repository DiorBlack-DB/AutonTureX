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

namespace WPFUIKitProfessional.Pages
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
            BindingData();
        }
        private void BindingData()
        {

        }
        private void lstvRocketX_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
