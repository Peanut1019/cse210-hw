using System;

class Program
{
    public static string entries { get; private set; }
    public static int duration { get; private set; }
    public static string description { get; private set; }
    public static string activityName { get; private set; }

    static void Main(string[] args)
    {
        Console.WriteLine("1.Start Breathing Activity\n 2. Start Reflecting Activity\n 3. Start Listing Activity\n 4. Quit");
        int answer = int.Parse(Console.ReadLine());
        while (answer != 4){
            Activity a1 = new Activity(activityName, description, duration);
            if (answer == 1)
            {
                a1.displayStartingMessage("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine("How long, in seconds, do you wish to do this activity?");
                int duration = int.Parse(Console.ReadLine());
                Breathing breath1 = new Breathing(activityName, description, duration);
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(duration);
                Thread.Sleep(3000);
                DateTime currentTime = DateTime.Now;
                if (currentTime < futureTime)
                {
                    breath1.displayBreathIn();
                    a1.pasuingCountdownTimer();
                    breath1.displayBreathOut();
                    a1.pasuingCountdownTimer();
                }
                a1.displayEndingMessage();
                
            }
            if (answer == 2)
            {
                a1.displayStartingMessage("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine("How long, in seconds, do you wish to do this activity?");
                int duration = int.Parse(Console.ReadLine());
                Reflection ref1 = new Reflection(activityName, description, duration);
                ref1.GetRandomPrompt();
                a1.pasuingCountdownTimer();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(duration);
                Thread.Sleep(3000);
                DateTime currentTime = DateTime.Now;
                if (currentTime < futureTime)
                {
                    ref1.GetRandomThink();
                    a1.pausingSpinner();
                }
                a1.displayEndingMessage();
            }
            if (answer == 3)
            {
                a1.displayStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                Console.WriteLine("How long, in seconds, do you wish to do this activity?");
                int duration = int.Parse(Console.ReadLine());
                Listing list1 = new Listing(activityName, description, duration, entries);
                list1.GetRandomPrompt();
                a1.pasuingCountdownTimer();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(duration);
                Thread.Sleep(3000);
                DateTime currentTime = DateTime.Now;
                if (currentTime < futureTime)
                {
                    string entries = Console.ReadLine();
                    
                }
                list1.EntryCount();
                a1.displayEndingMessage();
            }
            
            Console.WriteLine("1.Start Breathing Activity\n 2.Start Reflecting Activity\n 3. Start Listing Activity\n 4. Quit");
            answer = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Goodbye!");
    }
}