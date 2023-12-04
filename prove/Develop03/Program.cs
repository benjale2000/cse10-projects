using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        int loop = 0;

        while (loop != 2) 
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Memorize verse.");
            Console.WriteLine("2. Quit.");
            Console.WriteLine("pick a number between these and enter it.");
            string loopString = Console.ReadLine();
            loop = int.Parse(loopString);

            if (loop == 1)
            {
                //stuff for verse things go here.
                //To save time will only display verse and stuff.
                Word words = new Word();

                while (loop == 1)
                {
                    Console.WriteLine("5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.");
                }
                
            }

            else if (loop == 2)
            {
                Console.WriteLine("Ok, Goodbye.");
            }

            else
            {
                Console.WriteLine("Invalid input, please try again");
                loopString = Console.ReadLine();
                loop = int.Parse(loopString);
            }

        }
    }
}