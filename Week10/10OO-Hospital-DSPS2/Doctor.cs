﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10OO_Hospital_DSPS2
{
    public class Doctor: Person
    {
        public string Speciality { get; set; }

        public Doctor(string name, DateOnly birth, string speciality): base(name, birth)
        {
            Speciality = speciality;
        }

        public override string ToString()
        {
            return $"DOCTOR: {Name} - {Birth} - {Speciality}";
        }
    }
}
