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
using System.Windows.Shapes;
using WPFUIKitProfessional.Themes;
using WPFUIKitProfessional.Pages;
using WPFUIKitProfessional.Data.Classes;
using WPFUIKitProfessional.Data.DBClasses;
using WPFUIKitProfessional.Data.Model;

namespace WPFUIKitProfessional.Windws
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
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

        private void txtAuth_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Authorization auth = new Authorization();
            auth.Show();
            this.Close();
        }

        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Password) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("empty fields!");
                return;
            }
            else
            {
                if (DBMethodsFromClient.IsCorrectUser(txtLogin.Text, txtPassword.Password) == false)
                {
                    DBMethodsFromClient.AddAuthorization(txtLogin.Text, txtPassword.Password);
                    DBMethodsFromClient.AddClient(txtName.Text);
                    MainWindow main = new MainWindow(DBMethodsFromClient.Account);
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("user already exists");
                    return;
                }
            }
        }
    }
}
