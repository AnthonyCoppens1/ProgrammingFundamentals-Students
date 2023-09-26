using System;

namespace _02Char4th_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            string name4 = Console.ReadLine();

            Console.WriteLine($"{name1[3]}{name2[3]}{name3[3]}{name4[3]}");
        }
    }
}