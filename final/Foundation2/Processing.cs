using System;

public class Processing
{
    Information _info = new Information();

    public void GetInfo()
    {
        Console.WriteLine("Please input the info for this person.");
        Console.WriteLine("Name?");
        string name = Console.ReadLine();
        Console.WriteLine("Date of Birth?");
        string DOB = Console.ReadLine();
        Console.WriteLine("Social Security Number?");
        string SSN = Console.ReadLine();
        Console.WriteLine("Height?");
        string height = Console.ReadLine();
        Console.WriteLine("Weight?");
        string weight = Console.ReadLine();
        Console.WriteLine("Complexion?");
        string complexion = Console.ReadLine();

        _info.SavingInfo(name, DOB, SSN, height, weight, complexion);
    }

    public void DisplayInfo()
    {
        _info.DisplayID();
    }
}