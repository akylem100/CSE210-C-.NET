using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.Write("Enter a list of numbers, type 0 when finished. ");
        int number = int.Parse(Console.ReadLine());
        numbers.Add(number);
        int stop = 0;
        int sum = 0;
        float avg = 0;
        int largest = 0;

        while (number != stop)
        {
            Console.Write("Enter another number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

            if (number > largest)
            {
                largest = number;
            }
        }

        sum = numbers.Sum();
        avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is: {sum} ");
        Console.WriteLine($"The average of the numbers you entered is: {avg} ");
        Console.WriteLine($"The largest of the numbers you entered is: {largest} ");
    }
}