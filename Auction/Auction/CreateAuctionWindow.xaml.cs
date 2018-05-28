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

namespace Auction
{
    /// <summary>
    /// Логика взаимодействия для CreateAuctionWindow.xaml
    /// </summary>
    public partial class CreateAuctionWindow : MetroWindow
    {
        public CreateAuctionWindow()
        {
            InitializeComponent();
        }

        private void OKClick(object sender, RoutedEventArgs e)
        {

        }

        private void ItemsClick(object sender, RoutedEventArgs e)
        {
            ItemsWindow iw = new ItemsWindow();
            iw.ShowDialog();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}