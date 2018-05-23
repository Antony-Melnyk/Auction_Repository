using System.Windows;

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
