string[] availableSigns = {"rock", "paper", "scissors"};
						//   0    <    1    <     2   <  0?
Console.WriteLine(availableSigns[2]);

while(true)
{
	Console.WriteLine("Player 1, provide sign:");
	string? firstSign = Console.ReadLine();
	
	//while (firstSign != "rock" && firstSign != "paper" && firstSign != "scissors" && firstSign != "quit")
	while (!availableSigns.Contains(firstSign) && firstSign != "quit")
	{
		Console.WriteLine("wrong sign");
		firstSign = Console.ReadLine();
	}

	if (firstSign == "quit")
	{
		break;
	}

	Console.WriteLine("Player 2, provide sign:");
	string? secondSign = Console.ReadLine();

	while (!availableSigns.Contains(secondSign) && secondSign != "quit")
	{
		Console.WriteLine("wrong sign");
		secondSign = Console.ReadLine();
	}

	if (secondSign == "quit")
	{
		break;
	}

	if (firstSign == secondSign)
	{
		Console.WriteLine("draw");
	}
	else if ((firstSign == "paper" && secondSign == "rock") || // to change - use availableSigns and modulo
		(firstSign == "rock" && secondSign == "scissors") ||
		(firstSign == "scissors" && secondSign == "paper"))
	{
		Console.WriteLine("Player 1 won");
	}
	else
	{
		Console.WriteLine("Player 2 won");
	}
}