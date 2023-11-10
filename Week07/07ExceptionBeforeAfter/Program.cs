namespace _07ExceptionBeforeAfter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //old way of handling exceptions
            /*Console.Write("Enter filename: ");
            string file = Console.ReadLine();

            Console.Write("Enter linenumber: ");
            int linenr;
            if (!Int32.TryParse(Console.ReadLine(), out linenr))
            {
                Console.WriteLine("Not a valid linenumber! We Stop!");
                return; //returns input to the user --> stops code
            }
            if (File.Exists(file))
            {
                string[] text = File.ReadAllLines(file);
                if (linenr > text.Length)
                {
                    Console.WriteLine("Linenumber is too big! We stop!");
                    return;
                }
                else if (linenr < 0)
                {
                    Console.WriteLine("Your number is negative. No such index.");
                    return;
                }

                Console.WriteLine(text[linenr]);
            }
            else
            {
                Console.WriteLine("File does not exist, or is invalid.");
                return;
            }*/



            //NEW WAY --> with exception handling

            try
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                Console.Write("Enter linenumber: ");
                int linenr = Convert.ToInt32(Console.ReadLine());

                string[] text = File.ReadAllLines(file);
                Console.WriteLine(text[linenr]);

                if (linenr < 0)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File was not found");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Linenumber was not valid for this file.");
            }
            catch (FormatException)
            {
                Console.WriteLine("LineNumber was not a correct number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Linenumber was too big!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("You've succesfully finished this programme.");
            }



        }
    }
}