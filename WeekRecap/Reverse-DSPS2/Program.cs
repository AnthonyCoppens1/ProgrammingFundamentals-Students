using System;
using System.IO;

namespace Reverse_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string lines = "";

            foreach (var line in File.ReadAllLines(file))
            {
                lines = line + "\n" + lines;
            }
            Console.WriteLine(lines);

            using (StreamWriter sw = File.CreateText("reverse_" + file))
            {
                sw.WriteLine(lines);
            }
        }
    }
}