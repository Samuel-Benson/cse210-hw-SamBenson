public class Reference
{
    public string book;

    public int chapter;

    public int verseStart;

    public int verseEnd;

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    public Reference(string import)
    {
        var parts = import.Split("|");
        this.book = parts[0];
        this.chapter = int.Parse(parts[1]);
        this.verseStart = int.Parse(parts [2]);
        this.verseEnd = int.Parse(parts[3]);
    }

    public string Export()
    {
        return $"{book}|{chapter}|{verseStart}|{verseEnd}";
    }

    public string DisplayString()
    {
        return $"{book} {chapter}:{verseStart}-{verseEnd}";
    }
}