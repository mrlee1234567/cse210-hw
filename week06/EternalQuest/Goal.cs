using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _name;
    protected string _desc;
    protected int _value;
    protected bool _isComplete;

    public Goal(string name, string desc, int pointValue)
    {
        _name = name;
        _desc = desc;
        _value = pointValue;
        _isComplete = false;
    }

    public Goal(string serializedDat, string sep)
    {
        Deser(serializedDat,sep);
    }

    public virtual string GetGoal()
    {
        string res;
        string completeMarker = TestCompletion();
        res = $"[{completeMarker}] - {_name} ({_desc}) - {_value}";
        return res;
    }

    protected virtual string TestCompletion()
    {
        if (IsComplete())
        {
            return "X";
        } else
        {
            return " ";
        }
    }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }

    public virtual int GetPoints()
    {
        return _value;
    }

    public virtual void RecordEvent()
    {
        _isComplete = true;
    }

    public virtual string GetObjectString(string sep)
    {
        string ret = "";
        // string sep = "¤"; //im not copy pasting this every time i want to use it in this
        string tf;
        if (_isComplete)
        {
            tf = "t";
        } else
        {
            tf = "f";
        }
        ret += $"{_name}{sep}{_desc}{sep}{_value}{sep}{tf}";
        
        return ret;
    }

    private void Deser(string serst, string sep)
    {
        string[] li = serst.Split(sep);
        // 1-name 2-desc 3-value 4-complete
        string name = li[1];
        string desc = li[2];
        int value = int.Parse(li[3]);
        string tfraw = li[4];
        bool comp;
        if (tfraw == "t")
        {
            comp = true;
        } else
        {
            comp = false;
        }
        _name = name;
        _desc = desc;
        _value = value;
        _isComplete = comp;
    }
}
/*
Goal - abs
_name string pr
_desc string pr
_value int pr
_isComplete bool pr

constructor(name st, desc st, pointValue int)
GetGoal() - string, vir, (vir means virtual, which can be public) gets _name, _desc, _value, and checks if it is complete, and prints the results in a pleasing format
RecordEvent() - void, abs
GetObjectString() - string, abs, called "GetStringRepresentation" in the assignment, but thats too long for me (length must either be meaningful, necessary, or humerous), converts the object to a string to make saving easy, check the program assignment overview for details on how to
IsComplete() - bool, vir, by default returns _isComplete
*/