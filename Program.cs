using System;
using System.Linq;
string[] availableSigns = { "rock", "paper", "scissors" };

int firstPlayerScore = 0;
int secondPlayerScore = 0;
bool playingSolo = false;

Random rng = new Random();

Console.WriteLine("What's your name, player 1?");
string firstPlayerName = Console.ReadLine() ?? "Player 1";

Console.WriteLine("What's your name, player 2?");
string secondPlayerName = Console.ReadLine() ?? "Player 2";

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
	string firstSign = GetSign(firstPlayerName);
	if (firstSign == "quit")
	{
		break;
	}

	string secondSign;

	if (playingSolo)
	{
		int signIndex = rng.Next(availableSigns.Length);
		secondSign = availableSigns[signIndex];
		Console.WriteLine($"Computer chose: {secondSign}");
	}
	else
	{
		secondSign = GetSign(secondPlayerName);

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
		Console.WriteLine($"{firstPlayerName} won");
		// firstPlayerScore = secondPlayerScore + 1;
		firstPlayerScore += 1;
		// firstPlayerScore++;
	}
	else
	{
		Console.WriteLine($"{secondPlayerName} won");
		secondPlayerScore += 1;
	}

	Console.WriteLine($"[{firstPlayerName}] {firstPlayerScore} : {secondPlayerScore} [{secondPlayerName}]");

	// if (firstPlayerScore >= 3 || secondPlayerScore >= 3)
	// {
	// 	break;
	// }
}


Console.WriteLine("The game is over now");
Console.WriteLine("Press any key to continue");
Console.ReadKey();

string GetSign(string playerName)
{
	Console.WriteLine($"{playerName}, provide sign:");
	string sign = Console.ReadLine()?.ToLower().Trim() ?? string.Empty;

	while (!availableSigns.Contains(sign) && sign != "quit")
	{
		Console.WriteLine("wrong sign");
		sign = Console.ReadLine()?.ToLower().Trim() ?? string.Empty;
	}
	return sign;
}