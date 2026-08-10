using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();
        Running rn = new Running(30, 100);
        StationaryBike sb = new StationaryBike(120, 20);
        LapSwimming ls = new LapSwimming(90, 40);
        activities.Add(rn);
        activities.Add(sb);
        activities.Add(ls);
        rn = new Running(200,1000);
        sb = new StationaryBike(89,30);
        ls = new LapSwimming(20,60);
        activities.Add(rn);
        activities.Add(sb);
        activities.Add(ls);
        foreach (Activity i in activities)
        {
            Console.WriteLine();
            Console.WriteLine(i.GetSummary());
        }
        Console.WriteLine("\nEnd");
    }
}

/*
activites:
running
stationary bikes
lap swimming

track in each:
length of activity (minutes)
track in indiviual activiries:
running; distance
cycling; speed
swimming; #laps

each activity wants the following returned, but not stored necessarily (calculated if necessary):
distance
speed (kilometers/hour)
pace (minutes/mile or kilomiter)
summary in the folloeing form:
03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km

YOU MAY CHOOSE MILES OR KILOMITERS, YOU CAN DO BOTH, BOTH IS NOT REQUIRED. EITHER WAY, THE POOL LENGTH IS 50 METERS

classes
Activity
_time int pr

GetSummary() - string, abs/vir
CalculateSpeed(int time, double distance) - double pr
CalculatePace(int time double distance) - douple pr
CalculateSpeed(double pace) - double pr
CalculatePace(douvle speed) - double pr

Running
;Activity
_distance int

GetSummary() - ovr

StationaryBike
;Activity
_speed int

GetSummary() - ovr

LapSwimming
;Activity
_poolLen double
_laps int

PoolDistance(double laps) - double
GetSummary() - ovr

*/