using System;
using System.Collections.Generic;
using System.Text;

namespace CS2_Mr.Adhikari_Lab6_DiamondDogs
{
    /*
     * CS2 - Lab 6
     * Author: Brayden Yon
     * Date: 02/23/2026
     * Description: This class contains logic for determining a winner for a rock-paper-scissors game.
     * It takes the player's choice and computer's choice and returns a string indicating the result of the game.
     */

    public class Logic
    {
        /// <summary>
        /// Determines the winner of a rock-paper-scissors game, but also has checks in place that validates input and handles ties.
        /// </summary>
        /// <param name="player">Player's selection.</param>
        /// <param name="computer">Computer's selection.</param>
        /// <returns>A string that defines the result of the game.</returns>
        public string DetermineWinner(string player, string computer)
        {
            player= player?.ToLower();
            computer = computer?.ToLower();

            if (string.IsNullOrEmpty(player) || (player != "rock" && player != "paper" && player != "scissors"))
            {
                return "Invalid input. Please choose either rock, paper, or scissors.";
            }

            if (player == computer)
            {
                return "It is a tie!";
            }
            else if ((player == "rock" && computer == "scissors") ||
                     (player == "paper" && computer == "rock") ||
                     (player == "scissors" && computer == "paper"))
            {
                return "You win!";
            }
            else
            {
                return "Computer wins!";
            }
        }
    }
}