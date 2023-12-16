using System;

public class PartTime : PayRates
{
    public void DisplayPayment(int timeWorked)
    {
        int payment = timeWorked*_partTime;
        Console.WriteLine($"Payment: {payment}");
    }
}