using System;
using System.Collections.Generic;

class Square : Shape
{
    private double _side;
    
    public Square(double side, string color)
    {
        _color = color;
        _side = side;
    }

    public override double GetArea()
    {
        return Math.Pow(_side,2);
    }

    public override void Print()
    {
        base.Print("square", GetColor(), GetArea());
    }
}

/*
Square
;Shape
_side - double

GetArea() - double
*/