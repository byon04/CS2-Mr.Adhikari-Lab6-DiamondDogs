using System;

public class ComputerPLayer
{
	public ComputerPlayer()
	{
		// array for the values used by the computer
		static string[] RandomRPS = { "rock", "paper", "scissors" };

		// an instance for the generator
		static RandomGenerator random = new RandomGenerator();

	//Method to get the choice
	public static string ComputerChoice()
	{
		//random generator
		int pickRandom = random.Next(RandomRPS.Length);
		// generator return
		return RandomRPS[pickRandom];
	}

	//test
	static void Main(string[] args)
	{
		string computerMove = ComputerChoice();
	}
	}
}
