using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        string loop = "";
        string firstVariableString = "";
        string secondVariableString = "";
        Triangle triangle = new Triangle();
        Rectangle rectangle = new Rectangle();
        Circle circle = new Circle();

        while (loop != "4")
        {
            Console.WriteLine("Please enter the number of which formmula you wish to use.");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Quit");
            loop = Console.ReadLine();
            if (loop == "1")
            {
               Console.WriteLine("You have selected the triangle formula."); 
               Console.WriteLine("What is the base of the triangle?");
               firstVariableString = Console.ReadLine(); 
               Console.WriteLine("What is the Height of the triangle?"); 
               secondVariableString = Console.ReadLine();
               triangle.Equation(firstVariableString, secondVariableString);
               triangle.DisplayResult();
            }
            else if (loop == "2")
            {
                Console.WriteLine("You have selected the rectangle formula?");
                Console.WriteLine("What is the length of the Rectangle?");
                firstVariableString = Console.ReadLine();
                Console.WriteLine("What is the width of the Rectangle");
                secondVariableString = Console.ReadLine();
                rectangle.Equation(firstVariableString, secondVariableString);
                rectangle.DisplayResult();

            }
            else if (loop == "3")
            {
                Console.WriteLine("You have selected the circle formula?");
                Console.WriteLine("What is the radius of the circle?");
                firstVariableString = Console.ReadLine();
                circle.Equation(firstVariableString);
                circle.DisplayResult();
            }
            else if (loop == "4")
            {
                Console.WriteLine("You have chosen to quit, goodbye.");
            }
            else
            {
                Console.WriteLine("Unknown entry, please try again.");
            }
        }
    }
}