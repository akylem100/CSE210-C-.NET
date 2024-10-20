public class Breathing : Activity
{
    public Breathing(string name, string description, int duration) : base(name, description, duration) {}

    public void runBreathingActivity()
    {
        displayStartMessage();

        int remainingTime = _duration;
        while (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            displayCountdown(5);
            remainingTime -= 5;

            Console.WriteLine("Breathe out...");
            displayCountdown(5);
            remainingTime -= 5;
        }

        displayEndMessage();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    public void displayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}
