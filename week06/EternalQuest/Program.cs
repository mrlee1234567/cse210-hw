// added a fourth "staged goals" class, which works as a more complex checklist, with each check being either a smaller simple goal or a smaller checklist goal. Also done is using virtuals in the goal class, to make my job a little easier when it comes to programming
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager gm = new GoalManager();
        gm.Start();
    }
}

/*
provide simple goeals that can be completed to gain some value, eg run marathon - 1000 points
provide goals that are never complete, but each time they are recorded, used gains some value, eg every time you tead scriptures, 100 points
provide a checklist goal that must be accomplished a certain amount of times, eg, go to the temple 10 times. each time it is checked is 50 points, on the 10th, it is 500
display user's score
allow user to create goal of any type
allow user to record an event (meaning they accomplished a goal and must therefore recieve points)
Show a list of the goals. This list should show indicate whether the goal has been completed or not (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal has been completed (for example Completed 2/5 times).
allow goals and score to be saved and loaded (!)
MUST ALSO:
Use inheritance by having a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
Use polymorphism by having derived classes override base class methods where appropriate.
Follow the principles of encapsulation and abstraction by having private member variables and putting related items in the same class.
also show creativiyt. the assignment gives the following inspirations:
Add your own ideas for gamification. This could include leveling up, earning certain bonuses, or other "fun" aspects to the quest.
Add additional kinds of goals, such as the ability to make progress towards a large goal (such as getting value for working towards running a marathon), or "negative goals" where they lose points for bad habits.
There are lots of ways to show creativity in this assignment. Pick anything that sounds fun to you!

classes:
Goal - abs
_name string pr
_desc string pr
_value int pr
_isComplete bool pr

constructor(name st, desc st, pointValue int)
GetGoal() - string, vir, (vir means virtual, which can be public) gets _name, _desc, _value, and checks if it is complete, and prints the results in a pleasing format
RecordEvent() - void, abs
GetObjectString() - string, abs, called "GetStringRepresentation" in the assignment, but thats too long for me (length must either be meaningful, necessary, or humerous), converts the object to a string to make saving easy, check the program assignment overview for details on how to
IsComplete() - bool, vir, by default returns _isComplete

SimpleGoal
;Goal

constructor(name st, desc st, pointValue int) : base(name,desc,pointValue)
RecordEvent() - void, ovr (ovr means override), simply sets _isComplete to true
GetObjectString() - string, ovr

EternalGoal
;Goal
_count int

constructor(name st, desc st, pointValue int) : base(name,desc,pointValue)
GetGoal() - string, ovr, does all the same as usual, except it will show a different symbol (probably infinity or maybe ~) to show it cannot be completed, and also display the _count
GetObjectString() - string, ovr
IsComplete() - bool, ovr, always returns false (incase it is called)
RecordEvent() - void, ovr, increases _count by one

ChecklistGoal
;Goal
_currentCount int
_maxCount int
_finalBonus int

constructor(name st, desc st, pointValue int, finalBonus int, target int) : base(name,desc,pointValue)
GetGoal() - string, ovr, does all the same, except it also appends the amount compleated out of the amount needed and the _finalBonus
GetObjectString() - string, ovr
IsComplete() - bool, ovr, checks first if _currentCount == _maxCount, then sets to true or false based on that
RecordEvent() - void, ovr, increases _currentCount by one, checks if elligiable for _finalBonus

GoalManager
_goals List<Goal>
_score int

constructor()
Save() - void, saves all _goals into a file
Load() - void, loads all Goals into _goals from a file
Start() - void, runs all other functuins
ListGoals() - void, runs and prints GetGoal() in each of _goals, combination of ListGoalNames and ListGoalDetails from the assignment description
CreateGoal() - void, creates a new Goal
RecordGoal() - void, prompts user and runs RecordEvent in the selected Goal

*/