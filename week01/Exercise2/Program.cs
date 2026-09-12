using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type in your grade ");
        string gradeText = Console.ReadLine();
        int grade = int.Parse(gradeText);
        int divisonRemainder = grade%10;
        string sign = "";
        if (grade >= 90)
        {
            gradeText = "A";           
        }
        else if (grade >= 80)
        {
            gradeText = "B+";
        }
        else if (grade >= 70)
        {
            gradeText = "C";
        }
        else if (grade >= 60)
        {
            gradeText = "D";
        }
        else
        {
            gradeText = "F";
        }

        if (divisonRemainder >= 7 && gradeText != "A")
        {
            sign = "+";
        }
        else if (divisonRemainder < 3 && gradeText != "F")
        {
            sign = "-";
        }

        Console.Write($"Your letter Grade is {gradeText}{sign}");
    }
}