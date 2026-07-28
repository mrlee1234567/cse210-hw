using System;
using System.Collections.Generic;

class Assignment
{
    protected string _student;
    protected string _topic;

    public Assignment(string student, string topic)
    {
        _student = student;
        _topic = topic;
    }

    public string GetSummary()
    {
        string ret = $"{_student} - {_topic}";
        return ret;
    }
}

/*
Assignment
_student string pr
_topic string pr

constructor(topic st, student st)
GetSummary() - string, returns _topic and _student as one thing

*/