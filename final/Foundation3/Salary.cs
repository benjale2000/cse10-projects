using System;

public class Salary : PayRates
{
    public void DisplayPayment()
    {
        int payment = _salary/12;
        Console.WriteLine($"Payment: {payment}");
    }
}