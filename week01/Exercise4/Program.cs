using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 99;
        int sum = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter a number ");
            string numberText = Console.ReadLine();
            number = int.Parse(numberText);
            if (number != 0) {
                sum += number;
                numbers.Add(number);
                if (number > largest)
                {
                    largest = number;
                }
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/numbers.Count}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}