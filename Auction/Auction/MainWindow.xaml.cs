using System;
using System.Collections.Generic;
using System.IO;
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
using BLL;
using DAL;
using MahApps.Metro.Controls;

namespace Auction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        void funcRefresh()
        {
            List<string> AuctionsNames = new List<string>();
            AuctionCount.Text = "Count : " + Operations.ShowAllAuctions().Count.ToString();
            foreach (DAL.Auction a in Operations.ShowAllAuctions())
            {
                AuctionsNames.Add(a.Name);
            }

            listBoxAuctions.ItemsSource = AuctionsNames;
            textBoxbalance.Text = "Balance : " + Operations.GetBalance(userName.Content.ToString()).ToString();
            
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SignIn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            CreateAuctionWindow caw = new CreateAuctionWindow();
            caw.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            funcRefresh();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\nickname.txt", userName.Content.ToString());
            funcRefresh();
        }

        private void Button_Click_ShowItems(object sender, RoutedEventArgs e)
        {
            ItemsWindow iw = new ItemsWindow();
            iw.ShowDialog();
        }

        private void Button_Click_ShowAuctions(object sender, RoutedEventArgs e)
        {
            AuctionsWindow aw = new AuctionsWindow();
            aw.ShowDialog();
        }
    }
}