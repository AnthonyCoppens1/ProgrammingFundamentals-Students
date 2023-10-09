using System;

namespace _03Switch_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = 
                new System.Globalization.CultureInfo("en-US");


            //switch and tryparse
            //some info on dates

            int weekday = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(weekday);

            Console.WriteLine(DateTime.Now.ToString()); // whole date and current time

            string dayInWords = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(dayInWords); //day written in words instead of a number

            DateTime yesterday = new DateTime(2023, 10, 08); //DateTime(jjjj,mm,dd)
            string day = yesterday.DayOfWeek.ToString();
            Console.WriteLine(day);

            DateTime birthday = new DateTime(1995, 07, 31);
            day = birthday.DayOfWeek.ToString();
            Console.WriteLine(day);

            weekday = Convert.ToInt32(Console.ReadLine());

            if (weekday == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (weekday == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (weekday == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (weekday == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (weekday == 5)
            {
                Console.WriteLine("Friday");
            }
            else
            {
                Console.WriteLine("WOHOO WEEKEND");
            }


            //switch

            switch (weekday)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("It's weekend LETS GOOOOO");
                    break;
            }

            //TryParse --> avoid errors
            Console.Write("x = ");
            int y = 18;

            /*if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }*/

            string answer = Console.ReadLine();
            int x;
            bool check = Int32.TryParse(answer, out x);

            if (check)
            {
                if (x > y)
                {
                    Console.WriteLine("x is greater than y");
                }
            }
            else
            {
                Console.WriteLine("This is not a number, CRAZY OUTPUT!");
            }



            bool succes = Int32.TryParse(Console.ReadLine(), out int temp);
            if (succes)
            {
                if (temp > y)
                {
                    Console.WriteLine("It's hot in here");
                }
            }
            else
            {
                Console.WriteLine("This is not a temp");
            }


            if (!(Int32.TryParse(answer, out temp)))
            {
                Console.WriteLine("Crazy output");
            }
            else
            {
                if (temp < 0)
                {
                    Console.WriteLine("Cold as hell");
                }
            }








        }
    }
}