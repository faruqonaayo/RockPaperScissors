using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Computer
    {

        // public properties
        public string Name { get; set; }
        public string Choice { get; set; }
        public int Score { get; set; }

        // constructor
        public Computer(string name)
        {
            Name = name;
        }


        // public methods
        public string MakeChoice(string[] options)
        {
            // generate a random number
            Random random = new Random();
            
            int randomNumber = random.Next(0, options.Length);
            string computerChoice = options[randomNumber];

            return computerChoice;
        }

    }
}
