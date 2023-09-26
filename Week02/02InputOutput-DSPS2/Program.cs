using System;

namespace _02InputOutput_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input and output
            //check if a number is between 10 and 100

            int number = 56;
            Console.WriteLine(number < 10 && number < 100);//false
            int result = number / 10;
            Console.WriteLine(result >= 1 && result <= 10); //true

            int resultModulo100 = 100 % result;
            Console.WriteLine(resultModulo100); //value of 0
            Console.WriteLine(resultModulo100 < 100 && resultModulo100 > 10); //false


            //conversion
            Console.WriteLine("Enter a number: ");
            string answer = Console.ReadLine();
            number = Convert.ToInt32(answer);
            Console.WriteLine(number);

            //input conversion
            Console.Write("Enter a byte: ");
            answer = Console.ReadLine();
            byte b = Convert.ToByte(answer);

            //Convert.ToByte --> other options: int16 --> short, int32 --> int, int65 --> long

            Console.Write("Enter a short: ");
            answer = Console.ReadLine();
            short s = Convert.ToInt16(answer);

            Console.WriteLine(s); //implicit conversion
            Console.WriteLine(s.ToString()); //explicit conversion
            Console.WriteLine(b.ToString()); //explicit
            Console.WriteLine(b);


            Console.Write("Enter a character: ");
            answer = Console.ReadLine();
            char c = Convert.ToChar(answer);

            Console.WriteLine(c);
            Console.WriteLine((int)c);//ascii value
            Console.WriteLine('z');


            string name = "Jean";
            //things that don't work
            //int nameToNumber = (int)name; //doesn't work
            //int stringNumber = (int)"89"; //never works

            //the following does work
            number = (int)78.8989;
            double doubleNumber = (double)78;

            Console.WriteLine(number);
            Console.WriteLine(doubleNumber);
            






        }
    }
}