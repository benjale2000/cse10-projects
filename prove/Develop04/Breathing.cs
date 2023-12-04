using System;

public class Breathing : Relax
{

    public void Start()
    {
        Console.WriteLine("Relax through breathing in and out, focus on your breathing and clear your mind.");
    }

    public void TimeLength()
    {
        Console.WriteLine("Before we start. How long do you wish to do this excercise for? (Minutes)");
        string timeInput = Console.ReadLine();
        _TimeLength = int.Parse(timeInput);
    }

    public void BreathingActivity()
    {
        Console.WriteLine($"This shall now go for {_TimeLength} minutes.");
        //code for the thing goes here.
        Console.WriteLine("Congratulations you did it. Hope you are feeling much better.");
    }
}