using System;
public class Healthy : TrackingFood{
private int _amount;
private int _adcal;
private string _fruit;
private string _veg;
private string _meat;
public Healthy(int calories, int addCal): base(calories, addCal){
}
public void AddFruit(){
Console.WriteLine("Your options are: apple, bannana, and kiwi.");
Console.WriteLine("What was the fruit?");
_fruit = Console.ReadLine();
Console.WriteLine("How much did you consume?");
_amount = int.Parse(Console.ReadLine());
if (_fruit == "apple"){
    _adcal = (int)(_amount * .52);
}
else if (_fruit == "bannana"){
    _adcal= (int)(_amount * .89);
}
else if (_fruit == "kiwi"){
    _adcal = (int)(_amount * .61);
}
else{
    Console.WriteLine("Sorry, not an option.");
}
}
public void AddVeg(){
Console.WriteLine("Your options are: broccoli, carrots, and peas.");
Console.WriteLine("What was the vegtable?");
_veg = Console.ReadLine();
Console.WriteLine("How much did you consume?");
_amount = int.Parse(Console.ReadLine());
if (_veg == "broccoli"){
    _adcal = (int)(_amount * .34);
}
else if (_veg == "carrots"){
    _adcal = (int)(_amount * .41);
}
else if (_veg == "peas"){
    _adcal = (int)(_amount * .81);
}
else{
    Console.WriteLine("Sorry, not an option.");
}
}
public void AddMeat(){
Console.WriteLine("Your options are: chicken, pork, and beef.");
Console.WriteLine("What was the meat?");
_meat = Console.ReadLine();
Console.WriteLine("How much did you consume (grams)?");
_amount = int.Parse(Console.ReadLine());
if (_meat == "chicken"){
    _adcal = (int)(_amount * 1.65);
}
else if (_meat == "pork"){
    _adcal = (int)(_amount * 2.42);
}
else if (_meat == "beef"){
    _adcal = (int)(_amount * 2.5);
}
else{
    Console.WriteLine("Sorry, not an option.");
} 
}
public int ReturnHealth(){
    return _adcal;
}
}