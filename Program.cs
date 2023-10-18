// See https://aka.ms/new-console-template for more information
Console.WriteLine("Player 1, provide sign:");
string firstSign = Console.ReadLine();
Console.WriteLine(firstSign);
Console.WriteLine("Player 2, provide sign:");
string secondSign = Console.ReadLine();
Console.WriteLine(secondSign);

if (firstSign == secondSign)
{
    Console.WriteLine("draw");
}