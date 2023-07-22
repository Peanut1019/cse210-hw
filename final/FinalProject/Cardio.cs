using System;
public class Cardio : Trackable{
private int _distance;
private string _caract;
private double _subcal;
public Cardio(int calories) : base(calories){

}


public override double computeCalories(){
Console.WriteLine("Write: 'w' for walking and 'r' for running");
_caract = Console.ReadLine();
Console.WriteLine("How far did you go (in miles)?");
_distance = int.Parse(Console.ReadLine());
if (_caract == "w"){
_subcal = _distance * 80;
return _subcal;
}
else if (_caract =="r"){
_subcal = _distance * 100;
return _subcal;
}
else{
    return 0;
}
}
}