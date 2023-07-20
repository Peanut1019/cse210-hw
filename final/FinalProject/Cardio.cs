using System;
public class Cardio : Trackable{
private int _distance;
private string _caract;
public Cardio(int calories) : base(calories){

}


public override double computeCalories(){
Console.WriteLine("Write: 'w' for walking and 'r' for running");
_caract = Console.ReadLine();
Console.WriteLine("How far did you go (in miles)?");
_distance = int.Parse(Console.ReadLine());
if (_caract == "w"){
return _distance * 80;
}
else if (_caract =="r"){
return _distance * 100;
}
else{
    return 0;
}
}
}