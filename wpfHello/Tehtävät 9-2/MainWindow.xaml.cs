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

namespace Tehtävät_9_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double luku1, muunnos = 0;
        private double markka = 5.94573;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            luku1 = Double.Parse(textBox1.Text);
            markka = luku1 / muunnos;
            textBlock3.Text = "euroina: " + markka.ToString("0.00");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            luku1 = Double.Parse(textBox.Text);
            muunnos = luku1 * markka;
            textBlock1.Text = "markkoina: " + muunnos.ToString("0.00");
        }
    }
}
