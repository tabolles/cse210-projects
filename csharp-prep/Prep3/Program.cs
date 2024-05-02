using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess; int guesses = 0; string playAgain = "y";

        do
        {
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower.");
                guesses++;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher.");
                guesses++;
            }
            else
            {
                guesses++;
                Console.WriteLine($"Congratulations! You guessed the magic number in {guesses} guesses!");
                Console.WriteLine("Would you like to play again? (y/n)");
                playAgain = Console.ReadLine();
                if (playAgain == "y")
                {
                    magicNumber = randomGenerator.Next(1, 100);
                    guesses = 0;
                }
            }
        } while (playAgain == "y");
    }
}