using System;

public abstract class PartsList
{
    public List<string> _nouns = new List<string>{"test", "test2", "test3", "test4", "test5", "test6", "test7"};
    
    public List<string> _verbs = new List<string>{"test", "test2", "test3", "test4", "test5", "test6", "test7"};

    public List<string> _pronouns = new List<string>{"test", "test2", "test3", "test4", "test5", "test6", "test7"};

    public List<string> _adjectives = new List<string>{"test", "test2", "test3", "test4", "test5", "test6", "test7"};

    public Random _randomGenerator = new Random();


    public abstract void SentenceBuilder();
}