using System;
using System.Collections.Generic;

class SimpleGoal : Goal
{
    static string _typeIdent = "simple";
    public SimpleGoal(string name, string desc, int pointValue) : base(name, desc, pointValue)
    {
        
    }

    public SimpleGoal(string serializedDat, string sep) : base(serializedDat, sep)
    {
        
    }

    public override string GetObjectString(string sep)
    {
        string res = base.GetObjectString(sep);
        return $"{_typeIdent}{sep}{res}";
    }
}

/*
SimpleGoal
;Goal

constructor(name st, desc st, pointValue int) : base(name,desc,pointValue)
RecordEvent() - void, ovr (ovr means override), simply sets _isComplete to true
GetObjectString() - string, ovr
*/