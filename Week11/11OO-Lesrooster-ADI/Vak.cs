using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OO_Lesrooster_ADI
{
    public class Vak
    {
        public string Naam { get; set; }
        public Leerkracht Docent { get; set; }
        public string Lokaal { get; set; }
        public int Lengte { get; set; }
        public WeekDays Dagvandeweek {get; set;}
        public Time StartUur {get; set;}

        public Vak(string naam, Leerkracht docent, string lokaal, int lengte,
            WeekDays dagvandeweek, Time startuur)
        {
            Naam = naam; Docent = docent; Lokaal = lokaal; Lengte = lengte;
            Dagvandeweek = dagvandeweek; StartUur = startuur;
        }

        public override string ToString()
        {
            string s = "";
            s += "Vak: " + Naam;
            s += "\n *" + Docent.Naam;
            s += "\n *" + Lokaal;
            s += "\n *" + Dagvandeweek;
            Time EindUur = new Time(StartUur, Lengte);
            s += "\n *" + StartUur.ToString() + "-->" + EindUur.ToString();
            return s;
        }
    }
   

    public enum WeekDays
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }

}
