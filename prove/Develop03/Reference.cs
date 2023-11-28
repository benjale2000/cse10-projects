using System;
// will hold the reference to the scripture, and hold a display method.
public class Reference
{
    private string _book = "proverbs";
    private int _chapter = 3;
    private int _verse = 5;
    private int _endVerse = 6;

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    
    public void DisplayRefernceFull()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
    }

    public void DisplayReferencePartial()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");

    }
}