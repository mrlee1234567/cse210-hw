using System;
using System.Collections.Generic;

class StagedGoal : Goal
{
    private static string _typeIdent = "staged";
    private List<Goal> _stages;
    private int _thisStage;
    private static string _altSeperator = "⨉";
    private int _simpleBonus;
    private int _checklistBonus;
    private int _stageCount;
    private bool _recorded; // this is to track if it this goal has been recorded

    public StagedGoal(string name, string desc, int pointValue, int simplePV, int checkedPV, int stages) : base(name, desc, pointValue)
    {
        _stages = new List<Goal>();
        _simpleBonus = simplePV;
        _checklistBonus = checkedPV;
        _stageCount = stages;
        _thisStage = 0;
        _recorded = false;

        for (int i = 0; i < _stageCount; i++)
        {
            Console.Clear();
            Console.WriteLine("What type goal is this stage?\n\n    1. Simple\n    2. Checklist");
            string sgtyp = Console.ReadLine();
            Console.Clear();
            Goal toad;
            Console.WriteLine($"What is the goal of stage {i + 1}?");
            string gnm = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"What is the description for stage {i + 1}?");
            string gds = Console.ReadLine();
            Console.Clear();
            if (sgtyp == "2")
            {
                Console.WriteLine("How many times do you want to repeat this task?");
                int clnm = int.Parse(Console.ReadLine());
                Console.Clear();
                toad = new ChecklistGoal(gnm,gds,_checklistBonus,_simpleBonus,clnm);
            } else
            {
                toad = new SimpleGoal(gnm,gds,_simpleBonus);
            }
            Console.Clear();
            _stages.Add(toad);
        }
    }

    public StagedGoal(string serializedDat, string sep) : base(serializedDat, sep)
    {
        string[] sepdSerDat = serializedDat.Split(_altSeperator);
        string[] stagol = sepdSerDat[0].Split(sep);
        // 0-4 handled in base, 5 _thisStage, 6 _stageCount, 7 _simpleBonus, 8 _checklistBonus
        _thisStage = int.Parse(stagol[5]);
        _stageCount = int.Parse(stagol[6]);
        _simpleBonus = int.Parse(stagol[7]);
        _checklistBonus = int.Parse(stagol[8]);
        _stages = new List<Goal>();
        for (int i = 1; i < sepdSerDat.Count(); i++)
        {
            string iq = sepdSerDat[i];
            string[] iqsp = iq.Split(sep);
            Goal gl;
            if (iqsp[0] == "checklist")
            {
                gl = new ChecklistGoal(iq,sep);
            } else
            {
                gl = new SimpleGoal(iq,sep);
            }
            _stages.Add(gl);
        }
        
    }
    public override string GetGoal()
    {
        
        string res;
        if (IsComplete())
        {
            return base.GetGoal();
        } else
        {
            Goal thisGoal = _stages[_thisStage];
            res = thisGoal.GetGoal();
            res += $" | {_name} ({_desc}) - {_value} ({_thisStage}/{_stageCount})";
            return res;
        }
    }

    public override bool IsComplete()
    {
        if (_thisStage >= _stageCount)
        {
            _isComplete = true;
        }
        return base.IsComplete();
    }

    public override int GetPoints()
    {
        if (IsComplete())
        {
            return base.GetPoints();
        }
        else
        {
            Goal thisGoal = _stages[_thisStage];
            if (_recorded)
            {
                _thisStage++;
                _recorded = false;
            }
            return thisGoal.GetPoints();
        }
    }

    public override void RecordEvent()
    {
        
        if (IsComplete())
        {
            base.RecordEvent();
        }
        if (_recorded)
        {
            _thisStage++;
            _recorded = false;
        } else
        {
            _recorded = true;
        }
    }


    public override string GetObjectString(string sep)
    {
        string gos = base.GetObjectString(sep);
        string sestag = "";
        foreach (Goal i in _stages)
        {
            sestag += $"{_altSeperator}{i.GetObjectString(sep)}";
        }
        // simple bonus, checklist bonus
        string res = $"{_typeIdent}{sep}{gos}{sep}{_thisStage}{sep}{_stageCount}{sep}{_simpleBonus}{sep}{_checklistBonus}{sestag}";
        return res;
    }
}



/*
creativity bonus
StagedGoal
_typeIdent string static
_stages List<Goal>
_thisStage int
_altSeperator string static
_simpleBonus int
_checklistBonus int
_stageCount int

constructor(name st, desc st, pointValue int, simplePV int, checkedPV int, stages int)
constructor(serializedDat st, sep se)
GetGoal() - string, ovr - gets the current goal then appends the overall goal
IsComplete() - bool, ovr, checks if the current stage is the maximum, if so, it is complete
GetPoints() - int, ovr, returns the points relevant to the current projection
RecordEvent() - void, ovr, records the current relevant event
GetObjectString(sep st) - string, ovr, gets the saving string, concats everything into one long line
*/