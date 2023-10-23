using System;

namespace _06ARRAY1D_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create array --> 1D

            int[] intArray = new int[10]; //all values are 0
            string[] stringArray = new string[4]; //all values are ""

            double[] doubles = { 1.5, 9, 10.0, -6, 12, 5.6 }; //add value immediately
            Console.WriteLine(doubles.Length);

            int[] ints = { 1, 3, 8, 23, 99 };

            //get values
            Console.WriteLine("First element of intArray: " + intArray[0]);
            Console.WriteLine($"Last element of doubles: {doubles[5]}");
            Console.WriteLine($"Last element of doubles: {doubles[doubles.Length-1]}");
            Console.WriteLine($"Last element of doubles: {doubles[^1]}");

            //^starts counting form end --> ^1 is last element, ^2 is second to last

            //assigning values
            stringArray[0] = "Dean";
            stringArray[1] = "Tom";
            stringArray[2] = "John";
            stringArray[3] = "Bob";
            //stringArray[4] = "New guy"; --> index out of range

            Console.WriteLine($"Last element of doubles: {doubles[^1]}");
            doubles[5] = 1.0;
            Console.WriteLine($"Last element of doubles: {doubles[^1]}");


            //looping through arrays
            foreach(var item in stringArray) //loop when you don't need the index of an element or you don't know what's inside
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (string s in stringArray)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < doubles.Length; i++)
            {
                Console.Write(doubles[i] + " ");
            }

            Console.WriteLine();


            //!!!!!!!NEVER USED IN CODING!!!!!!!!!!!! -->while
            int index = 0;
            while (index < doubles.Length)
            {
                Console.WriteLine(doubles[index]);
                index++; //if you don't add this, it'll become infinite
            }


            //overwrite some values or an entire array
            doubles = new double[] { 1, 3, 4, -1, -4, 55, 8, 89 };
            foreach (var item in doubles)
            {
                Console.Write(item + " "); //same line, split with space
            }
            Console.WriteLine();


            //fill an array using a for-loop
            for (int i = 0; i < intArray.Length; i++)
            {
                //intArray[i] = i * 4;
                Console.Write($"Enter a number, index {i}: ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            //check the array --> intArray
            foreach (int item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //Fill an array using Split-Method
            Console.WriteLine("Enter animals, seperated by a space: ");
            string answer = "cat elephant dog horse fox"; //Console.ReadLine() 

            string[] animals = answer.Split(' ');
            foreach (string s in animals)
            {
                Console.WriteLine(s);
            }

            //fill one but this time separated by a ;
            Console.WriteLine("Enter animals, seperated by a ;  : ");
            answer = "cat;elephant;dog;horse;fox"; //Console.ReadLine();
            animals = answer.Split(';');
            foreach (string s in animals)
            {
                Console.WriteLine(s);
            }



            //fill and convert an array with our split-method
            Console.WriteLine("Enter numbers, separated by a space: ");
            answer = "8 7 -1 10 5 6 7 9 -3"; //Console.ReadLine();
            string[] strArray = answer.Split(' ');
            int[] arrayOfInt = new int[strArray.Length];

            for (int i = 0; i < arrayOfInt.Length; i++)
            {
                arrayOfInt[i] = Convert.ToInt32(strArray[i]);
            }

            //convert whole array in 1 go
            arrayOfInt = Array.ConvertAll(strArray, Convert.ToInt32);

            Console.WriteLine();

            foreach (var item in strArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in arrayOfInt)
            {
                Console.Write(item + " ");
            }
        }
    }
}