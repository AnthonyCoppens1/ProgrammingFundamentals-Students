﻿namespace _10OO_Hospital_DSPS2
{
    public class Person
    {
        public string Name { get; set; }
        public DateOnly Birth { get; set; }

        public Person()
        {
            Name = "John Doe";
            Birth = new DateOnly(2000, 1, 1);
        }

        public Person(string name, DateOnly birth)
        {
            Name = name;
            Birth = birth;
        }

        /*public void Print()
        {
            Console.WriteLine($"{Name} - {Role} - {Birth}");
        }*/

        public override string ToString()
        {
            return Name + " - " + Birth;
        }
    }
}
