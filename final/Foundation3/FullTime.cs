using System;

public class FullTime : PayRates
{
    public void DisplayPayment(int timeWorked)
    {
        int payment = timeWorked*_fullTime;
        Console.WriteLine($"Payment: {payment}");
    }
}