using System;
using System.Linq;

public class Listing : Activity
{
    private string _entries;
public Listing(string activityName, string description, int duration, string entries) : base(activityName, description, duration){
    _entries = entries;
    }
public List<string> _prompts = new List<string>(){
    "Who are people that you appreciate?\n",
    "What are personal strengths of yours?\n",
    "Who are people that you have helped this week?\n",
    "When have you felt the Holy Ghost this month?\n",
    "Who are some of your personal heroes?\n"
        };
         private string _prompt = "";
   public string GetRandomPrompt(){
    int random_index = _random.Next(_prompts.Count);
            _prompt = _prompts[random_index];
            return _prompt;
   }
   private int _numEntry;
   public int EntryCount()
   {
    _numEntry = _entries.Count();
    return _numEntry;
   }

}
//Prompt ListBehaviors:EntryCount()GetEntryCount()