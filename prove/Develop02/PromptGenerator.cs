using System;
 public class PromptGenerator
    {
        // The C# convention is to start member variables with an underscore _
        public Random random = new Random();
        public string _prompt = "";
        public List<string> _prompts = new List<string>(){
            "Why are you feeling waht you are feeling right now?\n",
            "Which friend would you take abroad and why?\n",
            "Define the best place for you to visit once and never return.\n",
            "Would you rather grow a cactus or a pear tree and why?\n"
        };
        public string getPrompt() {
            int random_index = random.Next(_prompts.Count);
            _prompt = _prompts[random_index];
            return _prompt;
        }
        public void readPrompt(){
            Console.WriteLine($"{_prompt}");
        }
    }