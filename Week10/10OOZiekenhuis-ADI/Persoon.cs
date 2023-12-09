using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10OOZiekenhuis_ADI
{
    public class Persoon
    {
        public string Naam { get; set; }
        public DateOnly Geboorte { get; set; }

        public Persoon()
        {
            Naam = "Tom";
            Geboorte = new DateOnly(2000, 1, 1);
        }

        public Persoon(string naam, DateOnly geboorte)
        {
            Naam = naam;
            Geboorte = geboorte;
        }

        /*public void Print()
        {
            Console.WriteLine($"{Naam} - {Rol} - {Geboorte}");
        }*/

        public override string ToString()
        {
            return Naam + " - " + Geboorte;
        }
    }
}
