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
using JAMK.IT;

namespace Tehtävät_11_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Tyontekija[] tekija = new Tyontekija[4];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHae_Click(object sender, RoutedEventArgs e)
        {
            tekija[0] = new Tyontekija { Etunimi = "Alfred", Sukunimi = "Nobel", Numero = 1, Nimike = "toimitusjohtaja", Palkka = 50000 };
            tekija[1] = new Tyontekija { Etunimi = "Beatrix", Sukunimi = "Bamboo", Numero = 2, Nimike = "opettaja", Palkka = 3000 };
            tekija[2] = new Tyontekija { Etunimi = "Cecilia", Sukunimi = "Tapper", Numero = 3, Nimike = "hoitaja", Palkka = 2000 };
            tekija[3] = new Tyontekija { Etunimi = "Daavid", Sukunimi = "Cooper", Numero = 4, Nimike = "lääkäri", Palkka = 4000 };

            lbxTyontekijat.Items.Add(tekija[0].ToString());
            lbxTyontekijat.Items.Add(tekija[1].ToString());
            lbxTyontekijat.Items.Add(tekija[2].ToString());
            lbxTyontekijat.Items.Add(tekija[3].ToString());
        }

        private void lbxTyontekijat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxTyontekijat.SelectedItem != null)
            {
                int dude = lbxTyontekijat.SelectedIndex;
                txbEtunimi.Text = tekija[dude].Etunimi;
                txbSukunimi.Text = tekija[dude].Sukunimi;
                txbNumero.Text = Convert.ToString(tekija[dude].Numero);
                txbTitteli.Text = tekija[dude].Nimike;
                txbPalkka.Text = Convert.ToString(tekija[dude].Palkka);
            }
        }

        private void btnTyhjenna_Click(object sender, RoutedEventArgs e)
        {
            lbxTyontekijat.Items.Clear();
        }

        private void btnYlikirjoita_Click(object sender, RoutedEventArgs e)
        {
            int dude = lbxTyontekijat.SelectedIndex;
            lbxTyontekijat.Items.RemoveAt(dude);
            lbxTyontekijat.Items.Insert(dude, txbNumero.Text + " = " + txbEtunimi.Text + " " + txbSukunimi.Text + "," + txbTitteli.Text);
        }
    }
}
