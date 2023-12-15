namespace _11OO_BSS_ADI
{
    public class BSS
    {
        public Random r;
        public Hand Mezelf { get; set; }
        public Hand PC { get; set; }
        public int EigenScore { get; set; }
        public int PCScore { get; set; }

        public BSS()
        {
            r = new Random();
        }

        public string Beurt()
        {
            PC = (Hand)r.Next(0, 3);
            string uitslag = "";
            if ((Mezelf == Hand.blad && PC == Hand.steen) ||
                (Mezelf == Hand.steen && PC == Hand.schaar) ||
               (Mezelf == Hand.schaar && PC == Hand.blad))
            {
                EigenScore++;
                uitslag = $"PC: {PC} --> Ik win!";
            }
            else if ((PC == Hand.blad && Mezelf == Hand.steen) ||
                    (PC == Hand.steen && Mezelf == Hand.schaar) ||
                    (PC == Hand.schaar && Mezelf == Hand.blad))
            {
                PCScore++;
                uitslag = $"PC: {PC} --> PC wint!";
            }
            else
            {
                uitslag = $"PC: {PC} --> NIEMAND WINT! DRAW";
            }
            return uitslag;
        }

        public override string ToString()
        {
            return $"Eigen score - PC score: {EigenScore} - {PCScore}";
        }


    }
    public enum Hand { blad = 0, steen = 1, schaar = 2 }
}
