namespace _04For_loops_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loops
            //multiply a given number by 1, 2, 3, ...

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //idiot version
            Console.WriteLine($"{number} * 1 = {number * 1}");
            Console.WriteLine($"{number} * 2 = {number * 2}");
            Console.WriteLine($"{number} * 3 = {number * 3}");
            Console.WriteLine($"{number} * 4 = {number * 4}");


            //actual better version of the idiot version
            Console.WriteLine("\nFOR LOOP i=0 i<= 10");
            for (int i = 0; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            Console.WriteLine("\nFOR LOOP i = 1 and i <= 10");
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }



            Console.WriteLine("\nFOR LOOP i = 0 and i <= 10 and STEPSIZE 2");
            for (int i = 0; i <= 10; i += 2)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }



            //CAREFUL INFINITE LOOP --> 0*2 = 0
            Console.WriteLine("\nFOR LOOP i = 0 i<= 10 and stepsize * 2");
            /*for (int i = 0; i <= 10; i *= 2)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }*/
            //multiple should start at 1
            for (int i = 1; i <= 10; i *= 2)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            Console.WriteLine("\nFOR LOOP i = 10 i >= 0 i--");
            for (int i = 10; i >= 0; i--)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            //infinite loop because condition is true and keeps increasing 10 11 12 13
            /*for (int i = 10; i >= 0; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }*/


            //print 3 6 9 12 15 18 21 ... --> this code goes to 33*3
            Console.WriteLine("\nversion 1: sequence 3 6 9 12 15 18 21...");
            for (int i = 1; i <= 33; i++)
            {
                int result = i * 3;
                Console.Write(result + " ");
            }


            Console.WriteLine("\nversion 2: sequence 3 6 9...");
            for (int i = 3; i <= 100; i += 3)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine("\nversion 3: 3 6 9 12 ...");
            for (int i = 3; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }



            //nesting for-loops
            Console.Write("\n\nEnter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTable of j's");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nTable of stars ***");
            for (int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nTable of i's");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            /* x = 5
             * 1
             * 2 2
             * 3 3 3
             * 4 4 4 4
             * 5 5 5 5 5
             * 
             * x = 3
             * 1
             * 2 2
             * 3 3 */

            Console.WriteLine("\nPYRAMID!");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

         }
    }
}