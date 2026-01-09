using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
    {

    // Now i wil generate a magic number from 1 to 100
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 101);

    int guess = -1;
    int guessCount = 0;

    // Keep looping until the user guess the magic number.
    while (guess != magicNumber)
    {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());
        guessCount++;

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
        else
                {
                    Console.WriteLine("You guessed it!");
                }
    }
    // Display number of guesses 
    Console.WriteLine($"It took you {guessCount} guesses.");

    // Ask user if he wants to play again
    Console.WriteLine("Do you want to play again? (yes/no) ");
    playAgain = Console.ReadLine();
        }
    }
}