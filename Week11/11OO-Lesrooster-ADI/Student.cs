using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OO_Lesrooster_ADI
{
    public class Student: Leerkracht
    {
        public Vak[] Vakken { get; set; }

        public Student(string naam, DateOnly geboorte, Vak[] v):base(naam,geboorte)
        {
            Vakken = v;
        }

        public override void Print()
        {
            Console.WriteLine("Hallo student: " + Naam + " " + Geboorte);
            foreach (var item in Vakken)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}
