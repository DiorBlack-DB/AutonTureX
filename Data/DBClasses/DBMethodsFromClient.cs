using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WPFUIKitProfessional.Data.Classes;
using WPFUIKitProfessional.Data.Model;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPFUIKitProfessional.Data.DBClasses
{
    internal class DBMethodsFromClient
    {
        public static Account Account;
        public static Authorization Authorization;
        public static ObservableCollection<Account> GetAccounts()
        {
            return new ObservableCollection<Account>(DBConnection.connect.Account);
        }
        public static ObservableCollection<Authorization> GetAuthorizations()
        {
            return new ObservableCollection<Authorization>(DBConnection.connect.Authorization);
        }
        public static Authorization GetAuthorization(string login, string password)
        {
            return GetAuthorizations().FirstOrDefault(a => a.Login == login && a.Password == password);
        }
        public static Authorization GetAuthorization(string login)
        {
            return GetAuthorizations().FirstOrDefault(a => a.Login == login);
        }
        public static Account GetAccount(string login, string password)
        {
            return GetAccounts().FirstOrDefault(a => a.Authorization.Login == login && a.Authorization.Password == password);
        }
        public static bool IsCorrectUser(string login, string password)
        {
            ObservableCollection<Account> accounts = new ObservableCollection<Account>(DBConnection.connect.Account);
            var currentUser = accounts.Where(u => u.Authorization.Password == password && u.Authorization.Login == login).FirstOrDefault();
            Account = currentUser;
            return currentUser != null;
        }
        public static void EditImageClient(Account oldClient)
        {
            var getuser = GetAccount(oldClient.Authorization.Login, oldClient.Authorization.Password);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                getuser.Image = File.ReadAllBytes(openFileDialog.FileName);
            }
            DBConnection.connect.SaveChanges();
        }
        public static void EditDataAccount(string login, string password, string name, string lastname)
        {
            var getAccount = GetAccount(login, password);
            if (getAccount != null)
            {
                getAccount.Surname = lastname;
                getAccount.Name = name;
                DBConnection.connect.SaveChanges();
                MessageBox.Show("data has changed");
            }
        }
        public static void AddAuthorization(string login, string password)
        {
            var getAuth = GetAuthorization(login);
            if (getAuth == null)
            {
                Authorization authorization = new Authorization
                {
                    Login = login,
                    Password = password
                };
                Authorization = authorization;
                DBConnection.connect.Authorization.Add(authorization);
                DBConnection.connect.SaveChanges();
            }
            else
            {
                MessageBox.Show("user already exists");
                return;
            }
        }
        public static void AddClient(string name)
        {
            if (Authorization != null)
            {
                byte[] image = File.ReadAllBytes("account.png");
                Account client = new Account
                {
                    idAuth = Authorization.id,
                    Name = name,
                    Image = image
                };
                Account = client;
                DBConnection.connect.Account.Add(client);
                DBConnection.connect.SaveChanges();
            }
            else
            {
                return;
            }
        }
    }
}
