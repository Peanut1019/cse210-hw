using System;

class Program
{
    static void Main(string[] args)
    {
        Assingment a1 = new Assingment("Siccilly Bueyers", "Division");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment m2 = new MathAssignment("Tippilio Eywers", "Decimals", "9.5", "3-14");
        Console.WriteLine(m2.GetSummary());
        Console.WriteLine(m2.GetHomeworkList());

        WritingAssignment w3 = new WritingAssignment("Martha Skewart", "European Etiquette", "The Causes of the Loss of Courting");
        Console.WriteLine(w3.GetSummary());
        Console.WriteLine(w3.GetWritingInformation());
    }
}