using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Please choose an activity (Type 1,2,3, or 4):");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    runBreathingActivity();
                    break;
                case "2":
                    runReflectionActivity();
                    break;
                case "3":
                    runListingActivity();
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Thanks for using the Mindfulness App!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void runBreathingActivity()
    {
        Console.WriteLine("How many seconds would you like to breathe?");
        int duration = int.Parse(Console.ReadLine());
        Breathing breathing = new Breathing("Breathing", "This activity will help you relax.", duration);
        breathing.runBreathingActivity();
        breathing.displayEndMessage();
    }

    static void runReflectionActivity()
    {
        Console.WriteLine("How many seconds would you like to reflect?");
        int duration = int.Parse(Console.ReadLine());
        Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on past strengths.", duration);
        reflection.runReflectionActivity();
    }

    static void runListingActivity()
    {
    Console.WriteLine("How many seconds would you like to list items?");
    int duration = int.Parse(Console.ReadLine());

    Listing listing = new Listing("Listing", "This activity helps you list positive aspects.", duration);

    listing.runListingActivity();
    }

}
