using System;
using System.Collections.Generic;

class StationaryBike : Activity
{
    private double _speed;
    private static string _activityName = "Stationary Bike";

    public StationaryBike(int time, double speed) : base(time)
    {
        _speed = speed;
        // _distance = DistanceFromSpeed(speed);
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
        return CalculatePace(_speed);
    }

    protected override double CalculateSpeed()
    {
        return _speed;
    }

    protected override double GetDistance()
    {
        return DistanceFromPace(CalculatePace());
    }
}/*
StationaryBike
;Activity
_speed int

GetSummary() - ovr

03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
*/