using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10OO_Hospital
{
    public class Person
    {
        //properties
        public string Name { get; set; }
        protected DateOnly Birth { get; set; }

        //constructors
        public Person(string name, DateOnly birth)
        {
            Name = name;
            Birth = birth;
        }

        public Person() //constructor without params
        {
            Name = "John Doe";
            Birth = new DateOnly(2000, 1, 1);
        }

        //methods
        /*public void Print()
        {
            Console.WriteLine($"{Name} - {Role} - {Birth}");
        }*/

        //override
        public override string ToString()
        {
            return Name;

        }
    }
}
