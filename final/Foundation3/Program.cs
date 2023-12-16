using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Employee employ = new Employee();
        Salary salary = new Salary();
        FullTime fullTime = new FullTime();
        PartTime partTime = new PartTime();

        string loop = "";

        while (loop != "3")
        {
            Console.WriteLine("Please select what you would like to do:");
            Console.WriteLine("1. Fill in employee information.");
            Console.WriteLine("2. Display payment amount.");
            Console.WriteLine("3. Quit.");
            loop = Console.ReadLine();
            if (loop == "1")
            {
                Console.WriteLine("What is their name?");
                employ._name = Console.ReadLine();
                Console.WriteLine("What is their position?");
                employ._position = Console.ReadLine();
                Console.WriteLine("What is their emploment type? S for salary, F for full time, P for part time.");
                employ._employmentType = Console.ReadLine();
                Console.WriteLine("What is the time they spent working for these two weeks?");
                string timeString = Console.ReadLine();
                employ._timeWorked = int.Parse(timeString);
            }
            else if (loop == "2")
            {
                employ.DisplayEmployee();
                if (employ._employmentType == "S")
                {
                    salary.DisplayPayment();
                }
                else if (employ._employmentType == "F")
                {
                    fullTime.DisplayPayment(employ._timeWorked);
                }
                else if (employ._employmentType == "P")
                {
                    partTime.DisplayPayment(employ._timeWorked);
                }
                else
                {
                    Console.WriteLine("Unknown employment type, please tey again");
                }
            }
            else if (loop == "3")
            {
                Console.WriteLine("Thank you, Have a lovely day!");
            }
            else
            {
                Console.WriteLine("Unknown input, please try again.");
            }
        }
    }
}