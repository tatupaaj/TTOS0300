using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T12Esim.Model;

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
    }
}
