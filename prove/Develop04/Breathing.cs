using System;
public class Breathing : Activity{
    public Breathing(string activityName, string description, int duration) : base(activityName, description, duration){

    }
    public string displayBreathIn(){
        return $"Breath In...";
    }
    public string displayBreathOut(){
        return $"Breath Out...";
    }
}