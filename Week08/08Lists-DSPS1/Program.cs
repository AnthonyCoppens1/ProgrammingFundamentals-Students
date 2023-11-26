using System;
using System.Collections.Generic;

namespace _08Lists_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D arrays --> set length
            int[] nrArray = new int[5];
            nrArray[0] = 5;
            nrArray[1] = 10;
            nrArray[2] = 15;
            nrArray[3] = 20;
            nrArray[4] = 25;

            //list /w variabel length depending on the # elements inside of it at that moment
            List<int> ints = new List<int>();
            ints.Add(5);
            ints.Add(10);
            ints.Add(15);
            ints.Add(20);
            ints.Add(25);

            //print the list
            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();

            //insert numbers in a chosen spot --> everything past index moves up 1 spot
            ints.Insert(2, 12);

            //same index means latest gets put in that index position, time after time
            ints.Insert(4, 21);
            ints.Insert(4, 22);

            //add multiple elements
            int[] numbers = { 7, 8, 9 };
            ints.AddRange(numbers);

            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();


            //insert an array at an index
            ints.InsertRange(1, numbers);


            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //789 appears twice, we want to take care of that!
            ints.Remove(7);
            ints.Remove(8);
            ints.Remove(9);

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            ints.Add(5);
            ints.RemoveAt(10);
            //ints.RemoveAt(ints.IndexOf(20)); --> don't do this, just use .Remove()

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            //more ways of adding elements and numbers to a list
            List<int> N = new List<int>();
            N.Add(1);
            N.Add(5);

            for (int i = 0; i < N.Count; i++)
            {
                Console.Write(N[i] + " ");
            }
            Console.WriteLine();


            //insert at correct position in correct order
            for (int i = 2; i < 5; i++)
            {
                N.Insert(i - 1, i);
            }

            //print it out
            for (int i = 0; i < N.Count; i++)
            {
                Console.Write(N[i] + " ");
            }
            Console.WriteLine();


            /*for (int i = 4; i > 1; i--)
            {
                N.Insert(1, i);
            }

            for (int i = 0; i < N.Count; i++)
            {
                Console.Write(N[i] + " ");
            }
            Console.WriteLine();*/


            //list of strings
            List<string> str = new List<string> { "one", "two", "three" };

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            str.Add("four");
            str.Add("five");
            str.Insert(0, "-one"); //at index 0, rest moves up
            str.Remove("two");
            str.RemoveAt(4); //five should get removed

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            //find the index of a word
            int index = str.IndexOf("three");
            Console.WriteLine(index);

            str.Add("one"); //one appears twice
            int last = str.LastIndexOf("one");
            Console.WriteLine(last);

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            //check list if anything is in there, make adjustments based on it
            str.Add("more");
            if (str.Contains("more"))
            {
                index = str.IndexOf("more");
                str.Insert(index, "thomas");
            }

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();


            //list to array
            string[] strings = str.ToArray();

            //array to list
            double[] doubles = { 1.2, 2.3, 3.4, 4.5 };
            List<double> doublesList = doubles.ToList();


            //another example for lists
            List<bool> B = new List<bool> { true, false, false, true };

        }
    }
}