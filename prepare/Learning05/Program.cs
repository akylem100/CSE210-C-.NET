using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asmt = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(asmt.getSummary());
        Console.WriteLine();
        MathAssignment ma = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(ma.getSummary());
        Console.WriteLine(ma.getHomeworkList());
        Console.WriteLine();
        WritingAssignment wa = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(wa.getSummary());
        Console.WriteLine(wa.getWritingInformation());
    }
}