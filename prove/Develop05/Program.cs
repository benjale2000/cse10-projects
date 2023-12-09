using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        string loop = "";
        Goal goal = new Goal("", "", "");

        Console.WriteLine("Welcome to goal managing.");
        while (loop != "5")
        {
            Console.WriteLine("Please select what you want to do:");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Quit");
            loop = Console.ReadLine();

            if (loop == "1")
            {
                Console.WriteLine("You will create a goal, what is it's name?");
                string goalName = Console.ReadLine();
                Console.WriteLine("What are the details?");
                string goalDetails = Console.ReadLine();
                Console.WriteLine("How many points?");
                string goalPoints = Console.ReadLine();
                goal._shortName = goalName;
                goal._description = goalDetails;
                goal._points = goalPoints;
            }
            else if (loop == "2")
            {
                Console.WriteLine("Displaying current Goal:");
                goal.DisplayGoal();
                
            }
            else if (loop == "3")
            {
                Console.WriteLine("This feature currently does not work at this time.");
            }
            else if (loop == "4")
            {
                Console.WriteLine("This feature does not work at this time, check in on a future update, hahaha.");
            }
            else if (loop == "5")
            {
                Console.WriteLine("Thank you for using this Goal Management system, we hope you have a lovely day.");
            }
            else
            {
                Console.WriteLine("Input not valid, please try again.");
            }
        }
    }
}