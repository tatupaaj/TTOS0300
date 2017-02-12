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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmbGame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string name in cmbGame.Items)
            {
                sb.Append(name);
                sb.Append(" ");
            }
            cmbGame.Items.Add("Lotto");
            MessageBox.Show(sb.ToString());
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
