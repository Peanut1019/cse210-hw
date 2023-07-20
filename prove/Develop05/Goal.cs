using System;
public abstract class Goal
{
    private string _name;
    private int _pionts; 
    private string _description;
    private bool _complete;
    private string filename = "goals.txt";
    private int _total;
    private string  _goal;
    private int _option;
    List <Goal> _goals = new List<Goal>();
    private bool check;
    private int timesToComplete;
    private int bonusPoints;
    private readonly bool complete;

    public Goal(string name, string description, int points, bool complete)
    {
            _name = name;
            _pionts = points;
            _description = description;
            _complete = complete;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _pionts;
    }
    public void CreateNewGoal(){
        
        
        do{
            
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("Which would you like to create?");
            _option = int.Parse(Console.ReadLine());
            Goal _goal = null;
            if (_option != 4){
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            int points = int.Parse(Console.ReadLine());
            switch(_option){
                case 1:
                    _goal = new SimpleGoal(name, description, points, false, check);
                    _goals.Add(_goal);
                    break;
                case 2:
                    _goal = new EternalGoal(name, description, points, complete);
                    _goals.Add(_goal);
                    break;
                case 3:
                    Console.Write("How many times does this goal need to be accomplished?");
                    int _timesToComplete = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing this goal?");
                    int _bonusPoints = int.Parse(Console.ReadLine());
                    _goal = new ChecklistGoal(timesToComplete, bonusPoints, name, description, points, complete);
                    _goals.Add(_goal);
                    break;
            }
            }
        
        }while (_option != 4);
    }
    public void SaveGoals(string filename)
    {
    using (StreamWriter outputFile = new StreamWriter(filename)){
        foreach(Goal goal in _goals)
        {
            if(goal is SimpleGoal)
            {
                if(goal.IsCompleted() == true){
                    outputFile.WriteLine($"Simple: {goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.IsCompleted()}");
                }
                else{
                    outputFile.WriteLine($"Simple: {goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.IsCompleted()}");
                }
            }
            else if(goal is EternalGoal){
                outputFile.WriteLine($"Eternal: {goal.GetName()},{goal.GetDescription()},{goal.GetPoints()}");
            }
            else if(goal is ChecklistGoal){
                outputFile.WriteLine($"Checklist: {goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{((ChecklistGoal)goal).GetBonus()}, {((ChecklistGoal)goal).SumOfAll()}");
            }
        }
    
    outputFile.WriteLine(_pionts);
}
    }
    public void LoadGoals(string filename)
    {
    string[] lines = System.IO.File.ReadAllLines(filename);
    _goals.Clear();
    int counter = 0;
    foreach (string line in lines)
    {
    if(counter == 0){
        _pionts = int.Parse(line);
    }
    else{
     Goal _goal = null;
     string[] getType = line.Split(":");
     string[] getInfo = getType[1].Split(",");
     if(getType[0] == "Simple"){
        bool _check = getInfo[3] == "True" ? true : false;
        _goal = new SimpleGoal(getInfo[0], getInfo[1], int.Parse(getInfo[2]), _check);
     }
     else if(getType[0] == "Eternal"){
        _goal = new EternalGoal(getInfo[0], getInfo[1], int.Parse(getInfo[2]), bool.Parse(getInfo[3]));
     }
     else{
        _goal = new ChecklistGoal(int.Parse(getInfo[4]), int.Parse(getInfo[3]),getInfo[0], getInfo[1], int.Parse(getInfo[2]), bool.Parse(getInfo[5]));
        ((ChecklistGoal)_goal).SetTimesCompleted(int.Parse(getInfo[4]));
     }
     _goals.Add(_goal);  
    }
    counter++;
    }
    
    }
    public void ListGoals(){
        int counter = 0;
        foreach(Goal goal in _goals){
            counter+=1;
            string checkIfDone = goal.IsCompleted() ? "[x]" : "[]";
            string _timesCompleted = goal is ChecklistGoal ? $"---Currently Completed: {((ChecklistGoal)goal).GetTimesCompleted()}/{((ChecklistGoal)goal).GetTimesToComplete}" : "";
            Console.WriteLine($"{counter}. {checkIfDone} {_name} ({_description}) {_timesCompleted}");
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"{_total}");
    }
    public int CalculateScore()
    {
        _total =+ _pionts;
        return _total;
    }
    public abstract int EarnPoints(bool complete, int points);
    public abstract void DisplayGoals(string name, string description, bool complete);
    public void RecordAnEvent()
    {
    int counter = 0;
    Console.WriteLine("The goals are:");
    foreach (Goal goal in _goals)
    {
        counter++;
        Console.WriteLine($"{counter}. {goal.GetName()}");
    }
    Console.Write("Which goal did you accomplish?");
    int _decision = int.Parse(Console.ReadLine());
    if (_goals[_decision - 1].IsCompleted() == true)
    {
        Console.WriteLine("This goal is completed already.");
        Console.WriteLine();
    }
    else{
        int _pointsGained = _goals[_decision - 1].RecordEvent();
        Console.WriteLine($"Congradulations! You have earned {_pointsGained} points!");
        _pionts += _pointsGained;
        Console.WriteLine();
    }
    }
    public abstract bool IsCompleted();
    public abstract int RecordEvent();
}