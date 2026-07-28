using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        List<String> problems = new List<String>();
        problems.Add("8-10");
        problems.Add("1-64");
        problems.Add("7-10.4");

        MathAssignment ma1 = new MathAssignment("Quantum Physics","Robb","4",problems);
        MathAssignment ma2 = new MathAssignment("Algembra","Holdt","3A","5");
        
        WritingAssignment wa1 = new WritingAssignment("Post WWII History","Georg","How The World Wars Caused the Modern World");
        WritingAssignment wa2 = new WritingAssignment("Bronze Age Politics, China","Stan","How the Bronze Age Collapse Affected Ancient China"); //it really didnt, it was highly localized to the mediterranian

        ma1.Print();
        ma2.Print();

        wa1.Print();
        wa2.Print();
    }
}

/* 

classes

Assignment
_student string pr
_topic string pr

constructor(topic st, student st)
GetSummary() - string, returns _topic and _student as one thing


MathAssignment
;Assignment
_section string
_problems List<String>

constructor(topic st, student st, sections st, problems List<String>); base(topic, student)
constructor(topic st, student st, sections st, problem st); base(topic, student)
GetProblems() - string, returns _problems as a string
Print() - void, prints everything cleanly


WritingAssignment
;Assignment
_title string

constructor(topic st, student st, title st); base(topic, student)
GetTitle() - string
Print() - void, does the same as MathAssignment's print


 */