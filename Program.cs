using System;

namespace CS2_Mr.Adhikari_Lab6_DiamondDogs
{
    /*
     * CS2 - Lab 6
     * 
     * 
     * 
     */
    class Program
    {
        /// <summary>
        /// This is the main program where execution beings.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("This is a game of Rock, Paper, Scissors.");
            Console.WriteLine("\n---------------------------------------\n");

            Player player = new Player();
            ComputerPlayer computer = new ComputerPlayer();
            Logic logic = new Logic();

            string playerChoice = player.GetChoice();
            string computerChoice = computer.GenerateChoice();

            Console.WriteLine($"The Computer chose: {computerChoice}");

            string result = logic.DetermineWinner(playerChoice, computerChoice);

            Console.WriteLine(result);
        }
    }
}