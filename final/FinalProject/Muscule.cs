using System;
public class Muscule : TrackingActivity{
private int _reps;
private int _weight;
private int _subcal;
public Muscule(int calories, int subcal) : base(calories, subcal){

}
public void SubPushup(){
  Console.WriteLine("How heavy was the weight (in pounds)?");
_weight = int.Parse(Console.ReadLine());
Console.WriteLine("How many reps did you do?");
_reps = int.Parse(Console.ReadLine());
_subcal = (int)(_reps * _weight * .32);  
}
public void SubCurling(){
Console.WriteLine("How heavy was the weight (in pounds)?");
_weight = int.Parse(Console.ReadLine());
Console.WriteLine("How many reps did you do?");
_reps = int.Parse(Console.ReadLine());
_subcal = (int)(_weight / 60 * 4.5 * _reps);
}
}