using System;
public class Warmup : Trackable{
private int _duration;
private string _waract;
private double _addcal;
public Warmup(int calories) : base(calories){

}
public override double computeCalories(){
Console.WriteLine("Write: 'up' for standing and 'out' for stretching");
_waract = Console.ReadLine();
Console.WriteLine("How long did you sdo it for (in hours)?");
_duration = int.Parse(Console.ReadLine());
if (_waract == "up"){
_addcal = _duration * 206;
return _addcal;
}
else if (_waract == "out"){
_addcal = _duration * 2.7;
return _addcal;
}
else{
    return 0;
}

}
}

