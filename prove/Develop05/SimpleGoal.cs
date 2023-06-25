using System;
public class SimpleGoal : Goal
{
    private bool _check;
    private int _total;

    public SimpleGoal(string name, string description, int points, bool complete, bool check) : base(name, description, points, complete)
    {
         _check = check;
    }

    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points, complete)
    {
    }

    public override bool IsCompleted()
   {
    return true;
   }
   public override int RecordEvent()
   {
    return GetPoints();
   }
   public override int EarnPoints(bool complete, int points)
{
 if(complete == true){
    _total =+ points;
 }
 return _total;
}
   public override void DisplayGoals(string name, string description, bool complete)
    {
        Console.WriteLine($"Simple: {name} {description} {_check} {complete}");
    }

    public static implicit operator string(SimpleGoal v)
    {
        throw new NotImplementedException();
    }
}