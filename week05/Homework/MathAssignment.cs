using System;
using System.Collections.Generic;

class MathAssignment : Assignment
{
    private string _section;
    private List<String> _problems;

    public MathAssignment(string topic, string student, string section, List<String> problems) : base(student, topic)
    {
        _section = section;
        _problems = problems;
    }
    public MathAssignment(string topic, string student, string section, string problem) : base(student, topic)
    {
        List<String> lstr = new List<String>();
        lstr.Add(problem);
        _section = section;
        _problems = lstr;
    }
    public string GetProblems()
    {
        string res = "";
        foreach (string i in _problems)
        {
            res += i;
            res += "\n";
        }
        return res.Trim();
    }
    public void Print()
    {
        string sum = GetSummary();
        string probs = GetProblems();
        Console.WriteLine(sum);
        Console.WriteLine($"Section {_section}\nProblems:");
        Console.WriteLine(probs);
    }
}

/*
MathAssignment
;Assignment
_section string
_problems List<String>

constructor(topic st, student st, sections st, problems List<String>); base(topic, student)
constructor(topic st, student st, sections st, problem st); base(topic, student)
GetProblems() - string, returns _problems as a string
Print() - void, prints everything cleanly
*/