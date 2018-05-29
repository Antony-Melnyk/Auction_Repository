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
using BLL;
using DAL;
using System.IO;
using MahApps.Metro.Controls;

namespace Auction
{
    /// <summary>
    /// Interaction logic for ItemsWindow.xaml
    /// </summary>
    public partial class AuctionsWindow : MetroWindow
    {
        public AuctionsWindow()
        {
            InitializeComponent();
            List<string> auctions = new List<string>();
            MessageBox.Show(File.ReadAllText(Directory.GetCurrentDirectory() + "\\nickname.txt"));
            //using (Model1 m1 = new Model1())
            //{
            //    foreach (DAL.Auction a in Operations.ShowAllAuctions().Where
            //        (
            //        x => x.Item.User.Id == m1.Users.FirstOrDefault(u => u.NickName ==

            //        ).Id
            //        )
            //        )
            //    {
            //        auctions.Add(a.Name);
            //    }
            //}

            //auctionslist.ItemsSource = auctions;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DAL.Auction a;
            using (Model1 m1 = new Model1())
            {
                a = m1.Auctions.FirstOrDefault(x => x.Name == auctionslist.SelectedItem.ToString());
                m1.SaveChanges();
            }

            Operations.DelAuction(a);
        }
    }
}