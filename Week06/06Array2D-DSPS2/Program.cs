using System;

namespace _06Array2D_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a 2D array
            int[,] ints = new int[4, 5];
            string[,] fruit = { { "banana", "kiwi", "strawberry", "orange", "apple"},
            {"dragonfruit", "peach", "pineapple", "pear", "mango" },
            { "watermelon", "starfruit", "grape", "lemon", "lime" }};

            //get values
            //keep in mind --> it starts at 0,0
            Console.WriteLine($"element from row 1, col 1: {fruit[0, 0]}");
            Console.WriteLine($"element from row 2 col 4: {fruit[1, 3]}");

            fruit[1, 3] = "TOMATO";
            Console.WriteLine($"element from row 2 col 4: {fruit[1, 3]}");


            //loop arrays
            Console.WriteLine(fruit.Length);
            Console.WriteLine("# rows: " + fruit.GetLength(0));
            Console.WriteLine("# cols: " + fruit.GetLength(1)); //checks dimensions

            Console.WriteLine();

            //rows
            for (int i = 0; i < fruit.GetLength(0); i++)
            {
                for( int j = 0; j < fruit.GetLength(1); j++)
                {
                    Console.Write(fruit[i, j] + "\t"); //\t --> horizontal tab
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //fill array /w random numbers --> create sum afterwards
            Random rd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rd.Next(0, 21);
                    Console.Write(ints[i,j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            foreach (int number in ints)
            {
                sum += number;
            }
            Console.WriteLine("sum: " + sum);

        }
    }
}