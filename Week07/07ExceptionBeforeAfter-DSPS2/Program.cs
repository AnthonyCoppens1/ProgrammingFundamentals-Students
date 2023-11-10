namespace _07ExceptionBeforeAfter_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OLD WAY OF EXCEPTION HANDLING
            /*Console.Write("Enter a filename: ");
            string file = Console.ReadLine();

            Console.Write("Enter a linenumber: ");
            int linenr;

            if (!Int32.TryParse(Console.ReadLine(), out linenr))
            {
                Console.WriteLine("This is not a valid linenumber! We stop!");
                return;
            }

            if (File.Exists(file))
            {
                string[] text = File.ReadAllLines(file);
                if (linenr > text.Length)
                {
                    Console.WriteLine("Linenumber is too big!");
                    return;
                }
                Console.WriteLine(text[linenr]);
            }
            else
            {
                Console.WriteLine("Not a valid file.");
                return;
            }*/





            //new way --> using exception handling
            try
            {
                Console.Write("Enter a filename: ");
                string file = Console.ReadLine();

                Console.Write("Enter a linenumber: ");
                int linenr = Convert.ToInt32(Console.ReadLine());

                string[] text = File.ReadAllLines(file);
                Console.WriteLine(text[linenr]);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File was not found!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Linenumber was not valid for this file. exceeds the max spots!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Linenumber was not a correct number. Should be INT");
            }
            /*catch (OverflowException)
            {
                Console.WriteLine("Number was too big!");
            }*/
            catch (Exception ex) //will return for the overflow.
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("The code has succesfully ran!");
            }


            int x = Convert.ToByte(Console.ReadLine());
            if (x > 2)
            {
                throw new OverflowException();
            }


        }
    }
}