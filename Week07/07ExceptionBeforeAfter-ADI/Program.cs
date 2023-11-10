namespace _07ExceptionBeforeAfter_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oude manier zonder try en catch
            /*Console.Write("enter filename: ");
            string file = Console.ReadLine();

            Console.Write("linenummer: ");
            int linenr;

            if (!Int32.TryParse(Console.ReadLine(),out linenr))
            {
                Console.WriteLine("Dit is geen geldig linenummer, ik stop!");
                return;
            }
            if (File.Exists(file))
            {
                string[] text = File.ReadAllLines(file);
                if (linenr > text.Length || linenr < 0)
                {
                    Console.WriteLine("Linenummer is te groot! we stoppen!");
                    return; //index out of return;
                }
                Console.WriteLine(text[linenr]);
            }
            else
            {
                Console.WriteLine("Geen geldige file!");
                return;
            }*/



            //nieuwe methode --> met exception handling

            try
            {
                Console.Write("enter filename: ");
                string file = Console.ReadLine();

                Console.Write("linenummer: ");
                int linenr = Convert.ToInt32(Console.ReadLine());

                if (linenr > 5)
                {
                    throw new Exception();
                }

                string[] text = File.ReadAllLines(file);
                Console.WriteLine(text[linenr]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Linenummer was geen correct getal.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("De index is te groot of te klein / bestaat niet");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File bestaat niet");
            }
            /*catch (NullReferenceException)
            {
                Console.WriteLine("De variabele bevat het getal 0");
            }*/
            /*catch (OverflowException)
            {
                Console.WriteLine("Het getal is groter dan het gegeven datatype");
            }*/
            catch (Exception)
            {
                Console.WriteLine("Het getal mag niet groter zijn dan 5");
            }
            finally
            {
                Console.WriteLine("De code is succesvol afgerond!");
            }





        }
    }
}