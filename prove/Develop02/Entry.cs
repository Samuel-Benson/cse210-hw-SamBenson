using System.Net.Mime;
using System.Xml.Serialization;

public class Entry
{
    public string content;
    public string date;
    public string prompt;

    public Entry(string content, string prompt)
    {
        this.content = content;
        this.prompt = prompt;
        this.date = DateTime.Now.ToShortDateString();
    }

    public Entry(string line)
    {
        var parts = line.Split("|");
        this.date = parts[0];
        this.prompt = parts[1];
        this.content = parts[2];
    }

    public string Export()
    {
        return $"{date}|{prompt}|{content}";
    }

    public string DisplayString()
    {
        return $"Date: {date}/n Prompt: {prompt} /n {content}";
    }
}

