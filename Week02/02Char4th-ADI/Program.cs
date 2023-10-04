using System;

namespace _02Char4th_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welk character heb je nodig? ");
            int c = (Convert.ToByte(Console.ReadLine())) - 1;

            string naam1 = Console.ReadLine();
            string naam2 = Console.ReadLine();
            string naam3 = Console.ReadLine();
            string naam4 = Console.ReadLine();

            Console.WriteLine($"{naam1[c]}{naam2[c]}{naam3[c]}{naam4[c]}");
        }
    }
}