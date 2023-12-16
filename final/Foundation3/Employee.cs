using System;

public class Employee
{
    public string _name = "";

    public string _position = "";

    public string _employmentType = "";

    public int _timeWorked = 0;

    public void DisplayEmployee()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Position: {_position}");
        Console.WriteLine($"Employment type: {_employmentType}");
        Console.WriteLine($"Time worked: {_timeWorked}");

    }
}