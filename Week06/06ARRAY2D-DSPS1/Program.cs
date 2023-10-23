using System;

namespace _06ARRAY2D_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create 2D array

            int[,] ints = new int[4, 5];
            string[,] fruit =    
                { {"apple", "pineapple", "lemon", "orange"},
            {"mango", "lime", "banana", "watermelon" },
            {"peach", "grapefruit", "strawberry", "kiwi" }};

            //get values
            //keep in mind that we start at [0,0]
            Console.WriteLine($"element of row 1 col 1: {fruit[0, 0]}");
            Console.WriteLine($"element of row 2 col 1: {fruit[1, 0]}");

            fruit[1, 0] = "pear";
            Console.WriteLine($"element of row 2 col 1: {fruit[1, 0]}");


            //loop through the arrays
            Console.WriteLine(fruit.Length); //length of ALL ELEMENTS
            Console.WriteLine("#rows: " + fruit.GetLength(0));
            Console.WriteLine("#cols: " + fruit.GetLength(1)); //refers to dimensions

            //loop through rows:
            for (int i = 0; i < fruit.GetLength(0); i++)
            {
                for (int j = 0;  j < fruit.GetLength(1); j++)
                {
                    Console.Write(fruit[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //all in 1 row
            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //filling array with random numbers --> create a sum
            Random rd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++) //rows
            {
                for (int j = 0; j < ints.GetLength(1); j++) //columns
                {
                    ints[i, j] = rd.Next(0, 21);
                    Console.Write(ints[i,j] + "\t"); //\t --> horizontal tab
                }
                Console.WriteLine();
            }

            int sum = 0;
            foreach (var item in ints)
            {
                sum += item;
            }
            Console.WriteLine("sum: " + sum);

        }
    }
}