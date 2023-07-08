using System;
public class Tracking{
private int _calories;
private string _aors;
private string defilename = "cals.txt";
public Tracking(int calories, string aors){
_calories = calories;
_aors = aors;
}
public string GetAors(){
return _aors;
}
public int GetCalories(){
return _calories;
}
public void DisplayCalories(){
Console.WriteLine($"{_calories}");
}
public void CalculateCalories(){

}
public void SaveCals(){

}
public void LoadCals(string defilename){

}
}
