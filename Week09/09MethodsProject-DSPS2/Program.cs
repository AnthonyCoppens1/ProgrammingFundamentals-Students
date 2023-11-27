using System;
using System.ComponentModel;

namespace _09MethodsProject_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            int number = Add(5, 10);
            number += 5;
            Console.WriteLine(number);

            Console.Write(Add(201, 99) + 100);
            Console.WriteLine();

            int[] nrs1 = { 4, 5, 1, 0, 2, 3 };
            Print(nrs1);
            Array.Sort(nrs1);
            Print(nrs1);

            int[] nrs2 = { 12, 10, 8, 6, 4, 2 }; //length doesnt matter
            Print(nrs2);
            Array.Sort(nrs2);
            Print(nrs2);

            int[] nrs3 = Fill(5);
            Print(nrs3);
            Array.Sort(nrs3);
            Print(nrs3);

            int[] nrs4 = Fill();
            Print(nrs4);
            Array.Sort(nrs4);
            Print(nrs4);

            string[] words = { "banana", "apple", "lemon" };
            Print(words);
            Array.Sort(words);
            Print(words);

            double[] D = { 1.2, 1.1, 1.01 };
            Print(D);
            Array.Sort(D);
            Print(D);


            //pass by value
            var studentGrade = 75;
            Console.WriteLine($"Student's grade BEFORE extra credit: {studentGrade}");
            GiveExtraCredit(ref studentGrade);
            Console.WriteLine($"Student's grade AFTER extra credit: {studentGrade}");


            //pass by reference
            int[] grades = new int[1];
            grades[0] = 80;
            Console.WriteLine($"Student's grade ARRAY BEFORE extra credit: {grades[0]}");
            GiveExtraCreditArray(grades);
            Console.WriteLine($"Student's grade ARRAY AFTER extra credit: {grades[0]}");



            //more on value types
            int a = 6;
            int b = 8;
            Console.WriteLine($"a: {a} and b: {b}");
            SwapValue(a, b);
            //Console.WriteLine(SwapValue(a, b));
            Console.WriteLine($"a: {a} and b: {b}");



            //using out --> old way that you should know
            Console.Write("Enter array size: ");
            string answer = Console.ReadLine();
            int size;
            int[] array;
            if (Int32.TryParse(answer, out size))
            {
                array = Fill(size);
            }
            else
            {
                array = Fill();
            }
            Print(array);


            //using out --> new way
            int add;
            int mult;
            int total;
            AddandMultiply(5, 10, out add, out mult, out total);
            Console.WriteLine(add);
            Console.WriteLine(mult);
            Console.WriteLine(total);


            //optional parameters

            AddValues(5);
            AddValues(5, z: 12);


            //params keyword
            int[] myArray = { 5, 6, 7, 8, 9, 10 };
            PrintMyArray(myArray);
            PrintMyArray(5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

        }

        static void PrintMyArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void AddValues(int x, int y = 1, int z = 7)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }

        static void AddandMultiply(int a, int b, out int added, out int multiplied, out int total)
        {
            added = a + b;
            multiplied = a * b;
            total = added + multiplied;
        }

        static (int,int,string) SwapValue(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            string str = "HEllo";
            return (a, b, str);
            
        }

        static void GiveExtraCreditArray(int[] grades)
        {
            grades[0] += 3;
        }


        //static int GiveExtraCredit(int studentGrade) --> return studentGrade at end
        //in main: --> studentGrade = GiveExtraCredit(studentGrade);
        static void GiveExtraCredit(ref int number)     
        {
            number += 3;
        }


        static int[] Fill(int size = 10)
        {
            Random rd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(-20,21);
            }

            return array;

            //Array.Sort(array); --> DEAD CODE
        }
        static void Print(double[] doubles)
        {
            foreach (var item in doubles)
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

        static void Print(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello, World");
        }
    }
}