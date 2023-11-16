using System;

namespace Punctuation_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();

            for (int i = 0; i < answer.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(answer[i]);
                }
                else if (answer[i] == answer[i - 1] && ".,?!:[](){};'\"".Contains(answer[i]))
                {

                }
                else
                {
                    Console.Write(answer[i]);
                }
            }
        }
    }
}