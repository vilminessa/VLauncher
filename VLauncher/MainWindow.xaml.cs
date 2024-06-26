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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;

namespace VilmLauncher
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB1 dB1 = new DB1();
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Content = new Page_Reg_Main();
        }

        private void btn_Settings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page_Settings_Main();
        }

        private void btn_GoToProfile_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page_Profile_Main();
        }
        private void btn_GoToComm_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page_Comm_Main();
        }
        private void btn_GoToShop_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page_Shop_Main();
        }
        private void btn_GoToBiblio_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page_Biblio_Main();
        }
    }
}
