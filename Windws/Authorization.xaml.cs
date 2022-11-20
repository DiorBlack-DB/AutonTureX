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
using System.Windows.Shapes;
using WPFUIKitProfessional.Data.DBClasses;

namespace WPFUIKitProfessional.Windws
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
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

        private void txtRegistration_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }

        private void btnAuthorization_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                MessageBox.Show("empty fields!");
                return;
            }
            else
            {
                if (DBMethodsFromClient.IsCorrectUser(txtLogin.Text, txtPassword.Password))
                {
                    MainWindow main = new MainWindow(DBMethodsFromClient.Account);
                    MessageBox.Show($"Welcome: {DBMethodsFromClient.Account.Name}");
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("incorrect data");
                    return;
                }
                
            }
        }
    }
}
