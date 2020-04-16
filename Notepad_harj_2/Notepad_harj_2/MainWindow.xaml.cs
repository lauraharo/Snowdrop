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
using System.Windows.Xps.Packaging;

namespace Notepad_harj_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menu_exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void menuPrint_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog dlg = new System.Windows.Controls.PrintDialog();
            dlg.PageRangeSelection = PageRangeSelection.AllPages;
            dlg.UserPageRangeEnabled = true;

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                dlg.PrintVisual(grid, textBox.Text);
            }
         }
        

        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        

        private void menuSave_Click(object sender, RoutedEventArgs e)
        {
            // Configure save file dialog box
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".text"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                
                string filename = dlg.FileName;
                File.WriteAllText(filename, textBox.Text);
            }
        }

        private void menuOpen_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
                textBox.Text = File.ReadAllText(dlg.FileName);
            }
        }

        public void menuFont_Click(object sender, RoutedEventArgs e)
        {
            Window1 fontWindow = new Window1(); // tässä ikkunaluokan nimi=Window1
                                                //mywindow.Show(); // avaisi hakutyyppisen (modaalisen) ikkunan
                                                // mieluummin käytä
            if (fontWindow.DialogResult == true)
            {
                // Update fonts
                textBox.FontSize = fontWindow.fontBox.FontSize;
            }
            
            fontWindow.ShowDialog();
        }

        public void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
