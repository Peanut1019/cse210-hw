using System;
 public class Entry
    {
        PromptGenerator prompt = new PromptGenerator();
        List<string> _allEntries = new List<string>();
        // The C# convention is to start member variables with an underscore _
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        public List<string> _prompts = new List<string>();
        string _prompt;
        string _entry;
        public string PromptUserEntry()
    {
        prompt.readPrompt();
        string _entry = Console.ReadLine();
        _allEntries.Add(dateText);
        _allEntries.Add(_prompt);
        _allEntries.Add(_entry);

        return _entry;
    }
    public void readAll() {
        Console.WriteLine($"{dateText} {_prompt} {_entry}");
    }
        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        
        
    }