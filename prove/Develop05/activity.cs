public class Activity
{
    private string _name { get; set; }
    private string _description { get; set; }
    public int _duration { get; private set; }
    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void displayStartMessage()
    {
        Console.WriteLine($"{_name} - {_description}");
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        Console.WriteLine();
    }

    public void displayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done! You have completed another {_duration} seconds of the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine();
    }

    public void displayCountdown()
    {
        for (int i = _duration; i >= 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public void displaySpinner()
    {
        List<string> animation = new List<string>{"|", "/", "-", "\\"};

        for (int i = 0; i < _duration * 2; i++)
        {
            Console.Write($"{animation[i % animation.Count]}");
            Thread.Sleep(300);
            Console.Write("\b");
        }
    }

}
