using System;
using System.Collections.Generic;
using System.Linq;

namespace _09MethodsProject_DSPS1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            HelloWorld();

            //Add(5,10);
            //Add(201, 99);
            Console.WriteLine(Add(5, 10));
            int answer = Add(5, 10);
            Console.WriteLine(answer);

            int[] nrs1 = { 4, 5, 1, 0, 2, 3 };
            Print(nrs1);
            Array.Sort(nrs1);
            Print(nrs1);

            int[] nrs2 = { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            Print(nrs2);
            Array.Sort(nrs2);
            Print(nrs2);

            int[] nrs3 = Fill();
            Print(nrs3);
            Array.Sort(nrs3);
            Print(nrs3);

            int[] nrs4 = Fill(20);
            Print(nrs4);
            Array.Sort(nrs4);
            Print(nrs4);

            string[] words = { "banana", "apple", "lemon" };
            Print(words);
            Array.Sort(words);
            Print(words);

            double[] doubles = { 1.2, 1.0, 1.01 };
            Print(doubles);
            Array.Sort(doubles);
            Print(doubles);


            //pass by value
            int studentGrade = 75;
            Console.WriteLine($"Student's grade BEFORE extra credit: {studentGrade}");
            GiveExtraCredit(ref studentGrade);
            Console.WriteLine($"Student's grade AFTER extra credit: {studentGrade}");


            int[] grades = new int[1];
            grades[0] = 80;
            Console.WriteLine($"Student's grade ARRAY  BEFORE extra credit: {grades[0]}");
            GiveExtraCreditArray(grades);
            Console.WriteLine($"Student's grade ARRAY AFTER extra credit: {grades[0]}");


            int a = 6;
            int b = 8;
            Console.WriteLine($"a: {a} and b: {b}");
            SwapValue(ref a, ref b);
            Console.WriteLine($"a: {a} and b: {b}");


            Console.Write("Enter array size: ");
            string A = Console.ReadLine();
            int[] array;

            if (Int32.TryParse(A, out int size))
            {
                array = Fill(size);
            }
            else
            {
                array = Fill();
            }
            Print(array);



            int add;
            int mult;

            AddandMultiply(5, 10, out add, out mult);
            Console.WriteLine(add);
            Console.WriteLine(mult);



            AddValues(5, z: 7);
            int littleNumber = AddValues(5, z: 7);
            Console.WriteLine(littleNumber + 5);



            //params keyword
            //int[] myArray = { 5, 6, 7, 8, 9, 10 };
            PrintArray(5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

        }

        static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static int AddValues(int x, int y = 1, int z = 4)
        {
            int answer = x + y + z;
            return answer;
        }

        static void AddandMultiply(int a, int b, out int added, out int multiplied)
        {
            added = a + b;
            multiplied = a * b;
        }

        static void SwapValue(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }


        static void GiveExtraCredit(ref int numbers)
        {
            numbers += 3;
        }
        static void GiveExtraCreditArray(int[] array)
        {
            array[0] += 3;
        }

        static int[] Fill(int size = 10)
        {
            Random rd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(-20, 21);
            }

            return array;

            //Array.Sort(array); --> DEAD CODE
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
            //Console.WriteLine(answer);
        }

        static void Print(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(double[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(string[] words)
        {
            foreach (var item in words)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


    }
}
