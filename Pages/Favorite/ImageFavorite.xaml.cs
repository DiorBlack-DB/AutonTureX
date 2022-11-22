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
using System.Windows.Markup;
using static WPFUIKitProfessional.Data.Classes.DataClasses.MarsRover;

namespace WPFUIKitProfessional.Pages.Favorite
{
    /// <summary>
    /// Логика взаимодействия для ImageFavorite.xaml
    /// </summary>
    public partial class ImageFavorite : Page
    {
        public static Account Account;
        private string Year = null;
        private string Month = null;
        private string Day = null;
        public ImageFavorite(Account account)
        {
            Account = account;
            InitializeComponent();
            lstvImage.ItemsSource = DBConnection.connect.ImageDateFavorite.Where(i => i.idClient == Account.id).ToList();
        }

        private void DPSelect_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = (DateTime)(((DatePicker)sender).SelectedDate);
            Year = date.Year.ToString();
            Month = date.Month.ToString();
            Day = date.Day.ToString();
            if (Year != null && Month != null && Day != null)
            {
                string google = $"{Year} - {Month} - {Day}";
                DBConnection.connect.ImageDateFavorite.Where(i => i.idClient == Account.id && i.ImageGetter.date == google).ToList();
            }
        }
        
    }
}
