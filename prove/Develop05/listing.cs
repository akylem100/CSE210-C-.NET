using System;
using System.Collections.Generic;
using System.IO;

public class Listing : Activity
{
    private List<string> _prompts;
    private List<string> _userResponses;
    private int _itemCount;

    public Listing(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _userResponses = new List<string>();
        _itemCount = 0;
    }

    public void runListingActivity()
    {
        displayStartMessage();

        string prompt = getRandomPrompt();
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("You have a few seconds to think...");

        displaySpinner();
        displaySpinner();

        Console.WriteLine("Start listing as many items as you can:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                _userResponses.Add(userInput);
                _itemCount++;
            }
        }

        Console.WriteLine($"You listed {_itemCount} items.");

        Console.WriteLine("Would you like to save your responses? (yes/no)");
        string saveResponse = Console.ReadLine();
        if (saveResponse?.ToLower() == "yes")
        {
            SaveResponsesToFile(prompt);
        }

        displayEndMessage();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    private string getRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public void SaveResponsesToFile(string prompt)
    {
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string filePath = Path.Combine(documentsPath, "MindfulnessResponses.txt");

        string responses = $"Prompt: {prompt}{Environment.NewLine}Responses:{Environment.NewLine}{string.Join(Environment.NewLine, _userResponses)}{Environment.NewLine}";

        try
        {
            File.AppendAllText(filePath, responses + Environment.NewLine);
            Console.WriteLine();
            Console.WriteLine($"Responses successfully saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
        }
    }
}
