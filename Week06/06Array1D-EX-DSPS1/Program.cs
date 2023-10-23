using System;

namespace _06Array1D_EX_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 8, -3, 15, 20, 0, 78, -15, -6, 30 };

            //get sum, min, average, sort, reverse, ..
            //easy way

            Console.WriteLine("sum: " + array.Sum());
            Console.WriteLine("min: " + array.Min());
            Console.WriteLine("average: " + array.Average());
            Array.Sort(array);
            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            //algorithmic way --> harder than the easy way
            //creating an array and finding sum and average

            array = new int[]{ 12, 8, -3, 15, 20, 0, 78, -15, -6, 30 };
            //overwrite the elements to get original array back

            //SUM
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; //sum = sum + array[i]
            }

            Console.WriteLine("sum: " + sum);
            Console.WriteLine("average: " + sum / array.Length);

            //find the MIN
            int min = array[0];
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("min: " + min);


            //sorting algorithm
            //https://en.wikipedia.org/wiki/Bubble_sort
            //check from start, each adjacent pair --> if 2nd is bigger than first, of not, swap and move 1, check again for array
            //repeat until whole array is sorted
            
            for (int i = 0; i < array.Length; i++)
            { //checks multiple times for max all elements times
                for (int j = 0; j < array.Length-1; j++)
                { //checks the array
                    if (array[j] > array[j + 1]) //want to reverse? --> swap > with <
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            //print array
            foreach(var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            

        }
    }
}