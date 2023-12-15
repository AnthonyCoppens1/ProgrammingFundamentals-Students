using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10OOZiekenhuis_ADI
{
    public class Ziekenhuis
    {
        public string Naam { get; set; }
        public List<Persoon> People { get; set; }

        public Ziekenhuis(string naam)
        {
            Naam = naam;
            People = new List<Persoon>();
        }

        public Ziekenhuis(string naam, List<Persoon> people)
        {
            People = people;
        }

        public void PersoonToevoegen(Persoon persoon)
        {
            People.Add(persoon);
        }

        public List<Patient> GetPatient()
        {
            List<Patient> patienten = new List<Patient>();
            foreach (Persoon persoon in People) //in originele
            {
                if (persoon is Patient)
                {
                    patienten.Add((Patient)persoon);
                }
            }
            return patienten;
        }

        public List<Persoon> Personeel()
        {
            List<Persoon> personeel = new List<Persoon>();
            foreach(Persoon persoon in People)
            {
                if(persoon is Dokter || persoon is Verpleger)
                {
                    personeel.Add(persoon);
                }
            }
            return personeel;
        }

        public override string ToString()
        {
            string s = "Ziekenhuis " + Naam + "\n";
            foreach (Persoon persoon in People)
            {
                s += " - " + persoon + "\n";
            }
            return s;
        }
    }
}
