using System;

namespace _02ValidAge_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            int validAge = (age / 2) + 7;
            Console.WriteLine($"Your age is {age} and you’re allowed to date people of {validAge}");
        }
    }
}