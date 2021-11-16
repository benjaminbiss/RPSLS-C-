using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player_Form
    {
        public int score;
        public string name;
        public Player_Form()
        {
            List<string> ScissorsLizard = new List<string>();
            ScissorsLizard.Add("scissors");
            ScissorsLizard.Add("lizard");
            List<string> PaperSpock = new List<string>();
            ScissorsLizard.Add("paper");
            ScissorsLizard.Add("spock");
            List<string> RockSpock = new List<string>();
            ScissorsLizard.Add("rock");
            ScissorsLizard.Add("spock");
            List<string> PaperLizard = new List<string>();
            ScissorsLizard.Add("paper");
            ScissorsLizard.Add("lizard");
            List<string> ScissorsRock = new List<string>();
            ScissorsLizard.Add("scissors");
            ScissorsLizard.Add("rock");
            Gestures rock = new Gestures("rock", ScissorsLizard, PaperSpock);
            Gestures paper = new Gestures("paper", RockSpock, ScissorsLizard);
            Gestures scissors = new Gestures("scissors", PaperLizard, RockSpock);
            Gestures lizard = new Gestures("lizard", PaperSpock, ScissorsRock);
            Gestures spock = new Gestures("spock", ScissorsRock, PaperLizard);
            
        }
        public void IncreaseScore()
        {
            score += 1;
        }
    }
}
