using System.Net.Mime;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

public class Comment
{
    public string name;
    public string text;

    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }

    public Comment(string line)
    {
        var parts = line.Split("|");
        this.name = parts[0];
        this.text = parts[1];
    }

    public string Export()
    {
        return $"{name}|{text}";
    }

    public string DisplayString()
    {
        return $"Name: {name}/n Text: {text}";
    }
}