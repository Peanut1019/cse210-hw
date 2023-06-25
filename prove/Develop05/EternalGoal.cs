using System;
public class EternalGoal : Goal
{
    public int _total;
    public EternalGoal(string name, string description, int points, bool complete) : base(name, description, points, complete)
    {

    }
   public override bool IsCompleted()
   {
    return false;
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
        Console.WriteLine($"Simple: {name} {description} {complete}");
    }
    public static implicit operator string(EternalGoal v)
    {
        throw new NotImplementedException();
    }
}