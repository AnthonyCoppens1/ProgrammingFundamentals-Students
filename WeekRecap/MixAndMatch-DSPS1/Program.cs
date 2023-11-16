using System;
using System.IO;

namespace MixAndMatch_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sr1 = File.ReadAllText(Console.ReadLine());
            string sr2 = File.ReadAllText(Console.ReadLine());

            int charactercount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < charactercount; i++)
            {
                Console.Write(sr1[i]);
                Console.Write(sr2[i]);
            }

        }
    }
}