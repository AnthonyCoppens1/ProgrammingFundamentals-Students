using System;

namespace _09Oefeningen_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string oefening = Console.ReadLine();

            switch (oefening)
            {
                case "1":
                    int getal = int.Parse(Console.ReadLine());
                    Vermenigvuldigen(getal);
                    break;
                case "2":
                    int N = Convert.ToInt32(Console.ReadLine());
                    SquareAndCube(N);
                    break;

                case "3":
                    //5 3 8 7 2 9 12 --> som van alle getallen
                    string getallen = Console.ReadLine();
                    ArrayConverterAndSum(getallen);
                    break;
            }

            static int[] Conversion(string getallen)
            {
                string[] s = getallen.Split(' ');
                int[] ints = new int[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    ints[i] = int.Parse(s[i]);
                }
                return ints;
            }

            static void Sum(int[] ints)
            {
                int sum = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    sum += ints[i];
                }
                Console.WriteLine(sum);
            }


            static void ArrayConverterAndSum(string getallen)
            {
                int[] ints = Conversion(getallen);
                Sum(ints);

                /*string[] s = getallen.Split(' ');
                int[] ints = new int[s.Length];
                for (int i = 0; i < ints.Length; i++)
                {
                    ints[i] = int.Parse(s[i]);
                }

                int sum = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    sum += ints[i];
                }
                Console.WriteLine(sum);*/
            }

            static void SquareAndCube(int N)
            {
                Console.WriteLine(Square(N));
                Console.WriteLine(Cube(N));
            }

            static int Cube(int N)
            {
                int antwoord = Square(N) * N;
                return antwoord;
            }

            static int Square(int N)
            {
                int antwoord = N * N;
                return antwoord;
            }



            static void Vermenigvuldigen(int getal)
            {
                for (int i = 0; i < 11; i++)
                {
                    int antwoord = getal * i;
                    Console.WriteLine("{0,2} * {1} = {2}", i, getal, antwoord);
                }
            }
        }
    }
}