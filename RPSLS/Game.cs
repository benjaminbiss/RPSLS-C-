﻿using System;
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
        Human Player1 = new Human("player1", 0);
        Human Player2 = new Human("player2", 0);
        AI Bot = new AI("AI", 0);
        
        public Game(bool UseAI, int rounds)
        {
            this.UseAI = UseAI;
            this.rounds = rounds;
        }
        public void RunGame()
        {
            DisplayWelcome();
            DisplayRules();
            GetMode();
            RoundCount();
            StartGame();
            DisplayWinner();
        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissor Lizard Spock!");
        }
        public void DisplayRules()
        {
            Console.WriteLine("The game RPSLS is just like Rock Paper Scissors, however there are now five options to choose from!\nRules:\nRock beats Scissor and Lizard\nPaper beats Rock and Spock\nScissor beats Paper and Lizard\nLizard beats Spock and Paper\nSpock beats Scissors and Rock");
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
        public void RoundCount()
        {
            Console.WriteLine("How many rounds would you like to play?\n");
            rounds = int.Parse(Console.ReadLine());
        }
        public void StartGame()
        {
            Console.WriteLine("Player1, enter your name: ");
            Player1.name = Console.ReadLine();
            if (UseAI == false)
            {
                Console.WriteLine("Player1, enter your name: ");
                Player2.name = Console.ReadLine();
            }
            while (Player1.score/rounds>.5 && Player2.score / rounds > .5 && Bot.score / rounds > .5)
            {

            }
        }
        public void DisplayWinner()
        {
            if (Player1.score / rounds > .5)
            {
                Console.WriteLine("Player1 is the winner!");
            }
            else if (Player2.score / rounds > .5)
            {
                Console.WriteLine("Player2 is the winner!");
            }
            else
            {
                Console.WriteLine("The AI is the winner!");
            }
        }
    }
}
