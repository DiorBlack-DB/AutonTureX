﻿using System;
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
using WPFUIKitProfessional.Data.Classes.DataClasses;

namespace WPFUIKitProfessional.Pages.InformationPage
{
    /// <summary>
    /// Логика взаимодействия для InformationRocketPage.xaml
    /// </summary>
    public partial class InformationRocketPage : Page
    {
        private int count = 0;
        public static SpaceXRockets.Root Rockets;
        public InformationRocketPage(SpaceXRockets.Root rockets)
        {
            Rockets = rockets;
            InitializeComponent();
            this.DataContext = Rockets;
        }
        private void btnAddFavorite_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnWikipedia_Click(object sender, RoutedEventArgs e)
        {
            string path = Rockets.wikipedia;
            NavigationService.Navigate(new WebBrowserPage(path));
        }

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            count++;
            string word = txtDescription.Text.ToString();
            if (count == 1)
            {
                string result = ConnectMethods.TranslateText(DefaultValues.fromLang, DefaultValues.toLang, word);
                txtDescription.Text = result;
            }
            else
            {
                string result = ConnectMethods.TranslateText(DefaultValues.toLang, DefaultValues.fromLang, word);
                txtDescription.Text = result;
            }
        }
    }
}
