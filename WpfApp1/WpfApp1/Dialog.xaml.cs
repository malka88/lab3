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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void tText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tH_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tM_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tS_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
