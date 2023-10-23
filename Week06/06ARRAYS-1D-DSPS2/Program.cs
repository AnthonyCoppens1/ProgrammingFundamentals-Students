using System;

namespace _06ARRAYS_1D_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an array
            int[] intArray = new int[10]; //all elements = 0
            string[] stringArray = new string[4]; // all elements = ""

            double[] doubles = { 1.5, 9, 10.0, -6, 12, 5.6 };
            Console.WriteLine(doubles.Length);

            int[] ints = { 1, 3, 8, 23, 99 };

            //get values of these arrays
            Console.WriteLine($"First element of intArray: {intArray[0]}");
            Console.WriteLine($"Last element of doubles: {doubles[5]}");
            Console.WriteLine($"Last element of doubles: {doubles[doubles.Length-1]}");
            Console.WriteLine($"Last element of doubles: {doubles[^1]}"); //returns last element in array
            Console.WriteLine($"Last element of doubles: {doubles[^2]}"); //returns second to last element


            //^ starts counting from the back

            //assigning values to an array
            stringArray[0] = "Dean";
            stringArray[1] = "Tom";
            stringArray[2] = "John";
            stringArray[3] = "Bob";

            //stringArray[4] = "New guy"; //-->index out of range

            Console.WriteLine($"Last element of doubles: {doubles[^1]}");
            doubles[5] = 1.0;
            Console.WriteLine($"Last element of doubles: {doubles[^1]}");

            //we can also loop through arrays

            foreach (var item in stringArray) //loops when you don't need the index of an element or you don't know what's inside
            {
                Console.WriteLine(item);
            }

            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            foreach(double d in doubles)
            {
                Console.Write(d + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < doubles.Length; i++)
            {
                Console.WriteLine(doubles[i]);
            }



            /*!!!!!!!!!!!!!!!!
             * !!!!!!!!!!!!!!!DO NOT DO THIS OR EVEN ATTEMPT!!!!!!!!!!
             * !!!!!!!!!!!!!!!!!!*/

            int index = 0;
            while (index < doubles.Length)
            {
                Console.WriteLine(doubles[index]);
                index++; //otherwise infinite loop
            }

            Console.WriteLine();

            //overwrite the entire array
            doubles = new double[] { 1, 3, 4, -1, -4, 55, 8, 89 };
            foreach (var item in doubles)
            {
                Console.Write(item + " "); //same line, split with a space
            }
            Console.WriteLine();


            //Filling an array using a for-loop
            for (int i = 0; i < intArray.Length; i++)
            {
                //intArray[i] = i * 4;

                //fill with user input
                Console.WriteLine($"Enter a number, index {i}: ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //check the array
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();



            //fill an array using split-method
            Console.WriteLine("Enter animals, separated by a space: ");
            string answer = "cat elephant hypo buffalo dog horse fox"; //Console.ReadLine();"cat elephant hypo buffalo dog horse fox"

            string[] animals = answer.Split(' ');
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Enter animals, separated by a ; : ");
            answer = "cat;elephant;hypo;buffalo;dog;horse;fox"; //Console.ReadLine();"cat elephant hypo buffalo dog horse fox"

            animals = answer.Split(';');
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }



            //fill and convert arrays with split method
            Console.WriteLine("Enter numbers, separated by a space: ");
            answer = Console.ReadLine(); //"8 7 -1 5 6 10 0 -3"
            string[] strArray = answer.Split(' ');
            int[] arrayOfInts = new int[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                arrayOfInts[i] = Convert.ToInt32(strArray[i]);
            }

            foreach (int i in arrayOfInts)
            {
                Console.Write(i + " ");
            }


            //or convert whole array in 1 go

            arrayOfInts = Array.ConvertAll(strArray, Convert.ToInt32);

        }
    }
}