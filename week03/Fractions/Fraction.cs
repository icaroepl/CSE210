using System;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int number)
    {
        _top = number;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int number)
    {
        _bottom = number;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";  
        return text;
    }

    public double GetDecimalValue()
    {       
        double top = _top;
        double bottom = _bottom;

        double result = top/bottom;     
        return result;
        // return (double)_top / (double)_bottom;
        
    }


}