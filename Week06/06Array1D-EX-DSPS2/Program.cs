using System;

namespace _06Array1D_EX_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, -3, 6, 9, 2, 3, -4, 5 };

            //easy way --> find sum, average, min, sort and reverse, ...
            Console.WriteLine("sum: " + array.Sum());
            Console.WriteLine("min: " + array.Min());
            Console.WriteLine("average: " + array.Average());
            Array.Sort(array);
            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }


            //algorithmic way
            //create the array, find the sum and average

            array = new int[] { 1, 8, -3, 6, 9, 2, 3, -4, 5 };
            //gets the original back and overwrites it

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; //sum = sum + array[i]
            }
            Console.WriteLine("\nsum: " + sum);
            Console.WriteLine("average: " + (sum / array.Length));


            //find the minimum
            int min = array[0];
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("min: " + min);


            //sorting an algorithm
            for (int i = 0; i < array.Length; i++)
            {   //checks multiple times for max all elements times
                for (int j = 0; j < array.Length - 1; j++)
                {   //checks array
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            //print array
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



        }
    }
}