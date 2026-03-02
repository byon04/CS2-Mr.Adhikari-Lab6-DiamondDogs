using System;
using System.Collections.Generic;
using System.Text;

namespace CS2_Mr.Adhikari_Lab6_DiamondDogs
{
    internal class Player
    {
        public string playerName;

        public Player()
        {
            Console.Write("Enter your name: ");

            playerName = Console.ReadLine();
        }

        public string GetChoice()
        {
            Console.WriteLine("Make Your Move: Rock, Paper, or Scissors?");

            string choice = Console.ReadLine();

            return choice.ToLower();
        }
    }
}
