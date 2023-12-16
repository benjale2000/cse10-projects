using System;

public class SillySentence : PartsList
{
    public string _sentence = "";

    public override void SentenceBuilder()
    {
        string adjective1 = _adjectives[_randomGenerator.Next(0, 6)];
        string noun1 = _nouns[_randomGenerator.Next(0, 6)];
        string verb = _verbs[_randomGenerator.Next(0, 6)];
        string adjective2 = _adjectives[_randomGenerator.Next(0, 6)];
        string noun2 =_nouns[_randomGenerator.Next(0, 6)];

        _sentence = $"{adjective1} {noun1} {verb} {adjective2} {noun2}";
    }

    public void DisplaySentence()
    {
        Console.WriteLine(_sentence);
    }
}