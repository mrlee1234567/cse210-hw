using System;
using System.Collections.Generic;

class ReflectionActivity : ActivityList
{
    private List<String> _questions;
    static string _desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    static string _reflectionActivityName = "Reflection Activity";

    public ReflectionActivity(int duration, string[] prompts, string[] questions) : base(_reflectionActivityName, _desc, duration, prompts)
    {
        List<String> qs = new List<String>();
        foreach (string i in questions)
        {
            qs.Add(i);
        }
        _questions = qs;
    }

    public string GetRandomQuestion()
    {
        int position = _generator.Next(_questions.Count);
        return _questions[position];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    public void Run()
    {
        Console.WriteLine(StartingMsg());
        bool stillStanding = true;
        DisplayPrompt();
        DisplayQuestion();
        Console.Write("X");
        do
        {
            PauseAnimation(250);
            if (GetDuration() <= 0)
            {
                stillStanding = false;
            }
        } while (stillStanding);
        Erase();
        Console.WriteLine(EndingMsg());
    }
}

/*
ReflectionActivity
;Activity
_prompts List<String> X
_questions List<String> (not sure the diff)
_desc string static
_reflectionActivityName string static
_generator Random X

constructor(duration int?); base([reflection activity name],[ref actv desc],duration)
GetRandomPrompts() - string X
GetRandomQuestion() - string
DisplayPrompt() - void
DisplayQuestion() - void
Run() - void


reflection;
sample desc: This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.
select a random prompt
sample prompts:
    Think of a time when you stood up for someone else.
    Think of a time when you did something really difficult.
    Think of a time when you helped someone in need.
    Think of a time when you did something truly selfless.
from assignment: After displaying the prompt, the program should ask the user to reflect on questions that relate to this experience. These questions should be pulled from a list such as the following:
    Why was this experience meaningful to you?
    Have you ever done anything like this before?
    How did you get started?
    How did you feel when it was complete?
    What made this time different than other times when you were not as successful?
    What is your favorite thing about this experience?
    What could you learn from this experience that applies to other situations?
    What did you learn about yourself through this experience?
    How can you keep this experience in mind in the future?
pause between questions. while paused, show spinner (PauseAnimation)
continue until reaching duration specified by user
*/