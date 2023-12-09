using System;

namespace _10RevisionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintThisOut();
            int a = 7;
            int b = 10;
            //int sum = CountAndMultiply(6,12);
            //Console.WriteLine(sum);
            (int sum,int dance)= CountAndMultiply(a, b);

            Console.WriteLine(CountAndMultiply(a, b));

            Plus(ref a,ref b);
            Console.WriteLine(a + " " + b);

            int sub;
            minus(a, b, out sub);
            Console.WriteLine(sub);

            int[] array = { 3, 2, 7, 9, 5 };
            PlusFive(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(a + " " + b);
            countemup(a);


            Print(array);
            double[] doubles = { 3.1, 2.7 };
            Print(doubles);
        }

        static void Print(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void countemup(int a, int b = 12)
        {
            int answer = a + b;
            Console.WriteLine();
            Console.WriteLine(answer);
        }

        static void PlusFive(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 3;
            }
        }

        static void minus(int a, int b, out int subtracted)
        {
            subtracted = a - b;
        }

        static void Plus(ref int a,ref int b)
        {
            a += 5;
            b += 7;
        }

        static (int,int) CountAndMultiply(int a, int b)
        {
            int multiplied = a * b;
            int add = a + b;
            return (add,multiplied);
        }


        static void PrintThisOut()
        {
            Console.WriteLine("This is the message we want to print.");
        }
    }
}