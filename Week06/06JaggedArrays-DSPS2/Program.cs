using System;

namespace _06JaggedArrays_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create jagged arrays
            int[][] ints = new int[3][];
            ints[0] = new int[] { 1, 2, 3, 4 };
            ints[1] = new int[] { 5 };
            ints[2] = new int[] { 6, 7, 8 };

            string[][] fruit = {new string[] {"apple", "apricot", "banana"},
            new string[] {"berry", "blueberry", "breadfruit", "coconut"},
            new string[] {"passionfruit"},
            new string[] {"dragonfruit", "durian" }};

            double[][] doubles = {new double[] {1.2, 5, 8},
            new double[]{4, 5.8, 7}};


            //get values
            Console.WriteLine(fruit[2][0]);
            Console.WriteLine(doubles[1][1]);
            doubles[1][1] = 6;
            Console.WriteLine(doubles[1][1]);


            //loop arrays
            Console.WriteLine(fruit.Length);
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