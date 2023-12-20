string[] availableSigns = {"rock", "paper", "scissors"};

while(true)
{
	Console.WriteLine("Player 1, provide sign:");
	string? firstSign = Console.ReadLine().ToLower().Trim();
	
	while (!availableSigns.Contains(firstSign) && firstSign != "quit")
	{
		Console.WriteLine("wrong sign");
		firstSign = Console.ReadLine().ToLower().Trim();
	}

	if (firstSign == "quit")
	{
		break;
	}

	Console.WriteLine("Player 2, provide sign:");
	string? secondSign = Console.ReadLine().ToLower().Trim();

	while (!availableSigns.Contains(secondSign) && secondSign != "quit")
	{
		Console.WriteLine("wrong sign");
		secondSign = Console.ReadLine().ToLower().Trim();
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
	}
	else
	{
		Console.WriteLine("Player 2 won");
	}
}