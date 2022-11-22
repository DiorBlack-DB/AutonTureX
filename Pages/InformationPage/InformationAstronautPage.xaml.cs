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
    /// Логика взаимодействия для InformationAstronautPage.xaml
    /// </summary>
    public partial class InformationAstronautPage : Page
    {
        private int count = 0;
        public static Astronauts.Result Astronaut;
        public InformationAstronautPage(Astronauts.Result astronaut)
        {
            Astronaut = astronaut;
            InitializeComponent();
            this.DataContext = Astronaut;
        }

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            count++;
            string word = txtbio.Text.ToString();
            if (count == 1)
            {
                string result = ConnectMethods.TranslateText(DefaultValues.fromLang, DefaultValues.toLang, word);
                txtbio.Text = result;
            }
            else
            {
                string result = ConnectMethods.TranslateText(DefaultValues.toLang, DefaultValues.fromLang, word);
                txtbio.Text = result;
            }
        }

        private void btnAddFavorite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnWikipedia_Click(object sender, RoutedEventArgs e)
        {
            string url = Astronaut.wiki;
            if (url != null)
            {
                NavigationService.Navigate(new WebBrowserPage(url));
            }
            
        }
    }
}
