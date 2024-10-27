using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager 
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Goal Manager!");
        Console.WriteLine($"You currently have {_totalPoints} points.");
        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. View your goals");
        Console.WriteLine("3. Record a goal event");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Save and quit");
        Console.WriteLine("6. Quit without saving");
        Console.Write("Enter your choice (1-6): ");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: CreateGoal(); Start(); break;
            case 2: ListGoals(); Start(); break;
            case 3: RecordGoalEvent(); Start(); break;
            case 4: LoadGoals(); Start(); break;
            case 5: SaveGoals(); Console.WriteLine("Thanks for using the goal manager!"); Environment.Exit(0); break;
            case 6: Console.WriteLine(); Console.WriteLine("Thanks for using the goal manager!"); Environment.Exit(0); break;
            default: Console.WriteLine("Invalid choice."); Start(); break;
        }
    }

    public void checkIfGoalsExist()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals exist. Please create a new goal first.");
            Console.WriteLine();
            Start();
        }
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter point value: ");
        int pointValue = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, pointValue));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, pointValue));
                break;
            case 3:
                Console.Write("Enter how many times you need to complete it for bonus points: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("How many bonus points for completion? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                int eventCount = 0;
                int eventCountGoal = targetCount;
                _goals.Add(new ChecklistGoal(name, description, pointValue, eventCount, bonusPoints, eventCountGoal));
                break;
            default:
                Console.WriteLine("Invalid choice."); break;
        }
        Console.WriteLine("Goal created successfully!");
        Console.WriteLine();
    }

    public void ListGoals()
    {
        checkIfGoalsExist();
        Console.Clear();
        Console.WriteLine("Your goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.DisplayGoalStatus()} {goal.GetGoalName()} - {goal.GetDescription()}");
        }
        Console.WriteLine();
    }

    public void RecordGoalEvent()
    {
        checkIfGoalsExist();
        Console.Clear();
        Console.WriteLine("Enter the goal number you accomplished:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;

        string message = _goals[choice].RecordEvent();
        _totalPoints += _goals[choice].GetPointValue();
        Console.WriteLine(message);
        Console.WriteLine();
    }

    public void SaveGoals()
{
    checkIfGoalsExist();
    Console.Clear();
    Console.Write("Enter file name to save goals (example: goals.txt): ");
    string fileName = Console.ReadLine();
    using (StreamWriter writer = new StreamWriter(fileName))
    {
        writer.WriteLine(_totalPoints);
        foreach (Goal goal in _goals)
        {
            if (goal is ChecklistGoal checklistGoal)
            {
                writer.WriteLine($"{goal.GetType().Name}|{goal.GetGoalName()}|{goal.GetDescription()}|{goal.GetPointValue()}|{checklistGoal.eventCount}|{checklistGoal.bonusPoints}|{checklistGoal.eventCountGoal}");
            }
            else
            {
                writer.WriteLine($"{goal.GetType().Name}|{goal.GetGoalName()}|{goal.GetDescription()}|{goal.GetPointValue()}");
            }
        }
    }
    Console.WriteLine("Goals saved successfully!");
    Console.WriteLine();
    }

    public void LoadGoals()
    {
    Console.WriteLine("What file would you like to load? (Don't include the '.txt')");
    string fileName = Console.ReadLine();

    if (!File.Exists(fileName + ".txt"))
    {
        Console.WriteLine("File not found. Please make sure the file name is correct.");
        return;
    }

    string[] lines = File.ReadAllLines(fileName + ".txt");

    if (lines.Length == 0)
    {
        Console.WriteLine("The file is empty or not formatted correctly.");
        return;
    }

    try
    {
        _totalPoints = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] goalData = lines[i].Split('|');

            if (goalData.Length < 4)
            {
                Console.WriteLine($"Skipping line {i + 1}: Not enough data to load goal.");
                continue;
            }

            string goalType = goalData[0];
            string name = goalData[1];
            string description = goalData[2];
            int points = int.Parse(goalData[3]);

            Goal goal;
            switch (goalType)
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(name, description, points);
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(name, description, points);
                    break;
                case "ChecklistGoal":
                    int eventCount = int.Parse(goalData[4]);
                    int extraPoints = int.Parse(goalData[5]);
                    int eventCountGoal = int.Parse(goalData[6]);
                    goal = new ChecklistGoal(name, description, points, eventCount, extraPoints, eventCountGoal);
                    break;
                default:
                    Console.WriteLine($"Unknown goal type on line {i + 1}: {goalType}");
                    continue;
            }
            _goals.Add(goal);
        }

        Console.WriteLine("Goals loaded successfully!");
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred while loading the goals: " + ex.Message);
    }
}
}
