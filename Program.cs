﻿using System;
					
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Player 1, provide sign:");
string firstSign = Console.ReadLine();

//if (!(firstSign == "rock" || firstSign == "paper" || firstSign == "scissors"))
while (firstSign != "rock" && firstSign != "paper" && firstSign != "scissors")
{
	Console.WriteLine("wrong sign");
	firstSign = Console.ReadLine();
}

Console.WriteLine("Player 2, provide sign:");
string secondSign = Console.ReadLine();

while (secondSign != "rock" && secondSign != "paper" && firstSign != "scissors")
{
    Console.WriteLine("wrong sign");
    secondSign = Console.ReadLine();
}

if (firstSign == secondSign)
{
    Console.WriteLine("draw");
}
else if ((firstSign == "paper" && secondSign == "rock") ||
    (firstSign == "rock" && secondSign == "scissors") ||
    (firstSign == "scissors" && secondSign == "paper"))
{
    Console.WriteLine("Player 1 won");
}
else
{
    Console.WriteLine("Player 2 won");
}