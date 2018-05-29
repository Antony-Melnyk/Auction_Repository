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
    public partial class ItemsWindow : MetroWindow
    {
        public ItemsWindow()
        {
            InitializeComponent();
            List<string> items = new List<string>();
            foreach (Item a in Operations.ShowAllItems(File.ReadAllText(Directory.GetCurrentDirectory() + "\\info.txt")))
            {
                items.Add(a.Name);
            }

            itemslist.ItemsSource = items;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}