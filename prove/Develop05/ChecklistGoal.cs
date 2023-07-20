using System;
public class ChecklistGoal : Goal
{
private int _timesToComplete; 
private int _timesCompleted; 
private int _bonusPoints;
private int _total;
private int _numer;
    public ChecklistGoal(int timesToComplete, int bonusPoints, string name, string description, int points, bool complete) : base(name, description, points, complete)
{
    _timesToComplete = timesToComplete;
    _bonusPoints = bonusPoints;
}


public int GetTimesToComplete()
{
return _timesToComplete;
}
public void SetTimesToComplete(int timesToComplete)
{
_timesToComplete = timesToComplete;
}
public int GetBonus()
{
 return _bonusPoints;
}
public void SetBonus(int bonusPoints)
{
_bonusPoints = bonusPoints;
}
public int CalcualteCompletedCount(bool complete)
{
 if(complete == true){
    _numer =+ 1;
 }
 return _numer;
}
public int SumOfAll(){
    return _total + _bonusPoints;
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
public int GetTimesCompleted(){
    return _timesCompleted;
}
internal void SetTimesCompleted(int v)
    {
        _timesCompleted = _timesToComplete - 1;
    }

    public override void DisplayGoals(string name, string description, bool complete)
    {
        Console.WriteLine($"Checklist: {_timesToComplete}. {complete} {name} {description} {_timesCompleted}");
    }

    

   

    public static implicit operator string(ChecklistGoal v)
    {
        throw new NotImplementedException();
    }

    public static explicit operator ChecklistGoal(string v)
    {
        throw new NotImplementedException();
    }
}