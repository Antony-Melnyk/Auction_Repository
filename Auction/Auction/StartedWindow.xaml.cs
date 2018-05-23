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
    /// Interaction logic for StartedWindow.xaml
    /// </summary>
    public partial class StartedWindow : Window
    {
        public StartedWindow()
        {
            InitializeComponent();
        }


        private void SignIn_Btn_Click(object sender, RoutedEventArgs e)
        {
            SignInRoom sir = new SignInRoom();
            sir.Show();
            this.Close();
        }

        private void Registration_Btn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow rw = new RegistrationWindow();
            rw.Show();
            this.Close();
        }
    }
}
