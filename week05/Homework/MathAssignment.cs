using System;
using System.Runtime.CompilerServices;

public class MathAssignment : Assignment
{
  private string _textbookSection;
  private string _problems;

  public void SetTextbookSection(string input)
    {
        _textbookSection = input;
    } 
    public void SetProblems(string input)
    {
        _problems = input;
    }
    public string GetHomeworkList()
    {
        return ($"{_textbookSection} - {_problems}");
    }
}
