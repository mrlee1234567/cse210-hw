using System;
using System.Collections.Generic;

class ActivityList : Activity
{
    protected List<String> _prompts;
    protected Random _generator;
    private DateTime _startTime;
    private DateTime _endTime;

    public ActivityList(string name, string desc, int duration, List<String> prompts) : base(name,desc,duration)
    {
        _prompts = prompts;
        DateTime now = DateTime.Now;
        int seed = now.Year + now.Hour + now.Second + now.Microsecond + now.Minute + duration + now.Millisecond + now.Month;
        _generator = new Random(seed);
        _startTime = now;
        double dur = duration;
        _endTime = now.AddSeconds(dur);
    }

    public ActivityList(string name, string desc, int duration, string[] prompts) : base(name, desc, duration)
    {
        List<String> prList = new List<String>();
        foreach (string i in prompts)
        {
            prList.Add(i);
        }
        _prompts = prList;
        DateTime now = DateTime.Now;
        int seed = now.Year + now.Hour + now.Second + now.Microsecond + now.Minute + duration + now.Millisecond + now.Month;
        _generator = new Random(seed);
        _startTime = now;
        
        _endTime = now.AddSeconds(duration);
    }

    public string GetRandomPrompt()
    {
        int position = _generator.Next(_prompts.Count);
        return _prompts[position];
    }

    public int GetDuration()
    {
        int res;
        DateTime nuh = DateTime.Now;
        TimeSpan dif = _endTime - nuh;
        int difSecs = dif.Seconds;
        res = difSecs;
        // Console.WriteLine(res);
        // Console.WriteLine(_duration);
        // Console.WriteLine(nuh);
        // Console.WriteLine(_endTime);
        // Console.WriteLine(_startTime);
        if (res < 0)
        {
            res = 0;
        }
        return res;
    }
}

/*
shared - 
_prompts, list str
_generator, random
GetRandomPrompt, string

ListeningActivity
;Activity
_prompts List<String>
_count int
_generator Random
_desc string static
_listeningActivityName string static

constructor(duration int?); base([listening activity name],[listening activity description],duration)
GetRandomPrompt() - string
GetListFromUser() - List<String>(?)
Run() - void, not sure what this will do tbh

ReflectionActivity
;Activity
_prompts List<String>
_questions List<String> (not sure the diff)
_desc string static
_reflectionActivityName string static
_generator Random

constructor(duration int?); base([reflection activity name],[ref actv desc],duration)
GetRandomPrompts() - string
GetRandomQuestion() - string
DisplayPrompt() - void
DisplayQuestion() - void
Run() - void
*/