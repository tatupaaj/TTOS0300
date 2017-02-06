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

namespace Tehtävät_9_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int laskuri1;
        private int laskuri2;

        public MainWindow()
        {
            InitializeComponent();
            laskuri1 = 0;
            textBlock2.Text = laskuri1.ToString();
            laskuri2 = 0;
            textBlock3.Text = laskuri2.ToString();

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = " " + textBlock2.Text;
            laskuri1++;
            textBlock2.Text = laskuri1.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock3.Text = " " + textBlock3.Text;
            laskuri2++;
            textBlock3.Text = laskuri2.ToString();
        }
    }
}
