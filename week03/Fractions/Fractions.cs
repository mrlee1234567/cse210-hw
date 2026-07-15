using System;

class Fractions
{
    static int _top;
    static int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public double GetDecimalValue()
    {
        double tp = _top;
        double bm = _bottom;
        double res = tp / bm;
        return res;
    }

    public double Inverted()
    {
        double tp = _top;
        double bm = _bottom;
        double res = bm / tp;
        return res;
    }

    public string GetFractionString()
    {
        string res = $"{_top}/{_bottom}";
        return res;
    }

    public string InvertedFraction()
    {
        string res = $"{_bottom}/{_top}";
        return res;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bot)
    {
        _bottom = bot;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

}