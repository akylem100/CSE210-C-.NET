using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        Console.Write("Guess the magic number between 1-100! What is your guess? ");
        string user_guess = Console.ReadLine();
        int guess = int.Parse(user_guess);

        while (guess != magic_number)
        {
            if (guess > magic_number)
            {
                Console.WriteLine("It's lower than that!");
            }
            else
            {
                Console.WriteLine("It's higher than that!");
            }
            Console.Write("Try again! What is your next guess? ");
            user_guess = Console.ReadLine();
            guess = int.Parse(user_guess);
        }

        if (guess == magic_number)
        {
            Console.WriteLine("You guessed it! Great job!");
        }
    }
}