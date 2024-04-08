using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        bool keepGoing = true;

        while(keepGoing)
        {
            Console.Clear();
            int choice = ShowMenu();

            if (choice == 1)
            {
                scripture.AddReference();
            }
            else if (choice == 2)
            {
                Console.Clear();
                scripture.DisplayReferences();
            }
            else if (choice == 3)
            {
                var lines = Scripture.Export();
                WriteFile(lines);
            }
            else if (choice == 4)
            {
                var lines = ReadFile();
                scripture = new Scripture(lines);
            }
            else if (choice ==5)
            {
                keepGoing = false;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("Scripture Memory System");
        Console.WriteLine("-----------------------");
        Console.WriteLine("     1. Add a scripture");
        Console.WriteLine("     2. List Scripture");
        Console.WriteLine("     3. Save Scripture");
        Console.WriteLine("     4. Load Scripture");
        Console.WriteLine("     5. ");
    }
}