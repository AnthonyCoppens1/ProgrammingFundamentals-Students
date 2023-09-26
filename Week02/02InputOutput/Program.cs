using System;
using System.Runtime.CompilerServices;

namespace _02InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input and output conversion
            //input

            Console.Write("Enter a byte: ");
            string answer = Console.ReadLine();
            byte b = Convert.ToByte(answer);
            Console.WriteLine(b);

            Console.Write("Enter a short: ");
            answer = Console.ReadLine();
            short s = Convert.ToInt16(answer); //int16 = short - int32 = int - int64 = long

            Console.WriteLine(s); //implicit conversion --> s turns into string
            Console.WriteLine(s.ToString()); //explicit conversion

            Console.Write("Enter a character: ");
            answer = Console.ReadLine();
            char c = Convert.ToChar(answer);
            Console.WriteLine(c);
            Console.WriteLine((int)c); //change datatype to int

            string name = "Albert John Phillips";
            //int nameToNumber = (int)name; //never works
            //int stringNumber = (int)"89"; //never works

            int number = (int)78.89890;
            Console.WriteLine(number);
            double doubleNumber = (double)78;
            Console.WriteLine(doubleNumber);


        }
    }
}