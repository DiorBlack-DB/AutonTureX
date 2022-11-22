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
using WPFUIKitProfessional.Data.Classes.DataClasses;
using WPFUIKitProfessional.Data.Classes;
using WPFUIKitProfessional.Data.DBClasses;
using WPFUIKitProfessional.Data.Model;
using WPFUIKitProfessional.Pages.Favorite;

namespace WPFUIKitProfessional.Pages.Favorite
{
    /// <summary>
    /// Логика взаимодействия для RocketFavoritePage.xaml
    /// </summary>
    public partial class RocketFavoritePage : Page
    {
        public static Account Account;
        public RocketFavoritePage(Account account)
        {
            Account = account;
            InitializeComponent();
            lstvRocketX.ItemsSource = DBConnection.connect.RocketsXFavorite.Where(a=>a.idClient == Account.id).ToList();
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                lstvRocketX.ItemsSource = DBConnection.connect.RocketsXFavorite.Where(a => a.idClient == Account.id && a.RocketsX.name == txtName.Text).ToList();
            }
            else
            {
                lstvRocketX.ItemsSource = DBConnection.connect.RocketsXFavorite.Where(a => a.idClient == Account.id && a.RocketsX.name == txtName.Text && a.RocketsX.country == txtCountry.Text).ToList();
            }
            
        }

        private void txtCountry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lstvRocketX.ItemsSource = DBConnection.connect.RocketsXFavorite.Where(a => a.idClient == Account.id && a.RocketsX.country == txtCountry.Text).ToList();
            }
            else
            {
                lstvRocketX.ItemsSource = DBConnection.connect.RocketsXFavorite.Where(a => a.idClient == Account.id && a.RocketsX.name == txtName.Text && a.RocketsX.country == txtCountry.Text).ToList();
            }
        }
    }
}
