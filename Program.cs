﻿int userPoints = 0;
int computerPoints = 0;

Console.WriteLine("Do you choose rock,paper or scissors");
string userChoice = Console.ReadLine();

Random r = new Random();
int computerChoice = r.Next(1, 4);

if (computerChoice == 1)
{
    if (userChoice == "rock")
    {
        Console.WriteLine("The computer chose rock");
        Console.WriteLine("It is a tie ");
    }
    else if (userChoice == "paper")
    {
        Console.WriteLine("The computer chose paper");
        Console.WriteLine("It is a tie ");

    }
    else if (userChoice == "scissors")
    {
        Console.WriteLine("The computer chose scissors");
        Console.WriteLine("It is a tie ");
    }
    else
    {
        Console.WriteLine("You must choose rock,paper or scissors!");

    }

}

else if (computerChoice == 2)
{
    if (userChoice == "rock")
    {
        Console.WriteLine("The computer chose paper");
        Console.WriteLine("Sorry you lose, paper beats rock dummy");
        computerPoints++;

    }
    else if (userChoice == "paper")
    {
        Console.WriteLine("The computer chose scissors");
        Console.WriteLine("Sorry you lose, scissors beats paper idiot");
        computerPoints++;

    }
    else if (userChoice == "scissors")
    {
        Console.WriteLine("The computer chose rock");
        Console.WriteLine("Sorry you lose, rock beats scissors silly");
        computerPoints++;
    }
    else
    {
        Console.WriteLine("You must choose rock,paper or scissors!");
    }
}
else if (computerChoice == 3)
{
    if (userChoice == "rock")
    {
        Console.WriteLine("The computer chose scissors");
        Console.WriteLine("You win, rock beats scissors cool guy");
        userPoints++;

    }
    else if (userChoice == "paper")
    {
        Console.WriteLine("The computer chose rock");
        Console.WriteLine("You win, paper beats rock, you're the best");
        userPoints++;

    }
    else if (userChoice == "scissors")
    {
        Console.WriteLine("The computer chose paper");
        Console.WriteLine("You win, scissors beats paper you lovely man");
        userPoints++;

    }
    else
    {
        Console.WriteLine("You must choose rock,paper or scissors!");

    }

}

Console.WriteLine(computerPoints);
Console.WriteLine(userPoints);

Console.ReadLine();









