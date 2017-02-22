using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T12Esim.Model;
using MySql.Data.MySqlClient;

namespace T12Esim.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }
        public void Loadstudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Model.Student>();
            // lisätään muutama opiskelija, oikeassa sovelluksessa haettaisiin esim tietokannasta.
            students.Add(new Student { FirstName = "Kalle", LastName = "Jalkanen", AsioId = "K5397"});
            students.Add(new Student { FirstName = "Teppo", LastName = "Testaaja", AsioId = "K5334" });
            students.Add(new Student { FirstName = "Tomi", LastName = "Töttöröö", AsioId = "K9876" });
            Students = students;
        }

        public void LoadStudentsFromMysql()
        {
            try
            {
                ObservableCollection<Student> students = new ObservableCollection<Student>();
                //luodaan yhteys labranetin mysql-palvelimelle
                string connStr = GetMysqlConnectionString();
                string sql = "SELECT firstname, lastname, asioid FROM student";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T12Esim.Model.Student s = new Model.Student();
                            s.FirstName = reader.GetString(0);
                            s.LastName = reader.GetString(1);
                            s.AsioId = reader.GetString(2);
                            students.Add(s);
                        }
                        Students = students;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private string GetMysqlConnectionString()
        {
            string pw = ""; //"sala-sana"
                //haetaan salasana app.Config konfiguraatio tiedostosta
                pw = T12Esim.Properties.Settings.Default.passu;
            return string.Format("Data source=mysql.labranet.jamk.fi;Initial Catalog=K8838_3;user=K8838;password={0}", pw);
        }
    }
}
