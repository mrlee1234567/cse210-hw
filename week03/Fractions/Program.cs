using System;

class Program
{
    // im used to print, so im making some print statements
    static void Print(string str)
    {
        Console.WriteLine(str);
    }

    static void Print(int output)
    {
        Console.WriteLine(output);
    }

    static void Print(float output)
    {
        Console.WriteLine(output);
    }

    static void Print(double output)
    {
        Console.WriteLine(output);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Print("no inp");
        Fractions frac = new Fractions();
        Print(frac.GetDecimalValue());
        Print(frac.GetFractionString());
        Print("only 3");
        frac = new Fractions(3);
        Print(frac.GetDecimalValue());
        Print(frac.GetFractionString());
        Print(frac.Inverted());
        Print(frac.InvertedFraction());
        Print("3,5");
        frac = new Fractions(3,5);
        Print(frac.GetDecimalValue());
        Print(frac.GetFractionString());
    }
}