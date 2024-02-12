using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int listEntry = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (listEntry != 0)
        {
            Console.WriteLine("Enter Number: ");
            string userInput = Console.ReadLine();
            listEntry = int.Parse(userInput);

            if (listEntry != 0)
            {
                numbers.Add(listEntry);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The averages is: {average}");

        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}