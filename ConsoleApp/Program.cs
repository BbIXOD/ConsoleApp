using System.Drawing;
using Console = Colorful.Console;

var moves = new string[] { "rock", "paper", "scissors" };

Console.WriteLine("Let's play rock, paper, scissors!", Color.Yellow);
Console.WriteAscii("GO!", Color.Purple);

while (true)
{
    Console.WriteLine("Enter your choice (rock, paper, or scissors):", Color.Yellow);
    var userChoiceString = Console.ReadLine().ToLower().Trim();

    if (!moves.Contains(userChoiceString))
    {
        Console.WriteLine("Invalid choice. Please enter rock, paper, or scissors.", Color.Red);
        continue;
    }

    var userChoice = Array.IndexOf(moves, userChoiceString);

    var random = new Random();
    var computerChoice = random.Next(0, 3);

    string computerChoiceString = moves[computerChoice];

    Console.WriteLine($"Computer chose: {computerChoiceString}", Color.Yellow);

    if (userChoice == computerChoice)
    {
        Console.WriteLine("It's a tie!", Color.Yellow);
    }
    else if (userChoice == 0 && computerChoice == 2 ||
        userChoice == 1 && computerChoice == 0 || 
        userChoice == 2 && computerChoice == 1)
    {
        Console.WriteLine("You win!", Color.Green);
    }
    else
    {
        Console.WriteLine("Computer wins!", Color.Red);
    }

    Console.WriteLine("Do you want to play again? (y/n)", Color.SkyBlue);
    string playAgain = Console.ReadLine().ToLower();

    if (playAgain != "y")
    {
        break;
    }
}