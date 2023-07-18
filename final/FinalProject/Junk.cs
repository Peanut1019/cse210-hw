using System;
public class Junk : TrackingFood{
private int _grams;
private int _adcal;
private string _sugar;
private string _carbs;
public Junk(int calories, int addCal): base(calories, addCal){

}
public void AddSugar(){
Console.WriteLine("Your options are: chocolate, caramel, and lollipop.");
Console.WriteLine("What was the candy?");
_sugar = Console.ReadLine();
Console.WriteLine("How much did you consume in grams?");
_grams = int.Parse(Console.ReadLine());
if (_sugar == "chocolate"){
    _adcal = (int)(_grams * 5.46);
}
else if (_sugar == "caramel"){
    _adcal= (int)(_grams * 3.82);
}
else if (_sugar == "lollipop"){
    _adcal = (int)(_grams * 3.88);
}
else{
    Console.WriteLine("Sorry, not an option.");
}
}
public void AddCarbs(){
  Console.WriteLine("Your options are: bread, crackers, and cookies.");
Console.WriteLine("What was the carby item?");
_carbs = Console.ReadLine();
Console.WriteLine("How much did you consume in grams?");
_grams = int.Parse(Console.ReadLine());
if (_carbs == "bread"){
    _adcal = (int)(_grams * 2.63);
}
else if (_carbs == "crackers"){
    _adcal= (int)(_grams * 5.06);
}
else if (_carbs == "cookies"){
    _adcal = (int)(_grams * 5);
}  
else{
    Console.WriteLine("Sorry, not an option.");
}
}
public int ReturnJunk(){
    return _adcal;
}
}