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

namespace Worldyachts
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            var LoginText = LoginBox.Text;
            var PasswordText = Password.Password.Trim();
            App.getDb().User.Find(user => user.Login == LoginText);

            new Windows.MainWindow().Show();
        }

        private void GuestLogin(object sender, RoutedEventArgs e)
        {
            
            new Windows.MainWindow().Show();
        }
    }
}
