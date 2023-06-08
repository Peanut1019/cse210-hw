using System;
public class Breathing : Activity{
    public Breathing(string activityName, string description, int duration) : base(activityName, description, duration){

    }
    public void displayBreathIn(){
        Console.WriteLine($"Breath In...");
    }
    public void displayBreathOut(){
        Console.WriteLine($"Breath Out...");
    }
}