using System;
using System.IO;

namespace SplitEmUp_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(Console.ReadLine());
            string zin1 = "";
            string zin2 = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    zin1 += text[i];
                }
                else
                {
                    zin2 += text[i];
                }
            }
            Console.WriteLine(zin1);
            Console.WriteLine(zin2);
        }
    }
}