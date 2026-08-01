using System;
using System.Collections.Generic;

class BreathingActivity : Activity
{
    static string _desc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    static string _breathingActivityName = "Breathing Activity";

    public BreathingActivity(int duration) : base(_breathingActivityName, _desc, duration)
    {
        
    }

    public void Run()
    {
        List<int> ints = new List<int>();
        int cd = _duration;
        int dlen = 3;
        bool evn = true;
        if ((cd % 2) == 1)
        {
            evn = false;
            cd -= 1;
        }
        do
        {
            if (cd - (dlen * 2) <= 0)
            {
                ints.Add(cd / 2);
                cd = cd / 2;
                if (!evn)
                {
                    cd++;
                }
                ints.Add(cd);
                dlen = 0;
                cd = -1;
            }
            else
            {
                ints.Add(dlen);
                cd -= dlen;
                ints.Add(dlen);
                cd -= dlen;
                dlen++;
            }
        } while (cd > 0);
        Console.WriteLine(StartingMsg());

        foreach (int i in ints)
        {
            int iq = i;
            Console.WriteLine("Breathe in... ");
            do
            {
                
                iq = PauseAnimation(1000,iq);
            } while (iq != 0);
            iq = i;
            Erase();
            Console.WriteLine("Breathe out...  ");
            do
            {
                
                iq = PauseAnimation(1000, iq);
            } while (iq != 0);
            Erase();
        }
        Console.WriteLine(EndingMsg());
    }
}

/*
BreathingActivity
;Activity
_desc string static, universal description
_breathingActivityName string static, universal name

constructor(duration int?); base([breathing activity name],[brth actv desc],duration)
Run() - void


breathing;
sample desc: This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.
series of "breathe in" "breathe out" texts displayed after starting msg
continues until reaches duration specializd by user
*/