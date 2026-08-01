using System;
using System.Collections.Generic;

class ListeningActivity : ActivityList
{
    private int _count;
    static string _desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    static string _listeningActivityName = "Listing Activity";
    // i thought it said listening in the assignment so every reference calls this listening

    public ListeningActivity(int duration, string[] prompts) : base(_listeningActivityName, _desc, duration, prompts)
    {
        _count = 0;
    }

    public List<String> GetListFromUser()
    {
        List<String> qs = new List<String>();
        bool stillStanding = true;
        string ins;
        do
        {
            
            Console.Write("> ");
            ins = Console.ReadLine();
            qs.Add(ins);
            _count++;
            if (GetDuration() == 0)
            {
                stillStanding = false;
            }
        } while (stillStanding);
        return qs;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Think for a moment");
        Console.Write("X");
        for (int i = 0; i < 12; i++)
        {
            PauseAnimation(250);
        }
        Erase();
    }

    public void Run()
    {
        Console.WriteLine(StartingMsg());
        DisplayPrompt();
        List<String> gesso = GetListFromUser();
        Console.WriteLine($"You answered with {_count} response(s).");
        foreach (string i in gesso)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(EndingMsg());
    }
}

/*
ListeningActivity
;Activity
_prompts List<String> X
_count int
_generator Random X
_desc string static
_listeningActivityName string static

constructor(duration int?); base([listening activity name],[listening activity description],duration)
GetRandomPrompt() - string X
GetListFromUser() - List<String>(?)
Run() - void, not sure what this will do tbh


listening;
sample desc: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.
select a random prompt
sample prompts:
    Who are people that you appreciate?
    What are personal strengths of yours?
    Who are people that you have helped this week?
    When have you felt the Holy Ghost this month?
    Who are some of your personal heroes?
after display, the program waits a few seconds to think abt prompt
user lists as many items until specified duration reached
activity then displays back number of items entered
*/