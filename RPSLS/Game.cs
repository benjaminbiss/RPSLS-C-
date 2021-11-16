using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public bool UseAI;
        public int rounds;
        
        public Game(bool UseAI, int rounds)
        {
            this.UseAI = UseAI;
            this.rounds = rounds;
        }
        public void RunGame()
        {

        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissor Lizard Spock!");
        }
        public void DisplayRules()
        {
            Console.WriteLine("The game RPSLS is just like Rock Paper Scissors, however there are now five options to choose from!\nRules:\nRock beats Scissor and Lizard\nPaper beats Rock and Spock\nScissor beats Paper and Lizard\nLizard beats Spock and Paper\nSpock beats Scissors and Rock")
        }
        public void GetMode()
        {
            Console.WriteLine("Please select you game mode:\n1: Play versus an AI\n2: Play against a friend\n");
            string GameMode = Console.ReadLine();
            if (GameMode == "1")
            {
                UseAI = true;
            }
            else
            {
                UseAI = false;
            }
        }
        public void DisplayWinner()
        {
            Console.WriteLine();
        }
    }
}
