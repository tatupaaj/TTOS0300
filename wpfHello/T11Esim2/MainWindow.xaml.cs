using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using JAMK.ICT;

namespace T11Esim2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Koska useampi metodi=tapahtumankasittelija tulee kayttamaan naita muuttujia --> maaritellaan
        JAMK.ICT.HockeyLeague liiga;
        ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }

        private void IniMyStuff()
        {
            // tänne 
            List<string> muuvit = new List<string>();
            muuvit.Add("Halloween");
            muuvit.Add("Jaws");
            muuvit.Add("Star Wars");
            muuvit.Add("pahat pojat");
            cmbMovies.ItemsSource = muuvit;
            // haetaan SMLiiga-Joukkueet
            liiga = new JAMK.ICT.HockeyLeague();
            joukkueet = liiga.GetTeams();
            cmbTeams.ItemsSource = joukkueet;

        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            //määritellään stackpanelin DataContext
            // demo1: DataContekstina on olio
            //HockeyTeam tiimi = new HockeyTeam("Keupa", "Keuruu");
            //spRight.DataContext = tiimi;
            // demo2: kytketään olio-kokoelman 1. olioon
            spRight.DataContext = joukkueet[counter];
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            counter--;
            btnBind_Click(sender, e);
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            btnBind_Click(sender, e);
        }

        private void btnLisaa_Click(object sender, RoutedEventArgs e)
        {
            HockeyTeam team = new HockeyTeam();
            team.Name = txtNimi.Text;
            team.City = txtKaupunki.Text;
            joukkueet.Add(team);

        }
    }
}
