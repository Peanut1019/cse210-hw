using System;
public class Junk : Trackable{
private int _grams;
private string _sugar;
private string _carbs;
private string _jfood;
private double _addcal;
public Junk(int calories): base(calories){

}
public override double computeCalories(){
Console.WriteLine("Write: 's' for sugar and 'c' for carbs");
_jfood = Console.ReadLine();
if (_jfood == "s"){
Console.WriteLine("Your options are: chocolate, caramel, and lollipop.");
Console.WriteLine("What was the candy?");
_sugar = Console.ReadLine();
Console.WriteLine("How much did you consume in grams?");
_grams = int.Parse(Console.ReadLine());
if (_sugar == "chocolate"){
    return _grams * 5.46;
}
else if (_sugar == "caramel"){
    return _grams * 3.82;
}
else if (_sugar == "lollipop"){
    return _grams * 3.88;
}
else{
    return 0;
}
}
else if (_jfood == "c"){
Console.WriteLine("Your options are: bread, crackers, and cookies.");
Console.WriteLine("What was the carby item?");
_carbs = Console.ReadLine();
Console.WriteLine("How much did you consume in grams?");
_grams = int.Parse(Console.ReadLine());
if (_carbs == "bread"){
    _addcal = _grams * 2.63;
    return _addcal;
}
else if (_carbs == "crackers"){
    _addcal = _grams * 5.06;
    return _addcal;
}
else if (_carbs == "cookies"){
    _addcal = _grams * 5;
    return _addcal;
}  
else{
    return 0;
}
}
else {
    return 0;
}
}
}