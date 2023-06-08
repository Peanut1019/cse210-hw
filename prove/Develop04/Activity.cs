using System;
public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    public Random _random = new Random();
   public Activity(string activityName, string description, int duration){
    _activityName = activityName;
    _description = description;
    _duration = duration;
   }
   public int timeLeft() 
   {
    _duration = _duration - 1;
    return _duration;
   }
   public string displayStartingMessage(string v, string v1)
    {
    return $"{_activityName}\n{_description}";
   }
   public string displayEndingMessage(){
    return $"Well done!";
   }
   public void pausingSpinner(){
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(5);
    Thread.Sleep(3000);
    DateTime currentTime = DateTime.Now;
    if (currentTime < futureTime)
    {
        for (int i = 5; i > 0; i--) {
        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
    }
    }
   }
   public void pasuingCountdownTimer(){
    for (int i = 5; i > 0; i--) {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
   }
   
   
}






