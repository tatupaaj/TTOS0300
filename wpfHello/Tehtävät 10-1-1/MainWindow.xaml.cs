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

namespace Tehtävät_10_1_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string items;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            foreach (object control in stpList.Children)
            {
                if (control is CheckBox)
                {
                    CheckBox chcBox = (CheckBox)control;
                    if ((bool)chcBox.IsChecked) items += chcBox.Content + " ";
                }
            }
            txbList.Text = items;
        }
    }
}

