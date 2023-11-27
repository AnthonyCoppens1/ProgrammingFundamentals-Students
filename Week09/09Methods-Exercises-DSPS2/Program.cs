using System;

namespace _09Methods_Exercises_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exercise = Console.ReadLine();
            switch (exercise)
            {
                case "1":
                    //multiplication table --> "0 * ... = ... / 1 * ... = ...
                    int number = int.Parse(Console.ReadLine());
                    int amount = int.Parse(Console.ReadLine());
                    MultiplicationTable(number, amount);
                    break;

                case "2":
                    //SquareAndCube
                    int NR = int.Parse(Console.ReadLine());
                    SquareAndCube(NR);
                    break;

                case "3":
                    //ArrayConverterAndSum 
                    string N = Console.ReadLine();
                    char cc = Convert.ToChar(Console.ReadLine());
                    ArrayConverterAndSum(N,cc);
                    break;
            }

            static int[] Conversion(string C, char cc)
            {
                string[] s = C.Split(cc);
                int[] ints = new int[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    ints[i] = int.Parse(s[i]);
                }
                return ints;
            }

            static void Sum(int[] nums)
            {
                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                }
                Console.WriteLine($"The sum is {sum}");
            }

            static void ArrayConverterAndSum(string N, char cc)
            {
                int[] array = Conversion(N, cc);
                Sum(array);

                /*string[] s = N.Split(' ');
                int[] ints = new int[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    ints[i] = int.Parse(s[i]);
                }

                int sum = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    sum += ints[i];
                }
                Console.WriteLine($"The sum is: {sum}");*/
            }

            static void SquareAndCube(int number)
            {
                int squared = Square(number);
                int cubed = Cube(number);
                Console.WriteLine(squared);
                Console.WriteLine(cubed);
            }

            static int Cube(int number)
            {
                int answer = Square(number) * number;
                return answer;
            }

            static int Square(int number)
            {
                int answer = number * number;
                return answer;
            }

            static void MultiplicationTable(int number,int amount)
            {
                for (int i = 0; i < amount; i++)
                {
                    int answer = number * i;
                    Console.WriteLine("{0,2} * {1} = {2}",i,number,answer);
                }
            }


        }
    }
}