using System;
using System.Collections.Generic;

class ChecklistGoal : Goal
{
    private int _currentCount;
    private int _maxCount;
    private int _finalBonus;
    static string _typeIdent = "checklist";

    public ChecklistGoal(string name, string desc, int pointValue, int finalBonus, int target) : base(name, desc, pointValue)
    {
        _currentCount = 0;
        _maxCount = target;
        _finalBonus = finalBonus;
    }

    public ChecklistGoal(string serializedDat, string sep) : base(serializedDat, sep)
    {
        // 0-4 handled in base, 5 is _currentCount, 6 is _maxCount, 7 is _finalBonus
        string[] li = serializedDat.Split(sep);
        int cc = int.Parse(li[5]);
        int mc = int.Parse(li[6]);
        int fb = int.Parse(li[7]);
        _currentCount = cc;
        _maxCount = mc;
        _finalBonus = fb;
    }

    public override string GetObjectString(string sep)
    {
        string gos = base.GetObjectString(sep);
        string res = $"{_typeIdent}{sep}{gos}{sep}{_currentCount}{sep}{_maxCount}{sep}{_finalBonus}";
        return res;
    }

    public override string GetGoal()
    {
        string ogoal = base.GetGoal();
        ogoal += $", {_finalBonus} completion bonus ({_currentCount}/{_maxCount})";
        return ogoal;
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            base.RecordEvent();
        } else
        {
            _currentCount++;
        }
    }

    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _finalBonus;
        }
        else
        {
            return base.GetPoints();
        }
    }

    public override bool IsComplete()
    {
        if (_currentCount >= _maxCount)
        {
            _isComplete = true;
        }
        return base.IsComplete();
    }
}

/*
ChecklistGoal
;Goal
_currentCount int
_maxCount int
_finalBonus int

constructor(name st, desc st, pointValue int, finalBonus int, target int) : base(name,desc,pointValue)
GetGoal() - string, ovr, does all the same, except it also appends the amount compleated out of the amount needed and the _finalBonus
GetObjectString() - string, ovr
IsComplete() - bool, ovr, checks first if _currentCount == _maxCount, then sets to true or false based on that
RecordEvent() - void, ovr, increases _currentCount by one, checks if elligiable for _finalBonus
*/