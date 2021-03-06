﻿using MVCQuete2.Controller;
using MVCQuete2.Model;
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

namespace MVCQuete2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DBFactory.CreateDB();
            string result = ProductController.HTMLParser();
            ProductController.HTMLWriter(result);
        }

        private void BigButton_Click(object sender, RoutedEventArgs e)
        {
            ShowHTMLBlock.Text = ProductController.HTMLParser();
        }
    }
}
