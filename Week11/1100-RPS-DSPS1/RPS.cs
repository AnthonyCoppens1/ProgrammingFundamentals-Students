using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1100_RPS_DSPS1
{
    public enum Hand { rock = 0, paper = 1, scissors = 2}

    public class RPS
    {
        private Random r;
        public int ScoreMe { get; set; }
        public int ScorePC { get; set; }
        public Hand Me { get; set; }
        public Hand PC { get; set; }


        public RPS()
        {
            r = new Random();
        }

        public string Turn()
        {
            PC = (Hand)r.Next(0, 3);
            string result = "";
            if ((Me == Hand.rock && PC == Hand.scissors) || (Me == Hand.paper && PC == Hand.rock)
                || (Me == Hand.scissors && PC == Hand.paper))
            {
                ScoreMe++;
                result = $"Computer: {PC} --> I win!";
            }
            else if ((PC == Hand.rock && Me == Hand.scissors) || (PC == Hand.paper && Me == Hand.rock)
                || (PC == Hand.scissors && Me == Hand.paper))
            {
                ScorePC++;
                result = $"Computer: {PC} --> PC WINS!";
            }
            else
            {
                result = $"Computer: {PC} --> DRAW!";
            }
            return result;
        }

        public override string ToString()
        {
            return $"{ScoreMe - ScorePC}";
        }

    }
}
