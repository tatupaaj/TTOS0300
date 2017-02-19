using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
   public class Henkilo
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Kokonimi()
        {
            return Etunimi + " " + Sukunimi;
        }
    }

    public class Tyontekija : Henkilo
    {
        public string Nimike { get; set; }
        public int Numero { get; set; }
        public float Palkka { get; set; }
        public override string ToString()
        {
            return Numero + " = " + Kokonimi();
        }
    }
}
