using System;
public class Healthy : Trackable{
private int _amount;
private string _fruit;
private string _veg;
private string _meat;
private string _helfood;    
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
    return _amount * .52;
}
    else if (_fruit == "bannana"){
    return _amount * .89;
}
    else if (_fruit == "kiwi"){
    return _amount * .61;
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
    return _amount * .34;
}
else if (_veg == "carrots"){
    return _amount * .41;
}
else if (_veg == "peas"){
    return _amount * .81;
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
    return (int)(_amount * 1.65);
}
else if (_meat == "pork"){
    return (int)(_amount * 2.42);
}
else if (_meat == "beef"){
    return _amount * 2.5;
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