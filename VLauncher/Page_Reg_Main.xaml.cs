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
using System.Data.OracleClient;
using System.Windows.Forms;

namespace VilmLauncher
{
    /// <summary>
    /// Логика взаимодействия для Page_Login_Main.xaml
    /// </summary>
    public partial class Page_Reg_Main : Page
    {
        DB1 dB1 = new DB1();
        public Page_Reg_Main()
        {
            InitializeComponent();
            FormStartPosition formStartPosition = FormStartPosition.CenterScreen;
        }
        private void log_in_load(object sender, EventArgs e)
        {

        }
    }
}
