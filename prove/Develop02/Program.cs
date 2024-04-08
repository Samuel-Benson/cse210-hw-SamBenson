using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();        
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Clear();
            int choice = ShowMenu();

            if (choice == 1) //Write
            {
                journal.AddEntry();
            }
            else if (choice == 2) //display
            {
                Console.Clear();
                journal.DisplayEntry();
            }
            else if (choice == 3) //load
            {
                var lines = ReadFile();
                journal = new Journal(lines);
            }
            else if (choice == 4) //save
            {
                var lines = journal.Export();
                WriteFile(lines);
            }
            else if (choice == 5) //quit
            {
                keepGoing = false;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("\nWhat would you like to do: ");
        var choice = int.Parse(Console.ReadLine());
        return choice;
    }

    static string[] ReadFile()
    {
        System.Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }

    static void WriteFile(string[] lines)
    {
        Console.Write("Enter filename; ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }
}