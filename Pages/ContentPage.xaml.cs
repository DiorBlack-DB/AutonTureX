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
using WPFUIKitProfessional.Pages;
namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Логика взаимодействия для ContentPage.xaml
    /// </summary>
    public partial class ContentPage : Page
    {
        public ContentPage()
        {
            InitializeComponent();
        }

        private void btnRocketVideo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WebBrowserPage(URLGenerator.Visual));
        }

        private void btnRocketStar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WebBrowserPage(URLGenerator.VisualOne));
        }

        private void btnMoonView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WebBrowserPage(URLGenerator.VisualTwo));
        }

        private void btnWorldView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WebBrowserPage(URLGenerator.VisualThree));
        }
    }
}
