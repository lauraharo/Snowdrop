﻿using System;
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

namespace Kooste
{
    /// <summary>
    /// Interaction logic for Window_browser.xaml
    /// </summary>
    public partial class Window_browser : Window
    {
        public Window_browser()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            webBrowser.Source = new Uri(textBox.Text);
        }
    }
}
