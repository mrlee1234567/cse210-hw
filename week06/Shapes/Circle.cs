using System;
using System.Collections.Generic;

class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color)
    {
        _color = color;
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius,2);
    }

    public override void Print()
    {
        base.Print("circle", GetColor(), GetArea());
    }
}

/*
Circle
;Shape
_radius - double

GetArea() - double
*/