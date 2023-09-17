namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Hello {0}!", name);

            /*{0} is a placeholder, you can use as many placeholders as you'd like.
             * E.g. Console.WriteLine("Hello {0}{1}{2}!", x,y,z);
             * with x y z being variables you've declared earlier*/


            string x = "Jan";
            string y = "Tom";
            string z = "Flip";
            Console.WriteLine("Hello {0} {1} {2}!", x, y, z);

            //options for comments
            /* if you want to write on multiple lines

            this is possible*/


        }
    }
}