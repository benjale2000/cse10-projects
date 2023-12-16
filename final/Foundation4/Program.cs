using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        SeriousSentence serious = new SeriousSentence();
        SillySentence silly = new SillySentence();

        serious.SentenceBuilder();
        serious.DisplaySentence();

        silly.SentenceBuilder();
        silly.DisplaySentence();

    }
}