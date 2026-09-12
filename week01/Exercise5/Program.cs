using System;

class Program
{
    static string name ="";
    static int number;
    static int squareNumber;
    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        SquareNumber();
        DisplayResult();
    }

    static void DisplayWelcome()
    {
         Console.WriteLine("Welcome to the program!");
    }

    static void PromptUserName()
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
    }

    static void PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberText = Console.ReadLine();
        number = int.Parse(numberText);
    }
        
    static void SquareNumber()
    {
        squareNumber = number * number;
    }

    static void DisplayResult()
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }
}