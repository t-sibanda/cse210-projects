using System;
public class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int? StartVerse { get; }
    public int? EndVerse { get; }

    public Reference(string book, int chapter) 

    {
        Book = book;
        Chapter = chapter;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public string GetReferenceString()
    {
        if (EndVerse.HasValue)
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
        else
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
    }
}
