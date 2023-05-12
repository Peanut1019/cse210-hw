using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       Menu menu = new Menu();
       PromptGenerator prompt = new PromptGenerator();
       Entry entry = new Entry();
       Journal journal = new Journal();

       List<string> _allEntries = new List<string>();
       Console.WriteLine();
        menu.DisplayMenu();
        int number = int.Parse(Console.ReadLine());
        if (number == 1) {
            entry.PromptUserEntry();

       }
       if (number == 2) {
        foreach (string item in _allEntries) {
            entry.readAll();
        }
       }
       if (number == 3) {
        journal.read();
}
       if (number == 4) {
        Journal journal1 = new Journal();
        journal1.write;
        }
        if (number == 5) {
            Console.WriteLine("Goodbye!");
        }
       }
    }

