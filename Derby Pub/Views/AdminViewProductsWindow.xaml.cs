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

namespace Derby_Pub.Views
{
    /// <summary>
    /// Interaction logic for AdminViewProducts.xaml
    /// </summary>
    public partial class AdminViewProductsWindow : Window
    {
        public AdminViewProductsWindow()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            AdminAccountWindow adminAccountWindow = new AdminAccountWindow();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminAccountWindow;
            App.Current.MainWindow.Show();
        }
    }
}
