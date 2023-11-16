using System;
using System.IO;

namespace SplitemUp_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(Console.ReadLine());
            string str1 = "";
            string str2 = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    str1 += text[i];
                }
                else
                {
                    str2 += text[i];
                }
            }
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}