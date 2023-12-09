using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10OOZiekenhuis_ADI
{
    public class Verpleger : Persoon
    {
        public string Departement { get; set; }
        public Verpleger(string naam, DateOnly geboorte,string departement) : base(naam, geboorte)
        {
            Departement = departement;
        }

        public override string ToString()
        {
            return $"VERPLEGER: {Naam} - {Geboorte} - {Departement}";
        }
    }
}
