using MahApps.Metro.Controls;
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
using BLL;

namespace Auction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : MetroWindow
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Operations.Registration(Name_Box.Text, Convert.ToSingle(Balance_Box.Text), Password_Box.Password, Email_Box.Text, Convert.ToInt32(Age_Box.Text)) == true)
                    MessageBox.Show("Registration was succesful", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Name [" + Name_Box.Text + "] is busy!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            StartedWindow sw = new StartedWindow();
            sw.Show();
            Close();
        }
    }
}