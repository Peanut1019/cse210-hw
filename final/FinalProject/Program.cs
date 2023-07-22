using System;

class Program
{
    static void Main(string[] args)
    {
       string _deside;
       int cal = 0;
       int _opt;
       int _option;
Healthy h1 = new Healthy(cal);  
Junk j1 = new Junk(cal);
Cardio c1 = new Cardio(cal);
Muscule m1 = new Muscule(cal);
Warmup w1 = new Warmup(cal);
       Console.WriteLine("Would you like to record a calorie event? (y/n)");
        _deside = Console.ReadLine();
        Tracking t1 = new Tracking(cal);
        t1.LoadCals();
        while (_deside == "y"){
            
            Console.WriteLine("Choose one:");
Console.WriteLine("1: Had Food");
Console.WriteLine("2: Did Activity");
Console.WriteLine("What would you like to log?");
_option = int.Parse(Console.ReadLine());
switch(_option){
case 1:
Console.WriteLine("The types of foods are:");
Console.WriteLine("1. Healthy");
Console.WriteLine("2. Junk");
Console.WriteLine("Which one did you consume?");
_opt = int.Parse(Console.ReadLine());
if (_opt == 1){

t1.update(h1);
}
else if (_opt == 2){
t1.update(j1);
}
break;
case 2:
Console.WriteLine("The types of activites are:");
Console.WriteLine("1. Cardio");
Console.WriteLine("2. Muscule");
Console.WriteLine("3. Warmup");
Console.WriteLine("Which one did you consume?");
_opt = int.Parse(Console.ReadLine());
        
    if (_opt == 1){
    t1.update(c1);
        }
    else if (_opt == 2){
    t1.update(m1);
    }
    else if (_opt == 3){
        t1.update(w1);
    }
break;
}
            
            cal = t1.GetCalories();
            t1.DisplayCalories();
            t1.SaveCals();
        }

    }
}