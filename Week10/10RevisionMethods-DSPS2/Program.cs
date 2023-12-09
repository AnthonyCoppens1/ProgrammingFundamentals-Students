using System;

namespace _10RevisionMethods_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintThisOut();

            int a = 7;
            int b = 10;

            int c = Count(200, 100);
            Console.WriteLine(Count(a, b));

            int sum = Count(a, b);
            Console.WriteLine(sum + 10 + c);

            (int mult, int count) = CountAndMultiply(a, b);
            Console.WriteLine(mult + " " + count);

            /*int[] array = new int[2];

            (array[0], array[1]) = CountAndMultiply(a, b);

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }*/

            Plus(ref a,ref b);
            Console.WriteLine(a + " " + b); // 7 and 10 --> 12 and 17

            int sub;
            minus(ref a,ref b, out sub); //minus (a, b, out sub);
            Console.WriteLine(sub);
            Console.WriteLine(a + " " + b);

            int[] ARRAY = { 5, 7, 3, 9, 2, 0, 1 };
            PlusSix(ARRAY);
            for (int i = 0; i <  ARRAY.Length; i++)
            {
                Console.Write(ARRAY[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(a + " " + b);

            CountTemp(30);

            Print(ARRAY);
            double[] doubles = { 5.2, 3.1 };
            Console.WriteLine();
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
            for (int i = 0; i <  array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void CountTemp(int a, int b = 4)
        {
            int answer = a + b;
            Console.WriteLine(answer);
        }

        static void PlusSix(int[] ARRAY)
        {
            for (int i = 0; i < ARRAY.Length; i++)
            {
                ARRAY[i] += 6;
            }
        }



        static void minus(ref int a,ref int b, out int subtracted) //remove ref for original
        {
            a += 10; 
            b += 10;
            subtracted = b - a;
           
        }

        static void Plus(ref int a,ref int b)
        {
            a += 5;
            b += 7;
        }


        static (int,int) CountAndMultiply(int a, int b)
        {
            int multiply = a * b;
            int count = a + b;
            return (multiply, count);
        }

        static int Count(int a, int b)
        {
            int add = a + b;
            return add;
        }


        static void PrintThisOut()
        {
            Console.WriteLine("Print this line out to the console.");
        }

    }
}