using System.Runtime.InteropServices;
using System.Transactions;

public class Scripture
{
    public List<Reference> references;

    public Scripture()
    {
        references = new List<Reference>();
    }

    public Scripture(string[] importLines)
    {
        references = new List<Reference>();
        foreach (var line in importLines)
        {
            var reference = new Reference(line);
            references.Add(reference);
        }
    }

    public void DisplayReferences()
    {
        Console.WriteLine("\nReference List:");
        Console.WriteLine("---------");

        foreach (var reference in references)
        {
            Console.WriteLine(reference.DisplayString());
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var reference in references)
        {
            exportLines.Add(reference.Export());
        }
        return exportLines.ToArray();
    }

    public void AddReference()
    {
        Console.Write("Enter book: ");
        var book = Console.ReadLine();

        Console.Write("Enter chapter number: ");
        var chapter = int.Parse(Console.ReadLine());

        Console.Write("Enter starting verse number: ");
        var verseStart = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending verse number: ");
        var verseEnd = int.Parse(Console.ReadLine());

        var reference = new Reference(book, chapter, verseStart, verseEnd);

        references.Add(reference);
    }
}