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

namespace Tehtävät10_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double l;
        private double h;
        private double w;
        private double laske = 0;
        private double laske1 = 0;
        private double laske2 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            l = Double.Parse(textBox.Text);
            h = Double.Parse(textBox_Copy.Text);
            w = Double.Parse(textBox_Copy1.Text);
            // Ikkunan pinta-ala
            laske = l * h;
            textBox_Copy2.Text = " " + laske;
            // Lasin pinta-ala
            laske1 = (l - 2 * w) * (h - 2 * w);
            textBox_Copy3.Text = " " + laske1;
            // Karmin piiri
            laske2 = l * 2 + h * 2;
            textBox_Copy4.Text = " " + laske2;
        }
    }
}
