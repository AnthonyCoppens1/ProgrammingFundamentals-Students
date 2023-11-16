using System;
using System.IO;

namespace MixAndMatch_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = File.ReadAllText(Console.ReadLine());
            string file2 = File.ReadAllText(Console.ReadLine());

            int charcount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < charcount; i++)
            {
                Console.Write(file1[i]);
                Console.Write(file2[i]);
            }
        }
    }
}