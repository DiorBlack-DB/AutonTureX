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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFUIKitProfessional.Data.Classes;
using WPFUIKitProfessional.Data.Model;

namespace WPFUIKitProfessional.Pages.CurrentPage
{
    /// <summary>
    /// Логика взаимодействия для RoadsterPage.xaml
    /// </summary>
    public partial class RoadsterPage : Page
    {
        private int count = 0;
        private int size = 0;
        private dynamic data = null;
        private int listsize = 0;
        public static Account Account;
        public RoadsterPage(Account account)
        {
            Account = account;
            InitializeComponent();
            SendRequest();
        }
        private void SendRequest()
        {
            var request = ConnectMethods.CreateRequest(URLGenerator.RoadsterX);
            var result = ConnectMethods.RoadsterX(request);
            this.DataContext = result;
            data = result;
            imgRoad.Source = new BitmapImage(new Uri(result.flickr_images[0], UriKind.RelativeOrAbsolute));
            size = result.flickr_images.Count;
        }
        private void imgRoad_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                listsize++;
                if (listsize < size)
                {
                    imgRoad.Source = new BitmapImage(new Uri(data.flickr_images[listsize], UriKind.RelativeOrAbsolute));
                }
                else
                {
                    listsize = 0;
                    imgRoad.Source = new BitmapImage(new Uri(data.flickr_images[listsize], UriKind.RelativeOrAbsolute));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("return");
                return;
            }
        }

        private void btnFavoriteAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                count++;
                if (count == 1)
                {
                    var translate = ConnectMethods.TranslateText(DefaultValues.fromLang, DefaultValues.toLang, txtDescription.Text);
                    txtDescription.Text = translate;
                }
                else
                {
                    var translate = ConnectMethods.TranslateText(DefaultValues.toLang, DefaultValues.fromLang, txtDescription.Text);
                    txtDescription.Text = translate;
                    count = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("return");
                return;
            }
        }

        private void btnVideo_Click(object sender, RoutedEventArgs e)
        {
            string VideoUrl = data.video;
            NavigationService.Navigate(new WebBrowserPage(VideoUrl));
        }

        private void btnWikipedia_Click(object sender, RoutedEventArgs e)
        {
            string WikipediaUrl = data.wikipedia;
            NavigationService.Navigate(new WebBrowserPage(WikipediaUrl));
        }
    }
}
