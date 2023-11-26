using System;
using System.Collections.Generic;

namespace _08StudentDatabase_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DO = Console.ReadLine();
            List<string> name = new List<string>();
            List<int> age = new List<int>();
            List<DateTime> birthday = new List<DateTime>();

            int index = 1;
            while(DO != "END")
            {
                if (DO == "ADD")
                {
                    Console.Write("Name: "); name.Add(Console.ReadLine());
                    Console.Write("Age: "); age.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Birthday: "); birthday.Add(Convert.ToDateTime(Console.ReadLine()));
                    Console.Write($"The student number is: {index}\n\n");
                    index++;
                    DO = Console.ReadLine();
                }
                else if (DO == "ADJUST")
                {
                    Console.Write("What's the student number? "); int number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: "); name[number-1] = Console.ReadLine();
                    Console.Write("Age: "); age[number-1] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Birthday: "); birthday[number-1] = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine();
                    DO = Console.ReadLine();
                }
                else if (DO == "DELETE")
                {
                    Console.Write("What's the student number? "); int number = Convert.ToInt32(Console.ReadLine());
                    name.RemoveAt(number - 1);
                    age.RemoveAt(number - 1);
                    birthday.RemoveAt(number - 1);
                    Console.Write($"The information of student {number} has been removed.\n");
                    DO = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("you have entered the wrong keyword. Terminating database. \n\n");
                    break;
                }
            }

            Console.WriteLine("Session ended. These are our students: \n");

            for (int i = 0; i < name.Count; i++)
            {
                Console.Write(name[i] + " " + age[i] + " " + DateOnly.FromDateTime(birthday[i]));
                Console.WriteLine();
            }

        }
    }
}