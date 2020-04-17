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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kooste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        List<string> lista = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
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

        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ellipse.Width += 3;
            ellipse.Height += 3;
        }

        private void ellipse_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ellipse.Width -= 3;
            ellipse.Height -= 3;

        }

        private void buttonUp_Click(object sender, RoutedEventArgs e)
        {
            double top = Canvas.GetTop(ellipse);
            Canvas.SetTop(ellipse, top - 10);
            if (top <= 5)
            {
                Canvas.SetTop(ellipse, 0);
            }
        }

        private void buttonDown_Click(object sender, RoutedEventArgs e)
        {
            double top = Canvas.GetTop(ellipse);
            Canvas.SetTop(ellipse, top + 10);
            if (top >= 157 - 5)
            {
                Canvas.SetTop(ellipse, 157);
            }
        }

        private void buttonLeft_Click(object sender, RoutedEventArgs e)
        {
            double left = Canvas.GetLeft(ellipse);
            Canvas.SetLeft(ellipse, left - 10);
            if (left <= 5)
            {
                Canvas.SetLeft(ellipse, 0);
            }
        }

        private void buttonRight_Click(object sender, RoutedEventArgs e)
        {
            double left = Canvas.GetLeft(ellipse);
            Canvas.SetLeft(ellipse, left + 10);
            if (left >= 270 - 5)
            {
                Canvas.SetLeft(ellipse, 270);
            }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            lista.Add(textBox2.Text);
            ShowLista();
            lista.Clear();
            
        }

        private void ShowLista()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                textBox.Text += "\n"+lista[i]+"\n";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Text = Properties.Settings.Default.tieto_1;
            Canvas.SetLeft(ellipse, Properties.Settings.Default.tieto_2);
            Canvas.SetTop(ellipse, Properties.Settings.Default.tieto_3);

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Properties.Settings.Default.tieto_1 = textBox.Text;
            Properties.Settings.Default.tieto_2 = Canvas.GetLeft(ellipse);
            Properties.Settings.Default.tieto_3 = Canvas.GetTop(ellipse);
            Properties.Settings.Default.Save();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window_draw mywindow = new Window_draw();
            mywindow.ShowDialog();

        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(ellipse, 270 / 2);
            Canvas.SetTop(ellipse, 157 / 2);
        }

        private void browser_Click(object sender, RoutedEventArgs e)
        {
            Window_browser mywindow = new Window_browser();
            mywindow.ShowDialog();
        }
    }
}
