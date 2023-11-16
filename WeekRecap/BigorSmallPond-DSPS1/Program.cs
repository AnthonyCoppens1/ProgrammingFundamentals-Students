using System;

namespace BigorSmallPond_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int D = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= D; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("0 ");
                }
                for (int k = D; k > i; k--)
                {
                    Console.Write("~ ");
                }
                for (int l = D; l > i; l--)
                {
                    Console.Write("~ ");
                }
                for (int m = 0; m < i; m++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}