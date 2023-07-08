using System;

class Program
{
    static void Main(string[] args)
    {
       int calories = 0;
       string aors = "a";
       Tracking t1 = new Tracking(calories, aors);
       Console.WriteLine("How many calories would you like to record?");
        calories = int.Parse(Console.ReadLine());
        t1.DisplayCalories();
        Console.WriteLine("Would you like to add(a) or subtract(s) that from your total?");
        aors = Console.ReadLine();
        if (aors == "a"){
            Console.WriteLine("Okay, adding that to your total!");
        }
        else{
            Console.WriteLine("Okay, subtracting that from your total!");
        }

    }
}