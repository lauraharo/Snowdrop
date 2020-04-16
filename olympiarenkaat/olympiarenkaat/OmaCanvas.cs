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
    class OmaCanvas : Canvas
    {
        double x = 100;
        double y = 100;
        double x2 = 140;
        double y2 = 140;
        double x3 = 180;
        double x4 = 220;
        double x5 = 260;

        public void setXY()
        {
            // this.x = x;
            // this.y = y;

            y -= 40;
            y2 += 40;

            x -= 40;
            x2 -= 40;
            x4 += 40;
            x5 += 40;

            InvalidateVisual();
        }
        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
            dc.DrawRectangle(Brushes.LightYellow, null,
                new System.Windows.Rect(0, 0, Width, Height));

            dc.DrawEllipse(null, new Pen(Brushes.Blue, 5),
                new System.Windows.Point(x, y), 35, 35);
            dc.DrawEllipse(null, new Pen(Brushes.Yellow, 5),
                new System.Windows.Point(x2, y2), 35, 35);
            dc.DrawEllipse(null, new Pen(Brushes.Black, 5),
                new System.Windows.Point(x3, y), 35, 35);
            dc.DrawEllipse(null, new Pen(Brushes.Green, 5),
                new System.Windows.Point(x4, y2), 35, 35);
            dc.DrawEllipse(null, new Pen(Brushes.Red, 5),
                new System.Windows.Point(x5, y), 35, 35);

        }
    }
}