using System;

public class Reflection : Relax
{
    List<string> _reflectPromptList = new List<string> {"Think of a time you brightened someones day.", 
    "Think of a time you were selfless.", "Think of a time you stood up to what you know.", 
    "Think of a time you had to do something hard.", "Think of a time you were inspired to do something."};
    // 5 in the list above.
    List<string> _reflectQuestionList = new List<string> {"Why was this meaningful to you?", 
    "Have you done something like this before?", "How difficult was this?", "What was the best part?", 
    "Did you learn something, and what was it?", "Did you learn something about yourself, and what was it?", 
    "Was this time different, how was it?"};
    // 7 in the list above.
    public void Start()
    {
        Console.WriteLine("Relfect on the times you have been strong today, or this week.");
        Console.WriteLine("Recognize you have strength and can use it.");
    }

    public void TimeLength()
    {
        Console.WriteLine("Before we start. How long do you wish to do this excercise for? (Minutes)");
        string timeInput = Console.ReadLine();
        _TimeLength = int.Parse(timeInput);
    }

    public void Prompting()
    {
        Console.WriteLine("here is the prompt:");
        Console.WriteLine(_reflectPromptList[_randomGenerator.Next(0,4)]);
        Console.ReadLine();
        Console.WriteLine(_reflectQuestionList[_randomGenerator.Next(0,6)]);
        Console.ReadLine();
    }
}