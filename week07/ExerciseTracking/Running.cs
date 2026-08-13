using System;
using System.Collections.Generic;

class Running : Activity
{
    private double _distance;
    private static string _activityName = "Running";

    public Running(int time, double distance) : base(time)
    {
        _distance = distance;
    }

    protected override string GetActivityType()
    {
        return _activityName;
    }

    public override string GetSummary()
    {
        string res = base.GetSummary();
        return res;
    }

    protected override double CalculatePace()
    {
        return CalculatePace(_time,_distance);
    }
    protected override double CalculateSpeed()
    {
        return CalculateSpeed(_time,_distance);
    }

    protected override double GetDistance()
    {
        return _distance;
    }
}
/*
Running
;Activity
_distance int

GetSummary() - ovr

03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
*/