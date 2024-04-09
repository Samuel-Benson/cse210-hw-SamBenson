using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video();
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Clear();
            int choice = ShowMenu();

            if (choice ==1) //Create Video
            {
                video.AddEntry();
            }
            else if (choice == 2)
            {
                Console.Clear();
                video.DisplayEntry();
            }
            else if (choice == 3)
            {
                var lines = ReadFile();
                video = new Video(lines);
            }
            else if (choice == 4)
            {
                var lines = video.Export();
                WriteFile(lines);
            }
            else if (choice == 5)
            {
                keepGoing = false;
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("Welcome to The Video and Comment Creator");
        Console.WriteLine("1. Create");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do: ");
        var choice = int.Parse(Console.ReadLine());
        return System,.IO.File.ReadAllLines(filename);
    }

    static void WriteFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }
}