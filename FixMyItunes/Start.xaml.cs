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

namespace FixMyItunes
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        List<string> detailedList = new List<string>();
        public Start()
        {
            InitializeComponent();
            
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;

            if (item != null && item.IsSelected)
            {
                buildSpecificList(item.Name.ToString());
            }
        }

        private void buildSpecificList(string path)
        {
            foreach(string s in Directory.GetDirectories(path))
            {
                detailedList.Add(s);
            }

            lvUsers.ItemsSource = detailedList;
        }
    }
}
