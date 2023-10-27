using System;

namespace _06JaggedArrays_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged array aanpaken

            int[][] ints = new int[3][];
            ints[0] = new int[] { 1, 2, 3, 4 };
            ints[1] = new int[] { 5 };
            ints[2] = new int[] { 6, 7, 8 };

            string[][] fruit = { new string[] { "appel", "appelsien", "abrikoos" },
            new string[] {"banaan", "bosbes", "drakenfruit" },
            new string[] {"kokosnoot" },
            new string[] {"peer", "kers" } };

            double[][] doubles = { new double[] {1.2, 5, 8},
            new double[]{4, 5.8, 7}};

            //waarden oproepen
            Console.WriteLine(fruit[2][0]);
            Console.WriteLine(doubles[1][1]);

            doubles[1][1] = 6;
            Console.WriteLine(doubles[1][1]);



            //loopen door jagged arrays
            Console.WriteLine(fruit.Length);
            Console.WriteLine(fruit[2].Length);

            for (int i = 0; i < fruit.Length; i++)
            {
                for (int j = 0; j < fruit[i].Length; j++)
                {
                    Console.Write(fruit[i][j] + " ");
                }
                Console.WriteLine();
            }

            foreach (var item in fruit)
            {
                foreach (var element in item)
                {
                    Console.Write(element + " ");
                }
            }

        }
    }
}