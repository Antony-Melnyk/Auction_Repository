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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SignInRoom s1 = new SignInRoom();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SignIn_Click(object sender, RoutedEventArgs e)
        {
            s1.Show();
        }
    }
}
