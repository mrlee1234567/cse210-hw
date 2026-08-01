// added an intermediate class for listening and reflection activities and the ability to add additional prompts via text documents
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Menu mu = new Menu();
        mu.MainMenu();
    }
}

/*

functions:
basic delay
menu w user activity
each activity has starting msg comprsd of name of actifity and desc
asks for and sets duration of activity in secs then tells user to prepare to bgn and pause for several secs
breathing actv, reflactn actv, listngactiv
end w common ending message
when paused, do an animation

breathing;
sample desc: This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.
series of "breathe in" "breathe out" texts displayed after starting msg
continues until reaches duration specializd by user

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


classes:

Menu
tktk

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

shared - 
_prompts, list str
_generator, random
GetRandomPrompt, string

ListeningActivity
;Activity
_prompts List<String>
_count int
_generator Random
_desc string static
_listeningActivityName string static

constructor(duration int?); base([listening activity name],[listening activity description],duration)
GetRandomPrompt() - string
GetListFromUser() - List<String>(?)
Run() - void, not sure what this will do tbh

ReflectionActivity
;Activity
_prompts List<String>
_questions List<String> (not sure the diff)
_desc string static
_reflectionActivityName string static
_generator Random

constructor(duration int?); base([reflection activity name],[ref actv desc],duration)
GetRandomPrompts() - string
GetRandomQuestion() - string
DisplayPrompt() - void
DisplayQuestion() - void
Run() - void

BreathingActivity
;Activity
_desc string static, universal description
_breathingActivityName string static, universal name

constructor(duration int?); base([breathing activity name],[brth actv desc],duration)
Run() - void

*/