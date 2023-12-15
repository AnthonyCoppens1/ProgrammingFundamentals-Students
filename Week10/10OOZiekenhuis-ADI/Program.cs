using System;

namespace _10OOZiekenhuis_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Persoon Anthony = new Persoon();
            Console.WriteLine(Anthony.Naam + " " + Anthony.Rol);

            Persoon Bert = new Persoon("Bert", new DateOnly(2001, 02, 25), "Doctor");
            Console.WriteLine(Bert.Naam + " " + Bert.Geboorte + " " + Bert.Rol);

            Persoon Anthony = new Persoon("Anthony", new DateOnly(1995, 7, 31), "Patient");
            Persoon Collin = new Persoon("Collin", new DateOnly(1991, 4, 16), "Patient");
            Persoon Elke = new Persoon("Elke", new DateOnly(1980, 4, 23), "Patient");
            Persoon Jenny = new Persoon("Jenny", new DateOnly(1970, 1, 1), "Doctor");
            Persoon Josh = new Persoon("Josh", new DateOnly(2000, 1, 1), "Nurse");
            Persoon John = new Persoon();

            Console.WriteLine(Anthony.Naam);
            Console.WriteLine($"{Jenny.Naam}: {Jenny.Rol}");
            Console.WriteLine(Collin.Rol);
            Console.WriteLine(Josh.Naam + " " + Josh.Rol); //JOSH

            Console.WriteLine(John.Naam + " " + John.Rol);//JOHN
            John.Naam = "Johanna";
            John.Rol = "Doctor";
            Console.WriteLine(John.Naam + " " + John.Rol);

            //Anthony.Print();
            Console.WriteLine(Anthony.ToString());
            Console.WriteLine(John.ToString());
            Console.WriteLine(Collin);
            Console.WriteLine(Elke);*/

            Dokter Louis = new Dokter("Louis", new DateOnly(2005, 12, 05), "NKO");
            Patient Anthony = new Patient("Anthony", new DateOnly(1995, 7, 31), "Teacher Syndrome");
            Verpleger Collin = new Verpleger("Collin", new DateOnly(1991, 4, 16), "Pediatrie");
            Dokter Jenny = new Dokter("Jenny", new DateOnly(1980, 05, 20), "HartenVaatziekten");
            Patient Elke = new Patient("Elke", new DateOnly(1981, 04, 23), "Teacher Syndrome");
            Patient Bert = new Patient("Bert", new DateOnly(1991, 4, 12), "Teacher Syndrome");
            Verpleger Josh = new Verpleger("Josh", new DateOnly(2000, 1, 1), "Geriatrie");
            Persoon Tom = new Persoon();

            Console.WriteLine(Louis);
            Console.WriteLine(Anthony);
            Console.WriteLine(Elke);
            Console.WriteLine(Bert);
            Console.WriteLine(Josh);
            Console.WriteLine(Collin);
            Console.WriteLine(Jenny);

            List<Persoon> people = new List<Persoon>();
            people.Add(Anthony);
            people.Add(Elke);
            people.Add(Bert);
            people.Add(Josh);
            people.Add(Collin);
            people.Add(Jenny);

            foreach(Persoon p in people)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Ziekenhuis Z = new Ziekenhuis("AZ Sint-Maarten", people);

            Dokter Bea = new Dokter("Bea", new DateOnly(1960, 1, 1), "Dermatologie");
            Z.PersoonToevoegen(Bea);
            Console.WriteLine(Z);

            Console.WriteLine();           
            
        }
    }
}