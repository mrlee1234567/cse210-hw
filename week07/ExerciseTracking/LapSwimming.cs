using System;
using System.Collections.Generic;

class LapSwimming : Activity
{
    // private stati_poolLen = 50;
    private int _laps;

    public LapSwimming(int time, int laps) : base(time)
    {
        _laps = laps;
    }

    private double PoolDistance()
    {
        return (_laps * 50) / 1000;
    }

    public override string GetSummary()
    {
        string res;
        double distance = PoolDistance();
        double pace = CalculatePace();
        double speed = CalculateSpeed();
        res = $"{GetDate()} Lap Swimming ({_time} min): Distance {distance}km, Speed {speed}kph, Pace {pace}min/km, Laps {_laps} laps";
        return res;
    }

    protected override double CalculatePace()
    {
        return CalculatePace(_time,PoolDistance());
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