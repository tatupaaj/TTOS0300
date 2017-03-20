using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //säikeitä varten
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

namespace WPFThreadDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            InitializeMyStuff();
        }

        #region METHODS
        void InitializeMyStuff()
        {
            btnFire.IsEnabled = false;
        }
        void DoWork()
        {
            //käynnistetään pitkäkestoinen taphatuma
            Thread.Sleep(5000);
            UpdateMessageAsync("The work is done and answer comes now!");
        }
        void UpdateMessage(string msg)
        {
            txtMessage.Text = msg;
        }

        void UpdateMessageAsync(string msg)
        {
            Action action = () =>
            {
                txtMessage.Text = msg;
                btnFire.IsEnabled = false;
            };
            // suorittaa annetun delekaatin asynkronisesti siinä säikeessä mihin siinä säikeessä mihin Dispatcher liittyy
            Dispatcher.BeginInvoke(action);
        }
        #endregion

        #region EVENTHANDLERS
        

        private void btnWork_Click(object sender, RoutedEventArgs e)
        {
            btnFire.IsEnabled = true;

            //v1: normaalisti tämä toimisi mutta nyt metodin kestontakia ei kerkiä päivittää
            //UpdateMessage("Long work started");
            //DoWork();
            //v2: säikeeseen
            UpdateMessageAsync("Long work started");
            new Thread(DoWork).Start();

        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            count++;
            UpdateMessage("Fire #" + count.ToString());
        }

        #endregion
    }
}
