using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _08Lists_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D array --> set length
            int[] nrArray = new int[5];
            nrArray[0] = 5;
            nrArray[1] = 10;
            nrArray[2] = 15;
            nrArray[3] = 20;
            nrArray[4] = 25;
            


            //list --> variable length, depending on the elements inside at that point
            List<int> nr = new List<int>();
            nr.Add(5);
            nr.Add(10);
            nr.Add(15);
            nr.Add(20);
            nr.Add(25);

            //print list
            for (int i = 0; i < nr.Count; i++)
            {
                Console.Write(nr[i] + " ");
            }
            Console.WriteLine();


            //insert numbers in a chosen spot
            nr.Insert(2, 12);

            //current position index moves up 1 spot every time
            nr.Insert(4, 21);
            nr.Insert(4, 22);


            //add multiple elements at the end
            int[] numbers = { 7, 8, 9 };

            nr.AddRange(numbers); //only takes 1 arguement

            for (int i = 0; i < nr.Count; i++)
            {
                Console.Write(nr[i] + " ");
            }
            Console.WriteLine();


            //adding array in specific pos
            nr.InsertRange(1, numbers);

            for (int i = 0; i < nr.Count; i++)
            {
                Console.Write(nr[i] + " ");
            }
            Console.WriteLine();


            //789 appears twice, we'll remove this problem
            nr.Remove(7);
            nr.Remove(8);
            nr.Remove(9);

            for (int i = 0; i < nr.Count; i++)
            {
                Console.Write(nr[i] + " ");
            }
            Console.WriteLine();

            //remove at specific index
            nr.Add(5);
            nr.RemoveAt(0);

            for (int i = 0; i < nr.Count; i++)
            {
                Console.Write(nr[i] + " ");
            }
            Console.WriteLine();

            int indexOfnr = nr.IndexOf(21);
            Console.WriteLine(indexOfnr);


            //more ways of adding elements and numbers
            List<int> N = new List<int>();
            N.Add(1);
            N.Add(5);

            //insert at correct position in the correct order
            for (int i = 1; i < 4; i++)
            {
                N.Insert(i, i+1);
            }

            for (int i = 0; i < N.Count; i++)
            {
                Console.Write(N[i] + " ");
            }
            Console.WriteLine();



            //the confusing way:
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

            //adding more
            str.Add("four");
            str.Add("five");
            str.Insert(0, "zero");

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            str.Remove("two");
            str.RemoveAt(4); //five gets removed

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();


            //find an index of word in a list
            int index = str.IndexOf("three");
            Console.WriteLine(index);

            str.Add("one");
            int last = str.LastIndexOf("one");
            Console.WriteLine(last);


            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            str.RemoveAt(last);

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();



            //adding word to the list and checking if it's there, making adjustments based on this

            str.Add("more");
            if (str.Contains("more"))
            {
                index = str.IndexOf("more");
                str.Insert(index, "thomas");
            }

            //change word with another, without knowing the index,
            //but knowing the word and its existence
            str[str.IndexOf("thomas")] = "Anthony";

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();


            //list to array
            string[] strings = str.ToArray();

            //array to list
            double[] doubles = { 1.2, 2.3, 3.4, 4.5 };
            List<double> D = doubles.ToList();


            //another form of a list
            List<bool> B = new List<bool> { true, false, false, false, true, true };

        }
    }
}