using System;
public class Tracking{

private int _calories;

private string defilename = "cals.txt";
List <int> _calCount = new List<int>();
public Tracking(int cal){
calories = cal;
}
private double calories;
  
    public void update(Trackable item)
  {
    this.calories += item.computeCalories();
  }

public int GetCalories(){
return (int)(calories);
}
public void DisplayCalories(){
Console.WriteLine($"{calories}");
}


public void SaveCals(){
using (StreamWriter outputFile = new StreamWriter(defilename)){
    outputFile.WriteLine($"Calories: {GetCalories()}");
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
