using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference refrence = new Reference();
        Scripture scripture = new Scripture();
        Word word = new Word();
        Reference f1 = new Reference("John",3,15);
        Scripture scripture1 = new Scripture("That whosoever believeth in him should not perish, but have eternal life.");
        scripture1.HideRandom();
        Console.WriteLine(scripture1.ShowScripture());

    }
}