using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OO_Lesrooster_ADI
{
    public class Leerkracht
    {
        public string Naam { get; set; }
        public DateOnly Geboorte { get; set; }

        public Leerkracht(string naam, DateOnly geboorte)
        {
            Naam = naam;
            Geboorte = geboorte;
        }

        public virtual void Print()
        {
            Console.WriteLine("Hallo Leerkracht " + Naam + " " + Geboorte);
        }
    }
}
