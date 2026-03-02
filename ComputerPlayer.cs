using System;

public class ComputerPlayer
{
	// array for the values used by the computer
	string[] RandomRPS = { "rock", "paper", "scissors" };

	// an instance for the generator
	Random random = new Random();

	//Method to get the choice
	public string GenerateChoice()
	{
		//random generator
		int pickRandom = random.Next(RandomRPS.Length);
		// generator return
		return RandomRPS[pickRandom];
	}
}
