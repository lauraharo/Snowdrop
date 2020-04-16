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
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace olympiarenkaat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DoubleAnimation a = new DoubleAnimation();
        DoubleAnimation b = new DoubleAnimation();
        DoubleAnimation c = new DoubleAnimation();


        private void button_Click(object sender, RoutedEventArgs e)
        {

            //blue
            Canvas.SetLeft(blue, 30);
            Canvas.SetTop(blue, 30);
            //yellow
            Canvas.SetLeft(yellow, 50);
            Canvas.SetTop(yellow, 150);
            //black
            Canvas.SetTop(black, 30);
            //green
            Canvas.SetLeft(green, 200);
            Canvas.SetTop(green, 150);
            //red
            Canvas.SetLeft(red, 250);
            Canvas.SetTop(red, 30);

        }

        private void animate_Click(object sender, RoutedEventArgs e)
        {
            a.From = 20;
            a.To = 200;
            a.Duration = new Duration(TimeSpan.Parse("0:0:5"));
            a.AutoReverse = true;
            a.EasingFunction = new BounceEase();

            b.From = 150;
            b.To = 20;
            b.Duration = new Duration(TimeSpan.Parse("0:0:5"));
            b.AutoReverse = true;
            b.EasingFunction = new BounceEase();

            c.From = 250;
            c.To = 20;
            c.Duration = new Duration(TimeSpan.Parse("0:0:5"));
            c.AutoReverse = true;
            c.EasingFunction = new BounceEase();

            blue.BeginAnimation(LeftProperty, a);
            blue.BeginAnimation(TopProperty, a);

            yellow.BeginAnimation(LeftProperty, a);
            yellow.BeginAnimation(TopProperty, b);

            black.BeginAnimation(TopProperty, a);

            green.BeginAnimation(TopProperty, a);
            green.BeginAnimation(LeftProperty, c);

            red.BeginAnimation(TopProperty, b);
            red.BeginAnimation(LeftProperty, c);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            omaCanvas.setXY();
        }
    }
}
