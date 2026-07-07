using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Resume resume = new Resume();
        resume._fName = "Bog";
        resume._lName = "Water";
        resume.Add("Harold","Wog Botter Inc",1943,1800);
        resume.Add("Boot Licker","Morgan & Morgan & Morgan & Morgan & Morgan Law",2000,2030);
        resume.Add("Milk Leerer","Milk People",2700);
        resume.Add("Billy Goats Impressionist","My Crow's Soft");
        resume.Print();
    }
}