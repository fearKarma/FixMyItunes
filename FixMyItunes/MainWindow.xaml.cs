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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;

namespace FixMyItunes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Dictionary<string, string> listMain = new Dictionary<string, string>();
        internal List<Album> listDetailed = new List<Album>();

        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult dr = fbd.ShowDialog();

            txtFilePath.Text = fbd.SelectedPath;
            this.btnStart.Visibility = Visibility.Visible;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            txtFilePath.Visibility = Visibility.Collapsed;
            btnBrowse.Visibility = Visibility.Collapsed;
            txtHelp1.Visibility = Visibility.Collapsed;

            lvMain.Visibility = Visibility.Visible;

            buildList(listMain);
        }

        private void buildList(Dictionary<string,string> d)
        {
           
                foreach (string e in d.Values)
                {
                    lvMain.Items.Add(new Album(e,System.IO.Path.GetFullPath(e)));
                }
            
        }

        private void InitialList(string fp)
        {
            string p = fp;
            string[] l = Directory.GetFiles(fp);

            foreach (string f in l)
            {
                addToList(f, false);
            }
        }

        private void addToList(string item, bool type)
        {
            listMain = new Dictionary<string, string>();
            listDetailed = new List<Album>();

            if (!type) {
                listMain.Add(item, System.IO.Path.GetFullPath(item));
            }
            else {
                //Album a = new Album();
                //listDetailed.Add(item);
             }

        }
    }

   
}
