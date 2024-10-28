using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Game
    {
        bool gameOn = false;
        public readonly string[] OPTIONS = { "rock", "paper", "scissors" };
        private Player player1;
        private Computer player2 =  new Computer("Computer");

        public Game()
        {

        }

        public void PlayGame()
        {
            Console.WriteLine("Welelcome to Rock Paper Scissors enter enter y to play");
            string wantToPlay = Console.ReadLine();

            if (wantToPlay == "y")
            {
                gameOn = true;
                string player1Name;
                do
                {
                    Console.WriteLine("What is your name");
                    player1Name = Console.ReadLine();
                }
                while (player1Name == null);

                player1 = new Player(player1Name);
            }

            while (gameOn)
            {
                Console.Clear();
                foreach (var option in OPTIONS)
                {
                    Console.WriteLine(option);
                    Thread.Sleep(500);
                }
                // get the user input
                string userInput = player1.MakeChoice(OPTIONS);

                // get the computer choice
                string computerInput = player2.MakeChoice(OPTIONS);
                Thread.Sleep(500);
                Console.WriteLine("Computer chose: " + computerInput);
                Thread.Sleep(500);

                // decide the winner
                int result = decideWinner(userInput, computerInput);

                // send the result to the user
                if (result == 1)
                {
                    Console.WriteLine("You won");
                    player1.Score++;
                }
                else if (result == -1)
                {
                    Console.WriteLine("You loose");
                    player2.Score++;
                }
                else if (result == 0)
                {
                    Console.WriteLine("It's a tie");
                }

                Thread.Sleep(600);

                Console.WriteLine($"{player1.Name}: {player1.Score}\n{player2.Name}: {player2.Score}");

                Console.WriteLine("Do you want to play again? y/n");
                string playAgain = Console.ReadLine();
                
                if (playAgain == "n")
                {
                    gameOn = false;
                }
            }
        }

        private int decideWinner(string user, string comp)
        {
            if ((comp == "rock" && user == "scissors") || (comp == "scissors" && user == "paper") || (comp == "paper" && user == "rock"))
            {
                // computer wins in this case
                return -1;
            }
            else if ((user == "rock" && comp == "scissors") || (user == "scissors" && comp == "paper") || (user == "paper" && comp == "rock"))
            {
                // user wins in this case
                return 1;
            }
            else if (comp == user)
            {
                return 0;
            }
            else
            {
                return -2;
            }
        }

    }
}
