namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();

            myGame.PlayGame();


            Console.WriteLine("Program End");
            Console.ReadLine();

        }
    }
}
