using System;

class Comment
{
    public string _name;
    public string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName()
    {
        string name = _name;
        return name;
    }

       public string GetText()
    {
        string text = _text;
        return text;
    }

}