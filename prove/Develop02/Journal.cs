using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries;
    public PromptGenerator promptGenerator;

    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }
    public void WriteNewEntry()
    {
        Random rand = new Random();
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your Response: ");
        string response = Console.ReadLine();
        Entry newEntry = new Entry(prompt, response, DateTime.Now);
        entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:\n");
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
            Console.WriteLine();
        }
    }

    public void SaveToFile()
    {
        Console.Write("\nEnter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Prompt}|{entry.Response}|{entry.Date}");
            }
        }

        Console.WriteLine($"Journal saved to {filename}\n");
    }

    public void LoadFromFile()
    {
        Console.Write("\nEnter filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string prompt = parts[0];
                        string response = parts[1];
                        DateTime date = DateTime.Parse(parts[2]);
                        entries.Add(new Entry(prompt, response, date));
                    }
                }
            }

            Console.WriteLine($"Journal loaded from {filename}\n");
        }
        else
        {
            Console.WriteLine($"File {filename} does not exist.\n");
        }
    }
}
