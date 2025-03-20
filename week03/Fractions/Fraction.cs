using System;
using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
    // default to 1/1
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionsString()
    {
        string text = $"{_top}/{bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double) _bottom;
        
    }





}