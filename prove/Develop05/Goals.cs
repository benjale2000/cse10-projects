using System;

public class Goal
{
    public string _shortName = "";
    public string _description = "";
    public string _points = "";

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void DisplayGoal()
    {
        Console.WriteLine($"Name: {_shortName}");
        Console.WriteLine($"Details: {_description}");
        Console.WriteLine($"Points: {_points}");
    }
}