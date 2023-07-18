using System;
public class Warmup : TrackingActivity{
private int _duration;
private int _subcal;
public Warmup(int calories, int subcal) : base(calories, subcal){

}
public void SubStanding(){
Console.WriteLine("How long did you stand (in hours)?");
_duration = int.Parse(Console.ReadLine());
_subcal = (int)(_duration * 206);
}
public void SubStretching(){
Console.WriteLine("How long did you stretch (in minutes)?");
_duration = int.Parse(Console.ReadLine());
_subcal = (int)(_duration * 2.7);
}
}