using System;

class Program
{
    private static readonly int points;
    private static readonly bool complete;
    private static readonly bool check;
    private static readonly string description;
    private static readonly string name;
    private static readonly int timesToComplete;
    private static readonly int bonusPoints;
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        ChecklistGoal cgoal = new ChecklistGoal(timesToComplete,bonusPoints, name, description, points, complete);
        goals.Add(cgoal);
        EternalGoal egoal = new EternalGoal(name, description, points, complete);
        goals.Add(egoal);
        SimpleGoal sgoal = new SimpleGoal(name, description,points,complete, check);
        goals.Add(sgoal);
        int option = 0;
        while (option != 6){
            foreach (Goal g in goals){
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Please select a choice from the menu.");
        option = int.Parse(Console.ReadLine());
        switch(option){
            case 1:
            g.CreateNewGoal();
            break;
            case 2:
            g.ListGoals();
            break;
            case 3:
            Console.Write ("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();
            g.SaveGoals(fileName);
            break;
            case 4:
            Console.Write ("What is the filename for the goal file? ");
            string filEname = Console.ReadLine();
            g.LoadGoals(filEname);
            break;
            case 5:
            g.RecordEvent();
            break;
        }
        }
        }
    }
}