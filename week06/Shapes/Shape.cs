using System;
using System.Collections.Generic;

public abstract class Shape
{
    protected string _color;

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();

    protected void Print(string shape, string color, double area)
    {
        Console.WriteLine($"This {color} {shape} is {area}u^3");
    }

    public virtual void Print()
    {
        Print("noshape", "nocolor", 0);
    }
}
/*
classes
Shape - abs
_color string

GetColor() - string
SetColor(color st) - void
GetArea() - double - abs
*/