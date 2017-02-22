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

namespace T12Esim
{
    /// <summary>
    /// Interaction logic for TestMysql.xaml
    /// </summary>
    public partial class TestMysql : Window
    {
        public TestMysql()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                T12Esim.ViewModel.StudentViewModel svmo = new ViewModel.StudentViewModel();
                svmo.LoadStudentsFromMysql();
                dgStudents.DataContext = svmo.Students;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
