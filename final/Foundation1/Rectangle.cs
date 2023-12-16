using System;

public class Rectangle
{
    public int _length = 0;
    public int _width = 0;
    public int _result = 0;

    public void Equation(string firstVariable, string secondVariable)
    {
        _length = int.Parse(firstVariable);
        _width = int.Parse(secondVariable);
        _result = _length*_width;
    }

    public void DisplayResult()
    {
        Console.WriteLine($"The result is: {_result}");
    }
}