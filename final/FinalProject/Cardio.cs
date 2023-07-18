using System;
public class Cardio : TrackingActivity{
private int _distance;
private int _subcal;
public Cardio(int calories, int subcal) : base(calories, subcal){

}


    public void SubWalking(){
Console.WriteLine("How far did you go while walking (in miles)?");
_distance = int.Parse(Console.ReadLine());
_subcal = (int)(_distance * 80);
}
public void SubRunning(){
Console.WriteLine("How far did you go while running (in miles)?");
_distance = int.Parse(Console.ReadLine());
_subcal = (int)(_distance * 100);
}
}