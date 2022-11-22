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
    /// Логика взаимодействия для ImagePickerPage.xaml
    /// </summary>
    public partial class ImagePickerPage : Page
    {
        private int count = 0;
        private string Year = null;
        private string Month = null;
        private string Day = null;
        public static Account Account;
        dynamic data;
        public ImagePickerPage(Account account)
        {
            Account = account;
            InitializeComponent();
            DateTime dateTime = DateTime.Now;
            DPSelect.DisplayDateEnd = DateTime.Today;
            DPSelect.SelectedDate = dateTime.AddDays(-1);
        }
        public void SendRequest()
        {
            try
            {
                var info = ConnectMethods.CreateRequest(URLGenerator.ImageUrl + $"{Year}-{Month}-{Day}");
                var photo = ConnectMethods.DayPhotoReport(info);
                txtTitle.Text = photo.title;
                ExplanationTxt.Text = photo.explanation;
                ImgCosmos.Source = new BitmapImage(new Uri(photo.hdurl, UriKind.RelativeOrAbsolute));
                data = photo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("connect error" + ex);
                return;
            }

        }
        private void DPSelect_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = (DateTime)(((DatePicker)sender).SelectedDate);
            Year = date.Year.ToString();
            Month = date.Month.ToString();
            Day = date.Day.ToString();
            if (Year != null && Month != null && Day != null)
            {
                SendRequest();
            }
        }

        private void btnAddFavorite_Click(object sender, RoutedEventArgs e)
        {
            var getimage = DBMethodsFromFavorite.GetImageGetter(data.date);
            if (getimage == null)
            {
                Data.Model.ImageGetter imageGetter = new Data.Model.ImageGetter
                {
                    date = data.date,
                    image = data.hdurl,
                    media_type = data.media_type,
                    title = data.title
                };
                DBConnection.connect.ImageGetter.Add(imageGetter);
                DBConnection.connect.SaveChanges();
            }
            var getimages = DBMethodsFromFavorite.GetImageGetter(data.date);
            ImageDateFavorite favorite = new ImageDateFavorite
            {
                idClient = Account.id,
                idImage = getimages.id
            };
            DBConnection.connect.ImageDateFavorite.Add(favorite);
            DBConnection.connect.SaveChanges();
        }

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            count++;
            string word = ExplanationTxt.Text.ToString();
            if (count == 1)
            {
                string result = ConnectMethods.TranslateText(DefaultValues.fromLang, DefaultValues.toLang, word);
                ExplanationTxt.Text = result;
            }
            else
            {
                string result = ConnectMethods.TranslateText(DefaultValues.toLang, DefaultValues.fromLang, word);
                ExplanationTxt.Text = result;
            }
        }
    }
}
