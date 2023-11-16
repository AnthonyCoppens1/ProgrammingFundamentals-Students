using System;
using System.IO;

namespace SplitemUp_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(Console.ReadLine());
            string s1 = "";
            string s2 = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    s1 += text[i];
                }
                else
                {
                    s2 += text[i];
                }
            }
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}