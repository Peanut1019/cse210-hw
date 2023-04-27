using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numb = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (numb != 0)
        {
            Console.Write("Enter a number (0 to stop): ");
            
            string userResponse = Console.ReadLine();
            numb = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (numb != 0)
            {
                numbers.Add(numb);
            }
            
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine(numbers.Count);
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
