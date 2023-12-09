using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10OOZiekenhuis_ADI
{
    public class Dokter : Persoon
    {
        public string Specialisatie { get; set; }

        public Dokter(string naam, DateOnly geboorte, string specialisatie) : base(naam, geboorte)
        {
            Specialisatie = specialisatie;
        }

        public override string ToString()
        {
            return $"DOKTER: {Naam} - {Geboorte} - {Specialisatie}";
        }
    }
}
