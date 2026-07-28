using System;
using System.Collections.Generic;

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string topic, string student, string title) : base(student, topic)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void Print()
    {
        string sum = GetSummary();
        string tile = $"Title: {GetTitle()}";
        Console.WriteLine(sum);
        Console.WriteLine(tile);
    }
}

/*
WritingAssignment
;Assignment
_title string

constructor(topic st, student st, title st); base(topic, student)
GetTitle() - string
Print() - void, does the same as MathAssignment's print
*/