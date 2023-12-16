using System;

public class SeriousSentence : PartsList
{
    public string _sentence = "";

    public override void SentenceBuilder()
    {
        string noun1 = _nouns[_randomGenerator.Next(0, 6)];
        string verb = _verbs[_randomGenerator.Next(0, 6)];
        string noun2 = _nouns[_randomGenerator.Next(0, 6)];

        _sentence = $"{noun1} {verb} {noun2}.";
    }

    public void DisplaySentence()
    {
        Console.WriteLine(_sentence);
    }

}