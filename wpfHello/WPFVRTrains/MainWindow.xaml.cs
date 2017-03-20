using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


namespace WPFVRTrains
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Train> trains = new List<Train>();
        string selectedStation;
        public MainWindow()
        {
            InitializeComponent();
            InitializeMyStaff();
        }
        #region METHODS
        void InitializeMyStaff()
        {
            // omat asetukset kootaan tänne
            //täytetään kompoboksi näillä asemilla
            GetStations();
        }
        private void GetStations()
        {
            List<Station> stations = new List<Station>();
            stations.Add(new Station("JY", "Jyväskylä"));
            stations.Add(new Station("HKI", "Helsinki"));
            stations.Add(new Station("TPE", "Tampere"));
            // TODO kot-teht hakekaa asemapaikat API:in json
            //Kiinnitetään station kokoelma comoboboksiin
            cbStations.DisplayMemberPath = "Name";
            cbStations.SelectedValuePath = "Code";
            cbStations.DataContext = stations;

        }
        private void GetTrainsAT()
        {
            try
            {
                //Haetaan asemalta lähtevät junat
                string st = cbStations.SelectedValue.ToString();
                trains = JAMK.IT.TrainsVM.GetTrainsAt(st);
                dtgTrains.DataContext = trains;
                txbMessage.Text = string.Format("Löytyi {0} junaa", trains.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void GetTrainsAtAsync()
        {
            //huom eri säikeessä ajettava metodi Ei voi käsitellä GUIta.
            //mutta muuttujia voi
            trains = JAMK.IT.TrainsVM.GetTrainsAt(selectedStation);
            UpdateUI();
        }
        private void UpdateUI()
        {
            Action action = () =>
            {
                dtgTrains.DataContext = trains;
                txbMessage.Text = string.Format("Löytyi {0} junaa", trains.Count);
            };
            Dispatcher.BeginInvoke(action);
        }
        #endregion

        private void btnGetTrains_Click(object sender, RoutedEventArgs e)
        {
            if (cbStations.SelectedValue != null)
            {
                //V1: alkuperainen
                //txbMessage.Text = "Haetaan junat...";
                //GetTrainsAT();
                //V2: asynkroninen omassa säikeessä
                selectedStation = cbStations.SelectedValue.ToString();
                new Thread(GetTrainsAtAsync).Start();
                txbMessage.Text = "haetaan junia, odota hetki...";
            }
        }
    }
}
