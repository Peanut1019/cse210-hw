using System;
public class Warmup : Trackable{
private int _duration;
private string _waract;
public Warmup(int calories) : base(calories){

}
public override double computeCalories(){
Console.WriteLine("Write: 'up' for standing and 'out' for stretching");
_waract = Console.ReadLine();
Console.WriteLine("How long did you sdo it for (in hours)?");
_duration = int.Parse(Console.ReadLine());
if (_waract == "up"){
return _duration * 206;
}
else if (_waract == ""){
return _duration * 2.7;
}
else{
    return 0;
}
}
}