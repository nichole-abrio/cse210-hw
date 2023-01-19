using System;

public class Fraction{
    private int _topnumber;
    private int _bottomnumber;

    public Fraction()
    {
        _topnumber = 1;
        _bottomnumber = 1;
    }

    public Fraction(int wholenumber)
    {
        _topnumber = wholenumber;
        _bottomnumber = 1;
    }

    public Fraction(int numbertop, int numberbottom)
    {
        _topnumber = numbertop;
        _bottomnumber = numberbottom;
    }

    public string GetFractionString()
    {
        string text = $"{_topnumber}/{_bottomnumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topnumber/(double)_bottomnumber;
    }
}