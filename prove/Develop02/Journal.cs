using System.Runtime.CompilerServices;

public class Journal
{
    public List <Entry> entries;
    public void GetPrompt()
    {
        
    }
    public Journal()
    {
        entries = new List<Entry>();
    }

    public Journal(string[] importLines)
    {
        entries = new List<Entry>();
        foreach (var line in importLines)
        {
            var entry = new Entry(line);
            entries.Add(entry);
        }
    }

    public void DisplayEntry()
    {
        Console.WriteLine("Your Journal:");
        Console.WriteLine("");

        foreach (var entry in entries)
        {
            Console.WriteLine(entry.DisplayString());
        }

        Console.WriteLine("");
        Console.ReadKey();
    }

    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var entry in entries)
        {
            exportLines.Add(entry.Export());
        }
        return exportLines.ToArray();
    }

    public void AddEntry()
    {
        var prompt = "What is one thing today that brought you joy?";
        Console.WriteLine(prompt);
        Console.Write("Enter Prompt: ");
        var content = Console.ReadLine();
        var entry = new Entry(content, prompt);
        entries.Add(entry);
    }
}