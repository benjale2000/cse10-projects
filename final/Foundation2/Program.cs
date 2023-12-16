using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Processing process = new Processing();

        string loop = "";

        while (loop != "3")
        {
            Console.WriteLine("Please select what you would like to do:");
            Console.WriteLine("1. input info.");
            Console.WriteLine("2. display info.");
            Console.WriteLine("3. quit.");
            loop = Console.ReadLine();
            if (loop == "1")
            {
                process.GetInfo();
            }
            else if (loop == "2")
            {
                process.DisplayInfo();
            }
            else if (loop == "3")
            {
                Console.WriteLine("Thank you for your time, have a lovely day!");
            }
            else
            {
                Console.WriteLine("Input not recognized, please try again.");
            }
        }
    }
}