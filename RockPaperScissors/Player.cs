using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Player
    {
        // public properties
        public string Name { get; set; }
        public string Choice { get; set; }
        public int Score { get; set; }

        // constructor
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }


        // public methods
        public string MakeChoice(string[] options)
        {
            string userChoice;
            do
            {
                Console.WriteLine("Enter the correct choice");
                userChoice = Console.ReadLine().ToLower();
            }
            while (!options.Contains(userChoice));

            return userChoice;
        }

    }
}
