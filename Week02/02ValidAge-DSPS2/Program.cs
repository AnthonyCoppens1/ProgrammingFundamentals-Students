using System;

namespace _02ValidAge_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());

            /*Console.WriteLine("Give me your age: ");
            string answer = Console.ReadLine();
            int age = Convert.ToInt32(answer);*/

            int validAge = (age / 2) + 7;
            Console.WriteLine($"Your age is {age} and you’re allowed to date people of {validAge}");
        }
    }
}