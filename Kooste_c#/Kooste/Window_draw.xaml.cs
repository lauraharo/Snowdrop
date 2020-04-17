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
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kooste
{
    /// <summary>
    /// Interaction logic for Window_draw.xaml
    /// </summary>
    public partial class Window_draw : Window
    {
        
        bool draw = false;
        string fileName = "myInk.ink";

        public Window_draw()
        {
            InitializeComponent();
        }

        private void inkCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            draw = true;

        }

        private void inkCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            draw = false;
        }

        private void inkCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Ellipse ellipse = new Ellipse();
                ellipse.Width = ellipse.Height = 5;
                inkCanvas.Children.Add(ellipse);
                ellipse.Fill = Brushes.Black;
                Canvas.SetLeft(ellipse, e.GetPosition(inkCanvas).X);
                Canvas.SetTop(ellipse, e.GetPosition(inkCanvas).Y);
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var fs = new FileStream(fileName,
                    FileMode.Open, FileAccess.Read);
                StrokeCollection strokes = new StrokeCollection(fs);
                inkCanvas.Strokes = strokes;
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (inkCanvas.Strokes != null)
            {
                var fs = new FileStream(fileName, FileMode.Create);
                inkCanvas.Strokes.Save(fs);
                MessageBox.Show("Drawning saved");
            }
        }
    }
}
