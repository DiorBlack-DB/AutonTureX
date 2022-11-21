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
using WPFUIKitProfessional.Themes;
using WPFUIKitProfessional.Pages;
using WPFUIKitProfessional.Pages.CurrentPage;
using WPFUIKitProfessional.Data.Classes;
using WPFUIKitProfessional.Data.DBClasses;
using WPFUIKitProfessional.Data.Model;
using WPFUIKitProfessional.Windws;

namespace WPFUIKitProfessional
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Account Account;
        public MainWindow(Account account)
        {
            Account = account;
            InitializeComponent();
            frameContent.Navigate(new Home(Account));
        }

        private void Themes_Click(object sender, RoutedEventArgs e)
        {
            if (Themes.IsChecked == true)
                ThemesController.SetTheme(ThemesController.ThemeTypes.Dark);
            else
                ThemesController.SetTheme(ThemesController.ThemeTypes.Light);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdHome_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Home(Account));
        }

        private void home_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                    this.DragMove();
            }
            catch (System.InvalidOperationException)
            {
                return;
            }
        }

        private void rdSettings_Click(object sender, RoutedEventArgs e)
        {
            Windws.Authorization authorization = new Windws.Authorization();
            authorization.Show();
            this.Close();
        }

        private void rdFavorite_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Home(Account));
        }

        private void rdRocketX_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new RocketsXPage(Account));
            //frameContent.Navigate(new WebBrowserPage());
        }

        private void rdShipsX_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new ShipsXPage(Account));
        }

        private void rdImage_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new ImagePickerPage(Account));
        }
    }
}
