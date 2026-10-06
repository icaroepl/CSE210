using System;
using System.Runtime.CompilerServices;

public class WritingAssignment : Assignment
{

    private string _title;

    public void SetTitle(string input)
    {
        _title = input;
    }

    public string GetWritingInformation()
    {
        return ($"{_title}");
    }
}
