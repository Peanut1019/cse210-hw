using System;
public class Muscule : Trackable{
private int _reps;
private int _weight;
private string _musact;
private double _subcal;
public Muscule(int calories) : base(calories){

}
public override double computeCalories(){
Console.WriteLine("Write: 'f' for lifting and 'c' for curling");
_musact = Console.ReadLine();
Console.WriteLine("How heavy was the weight (in pounds)?");
_weight = int.Parse(Console.ReadLine());
Console.WriteLine("How many reps did you do?");
_reps = int.Parse(Console.ReadLine());
if (_musact == "l"){
_subcal = _reps * _weight * .32;
return _subcal; 
}
else if (_musact == "c"){
  _subcal = _weight / 60 * 4.5 * _reps;
  return _subcal;
}
else{
  return 0;
}
}
}