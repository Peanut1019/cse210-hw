using System;
public class Healthy : Trackable{
private int _amount;
private string _fruit;
private string _veg;
private string _meat;
private string _helfood;
private double _addcal;    
public Healthy(int calories): base(calories){
}
public override double computeCalories(){
Console.WriteLine("Write: 'f' for fruit, 'v' for veg, and 'm' for meat");
_helfood = Console.ReadLine();
if (_helfood == "f"){
Console.WriteLine("Your options are: apple, bannana, and kiwi.");
Console.WriteLine("What was the fruit?");
_fruit = Console.ReadLine();
Console.WriteLine("How much did you consume?");
_amount = int.Parse(Console.ReadLine());
    if (_fruit == "apple"){
    _addcal = _amount * .52;
    return _addcal;
}
    else if (_fruit == "bannana"){
    _addcal = _amount * .89;
    return _addcal;
}
    else if (_fruit == "kiwi"){
    _addcal = _amount * .61;
    return _addcal;
}
    else{
        return 0;
    }
}
else if (_helfood== "v"){
Console.WriteLine("Your options are: broccoli, carrots, and peas.");
Console.WriteLine("What was the vegtable?");
_veg = Console.ReadLine();
Console.WriteLine("How much did you consume?");
_amount = int.Parse(Console.ReadLine());
if (_veg == "broccoli"){
    _addcal = _amount * .34;
    return _addcal;
}
else if (_veg == "carrots"){
    _addcal = _amount * .41;
    return _addcal;
}
else if (_veg == "peas"){
    _addcal = _amount * .81;
    return _addcal;
}
else{
    return 0;
}
}
else if (_helfood == "m"){
Console.WriteLine("Your options are: chicken, pork, and beef.");
Console.WriteLine("What was the meat?");
_meat = Console.ReadLine();
Console.WriteLine("How much did you consume (grams)?");
_amount = int.Parse(Console.ReadLine());
if (_meat == "chicken"){
    _addcal = _amount * 1.65;
    return _addcal;
}
else if (_meat == "pork"){
    _addcal = _amount * 2.42;
    return _addcal;
}
else if (_meat == "beef"){
    _addcal = _amount * 2.5;
    return _addcal;
}
else{
    return 0;
} 
}
else{
    return 0;
}
}
}