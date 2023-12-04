using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        string loop = "0";

        Relax menu = new Relax();
        Breathing breath = new Breathing();
        Reflection reflect = new Reflection();
        Listing goodThings = new Listing();

        while (loop != "4")
        {
            menu.DisplayChoices();
            loop = Console.ReadLine();
            if (loop == "1")
            {
                Console.WriteLine("You have chosen the breathing activity.");
                breath.Start();
                breath.TimeLength();
                breath.BreathingActivity();
            }
            else if (loop == "2")
            {
                Console.WriteLine("You have chosen the reflection activity.");
                reflect.Start();
                reflect.TimeLength();
                reflect.Prompting();
            }
            else if (loop == "3")
            {
                Console.WriteLine("You have choesn the listing activity.");
                goodThings.start();
                goodThings.TimeLength();
                goodThings.ListStuff();
            }
            else if (loop == "4")
            {
                Console.WriteLine("Thank you for your time, have a lovely day.");
            }
            else
            {
                Console.WriteLine("Input not recognized, please try again.");
            }

        }
    }
}