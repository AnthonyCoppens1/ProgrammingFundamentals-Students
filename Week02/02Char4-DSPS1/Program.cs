using System;

namespace _02Char4_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            string name4 = Console.ReadLine();

            char name1Char = name1[3];
            char name2Char = name2[3];
            char name3Char = name3[3];
            char name4Char = name4[3];

            Console.WriteLine($"{name1Char}{name2Char}{name3Char}{name4Char}");


        }
    }
}