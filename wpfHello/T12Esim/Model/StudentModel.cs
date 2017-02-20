using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12Esim.Model
{
    public class Student : INotifyPropertyChanged
    {
        // properties
        private string firstname;

        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (firstname != value)
                {
                    firstname = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                }
                
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("FullName");
                }
                
            }
        }

        public string FullName
        {
            get
            {
                return firstname + " " + lastName;
            }
        }

        public string AsioId { get; set; }
        // Constructors
        // Methods
        // Events
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
