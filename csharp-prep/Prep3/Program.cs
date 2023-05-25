using System;

class GuessMyNumber
{
    static void Main(string[] args)
    {
        // Generate a random number between 1 and 100.
        int magicNumber = new Random().Next(1, 101);

        // Ask the user for their guess.
        Console.WriteLine("What is the magic number? ");
        int guess = int.Parse(Console.ReadLine());

        // Keep track of the number of guesses.
        int numberOfGuesses = 1;

        // Loop until the user guesses the magic number.
        while (guess != magicNumber)
        {
            // Check if the guess is too high or too low.
            if (guess > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Lower");
            }

            // Get the user's next guess.
            guess = int.Parse(Console.ReadLine());

            // Increment the number of guesses.
            numberOfGuesses++;
        }

        // Tell the user if they guessed it.
        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it! It took you {0} guesses.", numberOfGuesses);
        }

        // Ask the user if they want to play again.
        Console.WriteLine("Would you like to play again? (y/n)");
        string playAgain = Console.ReadLine();

        // If the user says yes, play the game again.
        // If the user says yes, play the game again.
        if (playAgain == "y")
        {
            Main(new string [0]);
        }
    }
}