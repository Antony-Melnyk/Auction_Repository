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
using System.Security.Policy;
using System.Net;

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

            using (Model1 m1 = new Model1())
            {
                User u = m1.Users.FirstOrDefault(x => x.NickName == userName.Content.ToString());
                if (u.ImgPath != null)
                {
                    var imgUrl = new Uri("https://st.depositphotos.com/1482106/4444/i/450/depositphotos_44447855-stock-photo-waving-kazakhstan-flag.jpg");
                    var imageData = new WebClient().DownloadData(imgUrl);
                    var bitmapImage = new BitmapImage { CacheOption = BitmapCacheOption.OnLoad };
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = new MemoryStream(imageData);
                    bitmapImage.EndInit();
                    Avatar.Source = bitmapImage;
                }
            }
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