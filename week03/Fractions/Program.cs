using System;
using System.IO.Pipelines;

class Program
{
    private int _top;
    private int _bottom;    
     static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1,2);
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        f1.SetTop (3);
        f1.SetBottom(2);
        string result = f1.GetFractionString();

        Console.Write($"{result}");
    }
}

