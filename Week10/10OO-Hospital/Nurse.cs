using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10OO_Hospital
{
    public class Nurse: Person
    {
        //public string Department { get; set; }
        public Area Department { get; set; }
        public Nurse(string name, DateOnly birth, Area department): base(name,birth)
        {
            Department = department;
        }
        public override string ToString()
        {
            return $"NURSE: {Name} - {Birth} - {Department}";
        }
    }
}
