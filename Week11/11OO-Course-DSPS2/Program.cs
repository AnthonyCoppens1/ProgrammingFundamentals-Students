using System;

namespace _11OO_Course_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher jef = new Teacher("Jef", new DateOnly(2005, 3, 2));
            Teacher Anthony = new Teacher("Anthony", new DateOnly(1995, 7, 31));
            Teacher Marie = new Teacher("Marie", new DateOnly(1976, 1, 1));
            Teacher Collin = new Teacher("Collin", new DateOnly(1991, 4, 16));

            Course PF = new Course("Programming Fundamentals", jef, "C1.15", 4, 
                WeekDays.Monday, new Time(13, 45));
            Course DB = new Course("Databases", Collin, "C3.19", 3, WeekDays.Friday, new Time(8, 30));
            Course SC = new Course("Scripting", Anthony, "T2.12", 3, WeekDays.Monday, new Time(9, 30));

            Student Bert = new Student("Bert", new DateOnly(2013, 2, 11), new Course[] { PF, DB, SC });
            
            Bert.Print();
        }
    }
}