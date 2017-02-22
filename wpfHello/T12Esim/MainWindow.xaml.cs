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

namespace T12Esim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        T12Esim.ViewModel.StudentViewModel svmo = new ViewModel.StudentViewModel();
        public MainWindow()
        {
            //InitializeComponent();
            //svmo.Loadstudents();
            try
            {
                //oppilaat tietokannasta
                svmo.LoadStudentsFromMysql();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            StudentViewControl.DataContext = svmo;
        }

        private void dgSudents_Loaded(object sender, RoutedEventArgs e)
        {
            dgSudents.DataContext = svmo.Students;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // luodaan observabelcollectioniin uusi Student-olio
            T12Esim.Model.Student uusi = new Model.Student();
            uusi.FirstName = txtFirstName.Text;
            uusi.LastName = txtLastName.Text;
            uusi.AsioId = txtAsioId.Text;
            svmo.Students.Add(uusi);
            // tyhjätään textbo
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAsioId.Text = "";
        }
    }
}
