using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10OOZiekenhuis_ADI
{
    public class Patient : Persoon
    {
        public string Probleem { get; set; }
        public string Behandeling { get; set; }

        public Patient(string naam, DateOnly geboorte, string probleem) : base(naam, geboorte)
        {
            Probleem = probleem;
            Behandeling = "Geen";
        }

        public override string ToString()
        {
            return $"PATIENT: {Naam} - {Geboorte} - {Probleem} - {Behandeling}";
        }
    }
}
