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

namespace Auction
{
    /// <summary>
    /// Interaction logic for SignInRoom.xaml
    /// </summary>
    public partial class SignInRoom : Window
    {
        public SignInRoom()
        {
            InitializeComponent();
        }
      
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            string name = Name_Box.Text;
            string password = Password_Box.Text;

            using (Model1 m1 = new Model1())
            {
                if (m1.Users.FirstOrDefault(x => x.NickName == name && x.Password == password) == null)
                {
                    
                }
                
            }

                MainWindow mw = new MainWindow();
                mw.Show();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            StartedWindow sw = new StartedWindow();
            sw.Show();
            Close();
        }
    }
}
