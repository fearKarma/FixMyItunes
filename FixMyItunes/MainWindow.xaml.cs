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
        List<string> primaryDataSource = new List<string>();


        public MainWindow()
        {
            InitializeComponent();

           
            lvMain.ItemsSource = primaryDataSource;

        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult dr = fbd.ShowDialog();

            txtFilePath.Text = fbd.SelectedPath;
            this.btnStart.Visibility = Visibility.Visible;

            foreach (string s in Directory.GetDirectories(txtFilePath.Text))
            {
                primaryDataSource.Add(s);
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            txtFilePath.Visibility = Visibility.Collapsed;
            btnBrowse.Visibility = Visibility.Collapsed;
            txtHelp1.Visibility = Visibility.Collapsed;

            lvMain.Visibility = Visibility.Visible;
            
        }

    }

   
}
