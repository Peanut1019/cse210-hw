using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Welcome! You currently have this many calories:");
       string _deside;
       int cal = 0;
       Console.WriteLine("Would you like to record a calorie event? (y/n)");
        _deside = Console.ReadLine();
        //t1.LoadCals();
        if (_deside == "y"){
            Tracking t1 = new Tracking(cal);
            t1.CalculateCalories();
            cal = t1.GetCalories();
            t1.DisplayCalories();
        }
        else{
            Console.WriteLine("Okay... have a nice day, I guess.");
        }

    }
}