using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video
{
    public List <Comment> comments;

    public Video()
    {
        comments = new List<Comment>();
    }

    public Video(string[] importLines)
    {
        comments = new List<Comment>();
        foreach (var line in importLines)
        {
            var comment = new Comment(line);
            comments.Add(comment);
        }
    }

    public void DisplayEntry()
    {
        Console.WriteLine("Your Video's Comments:");
        Console.WriteLine("");

        foreach (var comment in comments)
        {
            Console.WriteLine(comment.DisplayString());
        }

        Console.WriteLine("");
        Console.ReadKey();
    }

    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var comment in comments)
        {
            exportLines.Add(comment.Export());
        }
        return exportLines.ToArray();
    }

    public void AddEntry()
    {
        var title = Console.Write("What is the title of the video: ");
        Console.WriteLine(title);
        var author = Console.Write("");

    }
}