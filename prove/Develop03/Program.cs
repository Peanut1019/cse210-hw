using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string _option = "y";
        while (_option == "y"){
        
        Reference refrence = new Reference();
        Scripture scripture = new Scripture();
        Word word = new Word();
        Reference f1 = new Reference("John",3,15);
        Scripture scripture1 = new Scripture("That whosoever believeth in him should not perish, but have eternal life.");
        Word w1 = new Word();
        scripture1.HideRandom();
        Console.WriteLine($"{f1.getReference()}{scripture1.ShowScripture()}");
        Console.WriteLine("Wanna erase a word?");
        _option = Console.ReadLine();
        }
    }
}