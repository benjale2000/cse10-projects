using System;

public class Triangle
{
    public int _base = 0;
    public int _height = 0;
    public int _result = 0;

    public void Equation(string firstVariable, string secondVariable)
    {
        _base = int.Parse(firstVariable);
        _height = int.Parse(secondVariable);
        _result = _base*_height/2;
    }

    public void DisplayResult()
    {
        Console.WriteLine($"The result is: {_result}");
    }
}