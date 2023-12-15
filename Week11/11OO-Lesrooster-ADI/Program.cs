using System;

namespace _11OO_Lesrooster_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leerkracht Tom = new Leerkracht("Tom", new DateOnly(1976, 2, 7));
            Leerkracht Anthony = new Leerkracht("Anthony", new DateOnly(1995, 7, 31));
            Leerkracht Collin = new Leerkracht("Collin", new DateOnly(1991, 4, 16));
            Vak ProgrammingFundamentals = new Vak("Programming Fundamentals", Anthony,
                "Z3.09", 4, WeekDays.Friday, new Time(8, 30));
            Vak Databases = new Vak("Databases", Collin, "T1.12",3,WeekDays.Monday, new Time(8, 30));
            Vak Economie = new Vak("Economie", Tom, "Z1.03", 3, WeekDays.Monday, new Time(12, 45));
            Vak Scripting = new Vak("Scripting", Anthony, "T2.19",2, WeekDays.Tuesday, new Time(13, 45));

            Student Louis = new Student("Louis", new DateOnly(2005, 12, 05),
                new Vak[] { ProgrammingFundamentals, Databases, Economie, Scripting });

            Louis.Print();

        }
    }
}