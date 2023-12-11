using System;

namespace _11OO_Courses_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher jef = new Teacher("Jef", new DateOnly(2000, 1, 1));
            Teacher Collin = new Teacher("Collin", new DateOnly(1976,2,7));
            Teacher Anthony = new Teacher("Anthony", new DateOnly(1995, 7, 31));
            Course PF = new Course("Programming Fundamentals", jef, "C1.15", 4, Course.WeekDays.Monday, new Time(8, 30));
            Course DB = new Course("Databases", Collin, "Z2.03", 3, Course.WeekDays.Monday, new Time(13, 45));
            Course SC = new Course("Scripting", Anthony, "T1.13", 3, Course.WeekDays.Tuesday, new Time(9, 30));

            Student Jef = new Student("Jef", new DateOnly(2005, 9, 12), new Course[] { PF, DB, SC });

            Jef.Print();
        }

        
    }
}