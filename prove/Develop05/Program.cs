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
        ChecklistGoal cgoal = new ChecklistGoal(timesToComplete,bonusPoints, name, description, points, complete);
        EternalGoal egoal = new EternalGoal(name, description, points, complete);
        SimpleGoal sgoal = new SimpleGoal(name, description,points,complete, check);
        int option = 0;
        Console.WriteLine($"You have {goal.GetPoints}");
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
            goal.CreateNewGoal();
            break;
            case 2:
            goal.ListGoals();
            break;
            case 3:
            Console.Write ("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();
            goal.SaveGoals(fileName);
            break;
            case 4:
            Console.Write ("What is the filename for the goal file? ");
            string filEname = Console.ReadLine();
            goal.LoadGoals(filEname);
            break;
            case 5:
            goal.RecordEvent();
            break;
            case 6:
            Console.WriteLine("Thanks fo doing this!");
            break;
        }
    }
}