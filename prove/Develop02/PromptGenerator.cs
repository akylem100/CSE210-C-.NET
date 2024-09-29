using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        InitializePrompts();
    }

    public void InitializePrompts()
    {
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Did I get enough sleep last night?",
            "What was the worst part of my day?",
            "How do I manage time in my day?",
            "Did I enjoy work today?",
            "Did I learn something new today?",
            "What do I remember from the people I've talked to today?"
        };

    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
}
