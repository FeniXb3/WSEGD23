string[] availableSigns = { "rock", "paper", "scissors" };

int firstPlayerScore = 0;
int secondPlayerScore = 0;
bool playingSolo = true;

Random rng = new Random();

Console.WriteLine("How many wins to win?");
// winsToWin = int.Parse(Console.ReadLine());

bool parsingResult = int.TryParse(Console.ReadLine(), out int winsToWin);
if (!parsingResult)
{
	winsToWin = 3;
}

Console.WriteLine(winsToWin);

// while (!(firstPlayerScore >= 3 || secondPlayerScore >= 3))
while (firstPlayerScore < winsToWin && secondPlayerScore < winsToWin)
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

	string? secondSign;

	if (playingSolo)
	{
		int signIndex = rng.Next(availableSigns.Length);
		secondSign = availableSigns[signIndex];
		Console.WriteLine($"Computer chose: {secondSign}");
	}
	else
	{
		Console.WriteLine("Player 2, provide sign:");
		secondSign = Console.ReadLine()?.ToLower().Trim();

		while (!availableSigns.Contains(secondSign) && secondSign != "quit")
		{
			Console.WriteLine("wrong sign");
			secondSign = Console.ReadLine()?.ToLower().Trim();
		}

		if (secondSign == "quit")
		{
			break;
		}
	}

	int secondSignIndex = Array.IndexOf(availableSigns, secondSign);
	int secondSignWinningIndex = (secondSignIndex + 1) % availableSigns.Length;
	string secondSignWinningSign = availableSigns[secondSignWinningIndex];

	if (firstSign == secondSign)
	{
		Console.WriteLine("draw");
	}
	else if (firstSign == secondSignWinningSign)
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

	// if (firstPlayerScore >= 3 || secondPlayerScore >= 3)
	// {
	// 	break;
	// }
}


Console.WriteLine("The game is over now");
Console.WriteLine("Press any key to continue");
Console.ReadKey();