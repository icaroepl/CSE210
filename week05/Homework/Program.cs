using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment();
        assignment.SetName("Samuel Bennett");
        assignment.SetTopic("Multiplication");
        string summary1 = assignment.GetSummary();
        Console.WriteLine($"{summary1}");

        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.SetName("Roberto Rodriguez");
        mathAssignment.SetTopic("Fractions");
        mathAssignment.SetTextbookSection("Section 7.3");
        mathAssignment.SetProblems("Problems 8-19");
        string summary2 = mathAssignment.GetSummary();
        string homeWorkList = mathAssignment.GetHomeworkList(); 
        Console.WriteLine($"{summary2}"); 
        Console.WriteLine($"{homeWorkList}");

        WritingAssignment wrtingAssignment = new WritingAssignment();
        wrtingAssignment.SetName("Mary Waters");
        wrtingAssignment.SetTopic("European History");
        wrtingAssignment.SetTitle("The Causes of World War II by Mary Waters");
        string summary3 = wrtingAssignment.GetSummary();
        string writingInformation = wrtingAssignment.GetWritingInformation(); 
        Console.WriteLine($"{summary3}"); 
        Console.WriteLine($"{writingInformation}");

    }
}