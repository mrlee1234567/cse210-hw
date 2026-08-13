using System;
using System.Collections.Generic;

class LapSwimming : Activity
{
    // private stati_poolLen = 50;
    private int _laps;
    private static string _activityName = "Lap Swimming";

    public LapSwimming(int time, int laps) : base(time)
    {
        _laps = laps;
    }

    protected override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    protected override string GetActivityType()
    {
        throw new NotImplementedException();
    }

    public override string GetSummary()
    {
        string res = base.GetSummary();
        res += $", Laps {_laps} laps";
        return res;
    }

    protected override double CalculatePace()
    {
        return CalculatePace(_time,GetDistance());
    }

    protected override double CalculateSpeed()
    {
        return CalculateSpeed(CalculatePace());
    }
}
/*
LapSwimming
;Activity
_poolLen int static (50 meters)
_laps int

PoolDistance(int laps) - double
GetSummary() - ovr


03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
*/