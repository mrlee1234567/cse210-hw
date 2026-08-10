using System;
using System.Collections.Generic;

abstract class Activity
{
    protected int _time;
    // protected double _distance;

    public Activity(int time)
    {
        _time = time;
    }

    public abstract string GetSummary();

    protected double CalculateSpeed(int time, double distance)
    {
        double doubletime = time;
        double spd = (doubletime / distance) * 60;
        return spd;
    }

    protected double CalculateSpeed(double pace)
    {
        double spd = 60 / pace;
        return spd;
    }

    protected abstract double CalculateSpeed();

    protected double CalculatePace(int time, double distance)
    {
        double doubletime = time;
        double pce = doubletime / distance;
        return pce;
    }

    protected double CalculatePace(double speed)
    {
        double pce = 60 / speed;
        return pce;
    }

    protected abstract double CalculatePace();

    protected double DistanceFromPace(double pace)
    {
        double dfp = 1 / (pace / _time);
        return dfp;
    }

    protected double DistanceFromSpeed(double speed)
    {
        double de60spd = speed / 60;
        double dist = de60spd * _time;
        return dist;
    }

    protected string GetDate(){
        DateTime date = DateTime.Now;
        string res = $"{date.Day} {date.Month} {date.Year}";
        return res;
    }
}
/*
Activity
_time int pr

GetSummary() - string, abs/vir
CalculateSpeed(int time, double distance) - double pr
CalculatePace(int time double distance) - douple pr
CalculateSpeed(double pace) - double pr
CalculatePace(douvle speed) - double pr
*/