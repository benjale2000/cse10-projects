using System;

public class Information
{
    private string _name = "";
    private string _DOB = "";
    private string _SSN = "";
    private string _height = "";
    private string _weight = "";
    private string _complexion = "";
    
    public void SavingInfo (string name, string DOB, string SSN, string height, string weight, string complexion)
    { 
        _name = name;
        _DOB = DOB;
        _SSN = SSN;
        _height = height;
        _weight = weight;
        _complexion = complexion;
    }

    public void DisplayID()
    { 
        Console.WriteLine($"The information for {_name} is:");
        Console.WriteLine($"Date of birth: {_DOB}");
        Console.WriteLine($"Social Security number: {_SSN}");
        Console.WriteLine($"Height: {_height}");
        Console.WriteLine($"Weight: {_weight}");
        Console.WriteLine($"Complexion: {_complexion}");
    }
}