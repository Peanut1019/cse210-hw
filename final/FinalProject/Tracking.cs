using System;
public class Tracking{

private int _calories;
private int _option;
private string defilename = "cals.txt";
List <int> _calCount = new List<int>();
public Tracking(int calories){
_calories = calories;
}
public void CalculateCalories(){
Console.WriteLine("Choose one:");
Console.WriteLine("1: Had Food");
Console.WriteLine("2: Did Activity");
Console.WriteLine("What would you like to log?");
_option = int.Parse(Console.ReadLine());
switch(_option){
case 1:
tf1.AddCalories();
_calories =+ addCal;
break;
case 2:
ta1.SubCalories();
_calories =- subCal;
break;
}
}
TrackingFood tf1 = new TrackingFood(calories, addCal);
TrackingActivity ta1 = new TrackingActivity(calories, subCal);
    protected static int calories;

    public static int addCal { get; private set; }
    public static int subCal { get; private set; }

    

public int GetCalories(){
return _calories;
}
public void DisplayCalories(){
Console.WriteLine($"{_calories}");
}


public void SaveCals(){
using (StreamWriter outputFile = new StreamWriter(defilename)){
    
    outputFile.WriteLine($"Calories: {_calories}");
}
}
public void LoadCals(){
    string[] lines = System.IO.File.ReadAllLines(defilename);
    _calCount.Clear();
    int counter = 0;
    foreach (string line in lines)
    {
    string[] getType = line.Split(":");
    if(counter == 0){
        _calories = int.Parse(line);
    }
    else{
     _calories = 0;  
    }
    _calCount.Add(_calories);
    counter++;
    }
}
}
