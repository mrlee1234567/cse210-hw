using System;
using System.Collections.Generic;

class EternalGoal : Goal
{
    private int _count;
    static string _typeIdent = "eternal";

    public EternalGoal(string name, string desc, int pointValue) : base(name, desc, pointValue)
    {
        _count = 0;
    }

    public EternalGoal(string serializedDat, string sep) : base(serializedDat, sep)
    {
        // 0-4 handled in base, 5 is _count
        string[] li = serializedDat.Split(sep);
        int ct = int.Parse(li[5]);
        _count = ct;
    }

    public override string GetObjectString(string sep)
    {
        string gos = base.GetObjectString(sep);
        string res = $"{_typeIdent}{sep}{gos}{sep}{_count}";
        return res;
    }

    protected override string TestCompletion()
    {
        if (!IsComplete())
        {
            return "∞";
        } else
        {
            return "!!!!!";
        }
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        _count++;
    }

    public override string GetGoal()
    {
        string res = base.GetGoal();
        res += $" (x{_count})";
        return res;
    }
}

/*
EternalGoal
;Goal
_count int

constructor(name st, desc st, pointValue int) : base(name,desc,pointValue)
GetGoal() - string, ovr, does all the same as usual, except it will show a different symbol (probably infinity or maybe ~) to show it cannot be completed, and also display the _count
GetObjectString() - string, ovr
IsComplete() - bool, ovr, always returns false (incase it is called)
RecordEvent() - void, ovr, increases _count by one
*/