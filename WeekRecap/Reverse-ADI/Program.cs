using System;
using System.IO;

namespace Reverse_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string lijnen = "";

            foreach (var line in File.ReadAllLines(file))
            {
                lijnen = line + "\n" + lijnen;
            }

            Console.WriteLine(lijnen);

            using (StreamWriter sw = File.CreateText("reverse_" + file))
            {
                sw.WriteLine(lijnen);
            }
        }
    }
}