namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOn = false;

            Console.WriteLine("Welelcome to Rock Paper Scissors enter enter y to play");
            string wantToPlay = Console.ReadLine();

            if (wantToPlay == "y")
            {
                gameOn = true;
            }

            while (gameOn)
            {
                Console.Clear();
                Console.WriteLine("Rock");
                Thread.Sleep(500);
                Console.WriteLine("Paper");
                Thread.Sleep(500);
                Console.WriteLine("Scissors");
                Thread.Sleep(500);

                // get the user input
                Console.WriteLine("Enter your choice");
                string userInput = Console.ReadLine();

                // get the computer choice
                string computerInput = getComputerChoice();
                Thread.Sleep(500);
                Console.WriteLine("Computer chose " + computerInput);
                Thread.Sleep(500);

                // decide the winner
                int result = decideWinner(computerInput.Trim().ToLower(), userInput.Trim().ToLower());

                // send the result to the user
                if (result == 1)
                {
                    Console.WriteLine("You won");
                }
                else if (result == -1)
                {
                    Console.WriteLine("You loose");
                }
                else if (result == 0)
                {
                    Console.WriteLine("It's a tie");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                Thread.Sleep(600);

                // ask the user if they want to play again
                Console.WriteLine("Do you want to play again? y/n");
                string playAgain = Console.ReadLine();
                if (playAgain == "y")
                {
                    gameOn = true;
                }
                else
                {
                    gameOn = false;
                }
            }

            Console.ReadLine();

        }

        static string getComputerChoice()
        {
            string[] choices = ["rock", "paper", "scissors"];
            // Random number generator
            string computerChoice;

            // using the random class
            Random random = new Random();

            // getting random number between 0 and 2
            int randomNumber = random.Next(0, 3);

            // getting the computer choice
            computerChoice = choices[randomNumber];

            return computerChoice;
        }

        static int decideWinner (string comp, string user)
        {
            if ((comp == "rock" && user == "scissors") || (comp == "scissors" && user == "paper") || (comp == "paper" && user == "rock"))
            {
                // computer wins in this case
                return -1;
            }else if ((user == "rock" && comp == "scissors") || (user == "scissors" && comp == "paper") || (user == "paper" && comp == "rock"))
            {
                // user wins in this case
                return 1;
            }
            else if (comp == user)
            {
                return 0;
            }else
            {
                return -2;
            }
        }

    }
}
