using System;

namespace _03If_statement_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*check if a number is smaller than, equal to or greater than 50
            use of if-statements along the way in different variants*/

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 50) 
            {
                Console.WriteLine("Number is smaller than 50");
            }
            else if (number == 50)
            {
                Console.WriteLine("Number is equal to 50");
            }
            else
            {
                Console.WriteLine("Number is bigger than 50");
            }

            
            //need an else before other if
            if (number < 50)
            {
                Console.WriteLine("Number < 50");
            }
            if (number == 50) //new if --> not part of above statement
            {
                Console.WriteLine("Number = 50");
            }
            else
            {
                Console.WriteLine("Number > 50");
            }


            //option 2 if inside of else --> nesting
            if (number < 50)
            {
                Console.WriteLine("smaller than 50");
            }
            else
            {
                if (number == 50)
                {
                    Console.WriteLine("Equal to 50");
                }
                else
                {
                    Console.WriteLine("Greater than 50");
                }
            }


            //option 3: combining if's
            if (number != 50)
            {
                if (number < 50)
                {
                    Console.WriteLine("Small");
                }
                else
                {
                    Console.WriteLine("BIG");
                }
            }
            else
            {
                Console.WriteLine("EQUAL");
            }


            //option 4:  if in an else #2

            if (number > 50)
            {
                Console.WriteLine("Greater than 50!");
            }
            else
            {
                if (number == 50)
                {
                    Console.WriteLine("Equal to 50");
                }
                else
                {
                    Console.WriteLine("Smaller than 50!");
                }
            }


            //combining checks
            //check if a number is (not) equal to 50
            //option 1

            if (number == 50)
            {
                Console.WriteLine("Number is equal to 50");
            }
            else
            {
                Console.WriteLine("Number is NOT equal to 50");
            }


            //option 2 --> OR ||
            if (number < 50 || number > 50)
            {
                Console.WriteLine("Number is not equal to 50");
            }
            else
            {
                Console.WriteLine("Number is equal to 50");
            }

            //option 3
            if (number != 50)
            {
                Console.WriteLine("Number != 50");
            }
            else
            {
                Console.WriteLine("Number == 50");
            }


            //option 4
            if (!(number == 50))
            {
                Console.WriteLine("Number is not equal to 50");
            }
            else
            {
                Console.WriteLine("Number is equal to 50");
            }


            //option 5
            if (number == 50 && !(number != 50))
            {
                Console.WriteLine("Number is equal to 50");
            }
            else
            {
                Console.WriteLine("Number is not equal to 50");
            }


            //option 6
            bool condition = number != 50;
            if (condition) // condition == true --> checked
            {
                Console.WriteLine("Number is not equal to 50");
            }
            else
            {
                Console.WriteLine("Number is equal to 50");
            }


            //option 7
            if (!condition)
            {
                Console.WriteLine("Number is equal to 50");
            }
            else
            {
                Console.WriteLine("Number is NOT equal to 50");
            }





        }
    }
}