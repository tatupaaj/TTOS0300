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

namespace Tehtävät_10_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Lotto
    {
    public int Peli { get; set; }
    public int Maara { get; set; }
    private List<string> draws;

    public Lotto()
    {
        draws = new List<string>();
    }

    public void Numerot()
    {
        Random rnd = new Random();
        string luvut;
        switch (Peli)
        {
            case 0:
                for (int i = 0; i < Maara; i++)
                {
                    luvut = "";
                    for (int j = 0; j < 7; j++)
                    {
                        luvut = luvut + " " + rnd.Next(1, 40);
                    }
                    draws.Add(luvut);
                }
                break;
            case 1:
                for (int i = 0; i < Maara; i++)
                {
                    luvut = "";
                    for (int j = 0; j < 6; j++)
                    {
                        luvut = luvut + " " + rnd.Next(1, 49);
                    }
                    draws.Add(luvut);
                }
                break;
            case 2:
                for (int i = 0; i < Maara; i++)
                {
                    luvut = "";
                    for (int j = 0; j < 7; j++)
                    {
                        luvut = luvut + " " + rnd.Next(1, 51);
                    }
                    draws.Add(luvut);
                }
                break;
        }
    }

    public string Print()
    {
        string luvut = "";
        foreach (string s in draws)
        {
            luvut = luvut + s + "\n";
        }
        return luvut;
    }
}

public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            Lotto lotto = new Lotto();
            lotto.Peli = Int32.Parse(cmbGame.SelectedIndex.ToString());
            lotto.Maara = Int32.Parse(txtDraws.Text);
            lotto.Numerot();
            svDraw.Content = lotto.Print();
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            svDraw.Content = "";
        }
    }
}
