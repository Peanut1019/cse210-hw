using System;
public class Reflection : Activity
{
   public Reflection(string activityName, string description, int duration) : base(activityName, description, duration){

    }
    public List<string> _think = new List<string>(){
        "Why was this experience meaningful to you?\n",
        "Have you ever done anything like this before?\n",
        "How did you get started?\n",
        "How did you feel when it was complete?\n",
        "What made this time different than other times when you were not as successful?\n",
        "What is your favorite thing about this experience?\n",
        "What could you learn from this experience that applies to other situations?\n",
        "What did you learn about yourself through this experience?\n",
        "How can you keep this experience in mind in the future?\n"
        };
    private string _thinker;
    public string GetRandomThink()
    {
    int random_index = _random.Next(_think.Count);
    _thinker = _think[random_index];
    return $"{_thinker}";
    }
    public List<string> _prompts = new List<string>(){
    "Think of a time when you stood up for someone else.\n",
    "Think of a time when you did something really difficult.\n",
    "Think of a time when you helped someone in need.\n",
    "Think of a time when you did something truly selfless.\n"
        };
         private string _prompt = "";
   public string GetRandomPrompt(){
    int random_index = _random.Next(_prompts.Count);
            _prompt = _prompts[random_index];
            return _prompt;
   }

    
}