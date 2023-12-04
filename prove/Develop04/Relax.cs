using System;

public class Relax
{
    public int _TimeLength = 0;

    public Random _randomGenerator = new Random();

    public void DisplayChoices()
    {
        Console.WriteLine("Please choose one of three options:");
        Console.WriteLine("1. Breathing Activity.");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit.");
    }
}