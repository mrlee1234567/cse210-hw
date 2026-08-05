using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        double inversePi = Math.Sqrt( 1 / Math.PI );
        List<Shape> shps = new List<Shape>();
        Square sq = new Square(5,"red");
        Square sq2 = new Square(10,"green");

        Rectangle rt = new Rectangle(5,10,"yellow");
        Rectangle rt2 = new Rectangle(23,3,"eigengrau");

        Circle cr = new Circle(8,"cyan");
        Circle cr2 = new Circle(10.5,"Pantone 448 C \"opaque couché\"");

        Circle iPi = new Circle(inversePi,"Inverted Pi colored");

        shps.Add(sq);
        shps.Add(sq2);
        shps.Add(rt);
        shps.Add(rt2);
        shps.Add(cr);
        shps.Add(cr2);
        shps.Add(iPi);
        foreach (Shape i in shps)
        {
            Console.WriteLine();
            i.Print();
        }
    }
}

/*
classes
Shape - abs
_color string

GetColor() - string
SetColor(color st) - void
GetArea() - double - abs

Square
;Shape
_side - double

GetArea() - double

Rectangle
;Shape
_length - double
_width - double

GetArea() - double

Circle
;Shape
_radius - double

GetArea() - double
*/