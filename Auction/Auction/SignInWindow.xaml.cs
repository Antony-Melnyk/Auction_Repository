using DAL;
using DAL.Migrations;
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
using MahApps.Metro.Controls;
using BLL;

namespace Auction
{
    /// <summary>
    /// Interaction logic for SignInRoom.xaml
    /// </summary>
    public partial class SignInWindow : MetroWindow
    {
        public SignInWindow()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            if (Operations.SignIn(Name_Box.Text, Password_Box.Password) == true)
            {
                Close();
                MainWindow mw = new MainWindow();
                mw.userName.Content = Name_Box.Text;
                mw.Show();
                Application.Current.Windows[0].Close();
            }
            else
                MessageBox.Show("Error. Check your login and password", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}