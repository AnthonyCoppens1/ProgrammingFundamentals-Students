using System;

namespace _03NameOfMonth_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* write a programme that asks for a month based on a number. 
             * output the corresponding month's name as a message if it matches the number.
             * E.g. 1 --> January / 2 --> February / 7 --> July / ... 
             USE A SWITCH !!!
            
            switch ()
            {
            case :
                ...
                break;
            }
             */
            
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 12:
                    Console.WriteLine("December");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                default:
                    Console.WriteLine("Pre-summer");
                    break;
            }




        }
    }
}