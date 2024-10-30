public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", "Running", 30, 3.0),
            new Cycling("03 Nov 2022", "Cycling", 45, 12.0),
            new Swimming("03 Nov 2022", "Swimming", 20, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
