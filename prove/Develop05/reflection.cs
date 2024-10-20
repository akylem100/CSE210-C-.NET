public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflection(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    private string getRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string getRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void runReflectionActivity()
    {
        displayStartMessage();

        Console.WriteLine("Reflection prompt: " + getRandomPrompt());
        Console.WriteLine("Take a moment to reflect...");

        displaySpinner();
        displaySpinner();

        int remainingTime = _duration;
        while (remainingTime > 0)
        {
            Console.WriteLine(getRandomQuestion());
            displaySpinner();
            remainingTime -= 15;
        }

        displayEndMessage();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}
