string[] availableSigns = {"rock", "paper", "scissors"};

int firstPlayerScore = 0;
int secondPlayerScore = 0;

while(true)
{
	Console.WriteLine("Player 1, provide sign:");
	string? firstSign = Console.ReadLine()?.ToLower().Trim();
	
	while (!availableSigns.Contains(firstSign) && firstSign != "quit")
	{
		Console.WriteLine("wrong sign");
		firstSign = Console.ReadLine()?.ToLower().Trim();
	}

	if (firstSign == "quit")
	{
		break;
	}

	Console.WriteLine("Player 2, provide sign:");
	string? secondSign = Console.ReadLine()?.ToLower().Trim();

	while (!availableSigns.Contains(secondSign) && secondSign != "quit")
	{
		Console.WriteLine("wrong sign");
		secondSign = Console.ReadLine()?.ToLower().Trim();
	}

	if (secondSign == "quit")
	{
		break;
	}

	int secondSignIndex = Array.IndexOf(availableSigns, secondSign);
	int secondSignWinningIndex = (secondSignIndex + 1) % availableSigns.Length;
	string secondSignWinningSign = availableSigns[secondSignWinningIndex];

	if (firstSign == secondSign)
	{
		Console.WriteLine("draw");
	}
	else if(firstSign == secondSignWinningSign)
	{
		Console.WriteLine("Player 1 won");
		// firstPlayerScore = secondPlayerScore + 1;
		firstPlayerScore += 1;
		// firstPlayerScore++;
	}
	else
	{
		Console.WriteLine("Player 2 won");
		secondPlayerScore += 1;
	}

	Console.WriteLine($"[Player 1] {firstPlayerScore} : {secondPlayerScore} [Player 2]");
}

Console.WriteLine("The game is over now");
Console.WriteLine("Press any key to continue");
Console.ReadKey();