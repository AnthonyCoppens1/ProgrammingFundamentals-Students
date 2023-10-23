using System;

namespace _06JaggedArrays_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a jagged array
            int[][] ints = new int[3][];
            ints[0] = new int[] { 1, 2, 3, 4 };
            ints[1] = new int[] { 5 };
            ints[2] = new int[] { 6, 7, 8 };

            string[][] fruit = {new string[] {"apple", "banana", "apricot"},
            new string[] {"coconut"},
            new string[] {"dragonfruit", "durian"},
            new string[] {"grapes", "dragonfruit", "passionfruit"}};

            double[][] doubles = {new double[] {1.2,5,8},
            new double[] {4,5.8,7}};


            //get values of the arrays
            Console.WriteLine(fruit[2][0]);
            Console.WriteLine(doubles[1][1]);
            doubles[1][1] = 6;
            Console.WriteLine(doubles[1][1]);


            //loop through arrays
            Console.WriteLine(fruit.Length);
            for (int i = 0; i < fruit.Length; i++) //length = 4 --> amount of arrays inside
            {
                for (int j = 0; j < fruit[i].Length; j++)
                {
                    Console.Write(fruit[i][j] + " ");
                }
                Console.WriteLine();
            }

            foreach (var item in fruit)
            {
                foreach(var element in item)
                {
                    Console.Write(element + " ");
                }
            }


        }
    }
}