using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OO_Courses_DSPS1
{
    public class Teacher
    {
        public string Name { get; set; }
        public DateOnly Birth { get; set; }

        public Teacher(string name, DateOnly birth)
        {
            Name = name;
            Birth = birth;
        }

        public virtual void Print()
        {
            Console.WriteLine("Hello teacher" + Name + " " + Birth);
        }
    }
}
