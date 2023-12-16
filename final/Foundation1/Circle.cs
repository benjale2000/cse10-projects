using System;

public class Circle
{
    public int _radius = 0;
    public double _result = 0;

    public void Equation(string firstVariable)
    {
        _radius = int.Parse(firstVariable);
        _result = _radius*_radius*3.1415;
    }

    public void DisplayResult()
    {
        Console.WriteLine($"The result is: {_result}");
    }
}