namespace _11OO_RPS_DSPS2
{
    public enum Hand
    {
        rock = 0, paper = 1, scissors = 2
    }

    public class RPS
    {
        private Random r;
        public Hand Me { get; set; }
        public Hand PC { get; set; }
        public int ScoreMe { get; set; }
        public int ScorePC { get; set; }

        public RPS()
        {
            r = new Random();
        }

        public string Turn()
        {
            PC = (Hand)r.Next(0, 3);
            string result = "";

            if ((Me == Hand.rock && PC == Hand.scissors) ||
                (Me == Hand.scissors && PC == Hand.paper) ||
                (Me == Hand.paper && PC == Hand.rock))
            {
                ScoreMe++;
                result = $"Computer: {PC} --> I win!";
            }
            else if ((PC == Hand.rock && Me == Hand.scissors) ||
                    (PC == Hand.scissors && Me == Hand.paper) ||
                    (PC == Hand.paper && Me == Hand.rock))
            {
                ScorePC++;
                result = $"Computer: {PC} --> PC wins!";
            }
            else
            {
                result = $"Computer: {PC} --> DRAW!";
            }
            return result;
        }

        public override string ToString()
        {
            return $"{ScoreMe} - {ScorePC}";
        }

    }
}
