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

namespace Tehtävät_10_1_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void chcMaito_Checked(object sender, RoutedEventArgs e)
          {
          }

          private void chcPepsi_Checked(object sender, RoutedEventArgs e)
          {
          }

          private void chcJuusto_Checked(object sender, RoutedEventArgs e)
          {
          }

          private void chcKana_Checked(object sender, RoutedEventArgs e)
          {
          }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)chcMaito.IsChecked)
            {
                txbList.Text = "Maito";
            }

            if ((bool)chcPepsi.IsChecked)
            {
                txbList.Text = "Pepsi";
            }

            if ((bool)chcJuusto.IsChecked)
            {
                txbList.Text = "Juusto";
            }

            if ((bool)chcKana.IsChecked)
            {
                txbList.Text = "Kana";
            }
        }
    }
}

