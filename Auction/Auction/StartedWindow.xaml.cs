using System.Windows;
using MahApps.Metro.Controls;

namespace Auction
{
    public partial class StartedWindow : MetroWindow
    {
        public StartedWindow()
        {
            InitializeComponent();
        }

        private void SignIn_Btn_Click(object sender, RoutedEventArgs e)
        {
            SignInWindow sir = new SignInWindow();
            sir.ShowDialog();
        }

        private void Registration_Btn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow rw = new RegistrationWindow();
            rw.ShowDialog();
        }
    }
}