using System;
using System.Diagnostics.Tracing;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        
        List<string> prompts = new List<string> {"Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", "How did I see the had of the Lord in my life today", 
        "What was the strongest emotion I felt today", "If I had one this I could do over today, what would it be?", 
        "What is something I am grateful for today?", "Did I experience a challenge today?", 
        "Have I overcome any challenges today?", "Did I make someone smile today?"};

        Random randomGenerator = new Random();
        Entry e1 = new Entry();
        string fileName = "Journal.txt";

        string optionSelected = "0";
        while (optionSelected != "5")
        {
            Console.WriteLine("Welcome to your journal, please select what you would like to do:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please type in the number according to what you want to do: ");
            optionSelected = Console.ReadLine();

            if (optionSelected == "1")
            {
                Console.WriteLine("You have chosen to write an entry");
                int listNumber = prompts.Count;
                int indexNumber = randomGenerator.Next(0, listNumber);
                string prompt = prompts[indexNumber];
                Console.WriteLine(prompt);
                string writtenEntry = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                e1._date = dateText;
                e1._promptText = prompt;
                e1._entryText = writtenEntry;
                
                
            }
            else if (optionSelected == "2")
            {
                Console.WriteLine("You have chosen to display the entry");
                e1.Display();
            }
            else if (optionSelected == "3")
            {
                Console.WriteLine("You have chosen to load an entry, loading...");
                 string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("~");

                    Entry entryLoaded = new Entry();
                    entryLoaded._date = parts[0];
                    entryLoaded._promptText = parts[1];
                    entryLoaded._entryText = parts[2];

                    Console.WriteLine(entryLoaded);
                }
            }
            else if (optionSelected == "4")
            {
                Console.WriteLine("You have chosen to save the entry, saving...");
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine($"{e1._date}~{e1._promptText}~{e1._entryText}");
                }
            }
            else if (optionSelected == "5")
            {
                Console.WriteLine("You have chosen to quit, Goodbye.");
            }
            else
            {
                Console.WriteLine ("Error, option not found, please try again.");
            }
        }
    }
}