using System;
 public class Journal
    {
        PromptGenerator prompt = new PromptGenerator();
        Entry entry = new Entry();
        
       public void read() {
         string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
        string[] parts = line.Split(",");

        string date = parts[0];
        string prompt = parts[1];
        string entry = parts[2];
        }
       }
    public void write() {
        string filename = "journal.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
{
    // You can add text to the file with the WriteLine method
    
    // You can use the $ and include variables just like with Console.WriteLine
    string prompt1 = prompt.getPrompt();
    string entry1 = entry.PromptUserEntry();
    outputFile.WriteLine($"My favorite color is {prompt1} {entry1}");
    }
    }
    }