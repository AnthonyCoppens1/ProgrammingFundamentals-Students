using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OO_Course_DSPS2
{
    public class Student: Teacher
    {
        public Course[] Courses { get; set; }

        public Student(string name, DateOnly birth, Course[] c):base(name,birth)
        {
            Courses = c;
        }

        public override void Print()
        {
            Console.WriteLine("Hello student: " + Name + " " + Birth);
            foreach (var item in Courses)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
