using System;
using System.Collections.Generic;

class Activity
{
    private string _startingMsg;
    protected string _activityName;
    protected string _activityDesc;
    protected int _duration;
    private string _endingMsg;
    private int _animLoc;
    

    public Activity(string name, string desc, int duration)
    {
        _duration = duration;
        _activityName = name;
        _activityDesc = desc;
        
        _startingMsg = $"Welcome to the {name}\n\n{desc}";
        _animLoc = 0;
        _endingMsg = $"You have completed another {duration} seconds of the {name}.";
    }

    

    public string StartingMsg()
    {
        return $"{_startingMsg}\n\nHow long, in seconds, would you like your session?";
    }

    public void Erase()
    {
        Console.Write("\b \b");
    }

    public void AnimationIncrement()
    {
        _animLoc = (_animLoc + 1) % 4;
        string animChar;
        if (_animLoc == 0)
        {
            animChar = "[";
        }else if (_animLoc == 1 || _animLoc == 3)
        {
            animChar = "|";
        }else if (_animLoc == 2)
        {
            animChar = "]";
        }
        else
        {
            animChar = "###";
        }
        Erase();
        Console.Write(animChar);
    }

    public void AnimationIncrement(int countdown)
    {
        Erase();
        Console.Write(countdown);
    }

    public string EndingMsg()
    {
        return $"{_endingMsg}\n\nWell Done!";
    }

    public int PauseAnimation(int pTime, int countdown)
    {
        AnimationIncrement(countdown);
        Thread.Sleep(pTime);
        return countdown - 1;
    }

    public void PauseAnimation(int pTime)
    {
        AnimationIncrement();
        Thread.Sleep(pTime);
    }

    public void Wait(int secs)
    {
        for (int i = 0; i < (secs * 4); i++)
        {
            PauseAnimation(250);
        }
    }
}

/*
Activity
_startingMsg string
_activityName string pr
_activityDesc string pr
_duration int? pr
_endingMsg string

constructor(name st, desc st, duration int?)
GetDuration() - int?
StartingMsg() - string, combines the name and desc variables in a way the video descripes / shows
PauseAnimation() - void
CountdownAnimation() - void
EndingMsg() - string, returns _endingMsg


basic delay
menu w user activity
each activity has starting msg comprsd of name of actifity and desc
asks for and sets duration of activity in secs then tells user to prepare to bgn and pause for several secs
breathing actv, reflactn actv, listngactiv
end w common ending message
when paused, do an animation
*/