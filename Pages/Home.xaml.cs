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

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public static Account Account;
        public Home(Account account)
        {
            Account = account;
            InitializeComponent();
            BindingData();
        }
        private void BindingData()
        {
            this.DataContext = Account; 
        }
        private void btnEditData_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("empty fields!");
                return;
            }
            else
            {
                DBMethodsFromClient.EditDataAccount(txtLogin.Text, txtPassword.Text, txtName.Text, txtSurName.Text);
                NavigationService.Navigate(new Home(Account));
            }
        }

        private void imgClien_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DBMethodsFromClient.EditImageClient(Account);
        }
    }
}
