using System;

public class Listing : Relax
{
    List<string> _listingPromptList = new List<string> {"Who do you appreicate?", "What are you good at?", "Who has helped you this week?", 
    "Who have you helped this week?", "When have you felt the Holy Ghost this week?", "What are some of the good things you are working on?"};

    public void start()
    {
        Console.WriteLine("List the good things in your life, being grateful for them will improve your mood.");
    }

    public void TimeLength()
    {
        Console.WriteLine("Before we start. How long do you wish to do this excercise for? (Minutes)");
        string timeInput = Console.ReadLine();
        _TimeLength = int.Parse(timeInput);
    }

    public void ListStuff()
    {
        Console.WriteLine("Here is the prompt:");
        Console.WriteLine(_listingPromptList[_randomGenerator.Next(0,5)]);
        Console.ReadLine();
    }
}