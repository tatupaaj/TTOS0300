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

namespace wpfHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int laskuri;

        public MainWindow()
        { 
            InitializeComponent();
            laskuri = 0;
            textBlock1.Text = laskuri.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Hello " + textBox.Text;
            MessageBox.Show("Terve " + textBox.Text, "Tatu's Messut");
            laskuri++;
            textBlock1.Text = laskuri.ToString();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            // kutsutaan näkyviin About -niminen ikkuna
            About aboutWin = new wpfHello.About();
            // huom ikkuna voi olla modaalinen ta tavallinen
            //aboutWin.ShowDialog();// modaalinen
            aboutWin.Show();
        }
    }
}
