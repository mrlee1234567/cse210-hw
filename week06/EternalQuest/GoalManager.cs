using System;
using System.Collections.Generic;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private static string _seperator = "¤";

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    private void Save()
    {
        string savst = $"{_score}";
        foreach (Goal i in _goals)
        {
            savst += $"\n{i.GetObjectString(_seperator)}";
        }
        Console.WriteLine("What would you like to save your file as?");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(savst);
        }
        // StreamWriter writer = new StreamWriter(filename);
        Console.WriteLine("Save Complete!");
    }
    private void Load()
    {
        Console.WriteLine("Enter the save file you wish to load.");
        string filename = Console.ReadLine();
        string[] file = System.IO.File.ReadAllLines(filename);
        _goals = new List<Goal>();
        int nct = int.Parse(file[0]);
        _score = nct;
        foreach (string i in file)
        {
            if (i != file[0]){
            Goal logol;
            string otype = i.Split(_seperator)[0];
            if (otype == "simple")
            {
                logol = new SimpleGoal(i,_seperator);
            } else if (otype == "eternal")
            {
                logol = new EternalGoal(i,_seperator);
            } else if (otype == "checklist")
            {
                logol = new ChecklistGoal(i,_seperator);
            } else if (otype == "staged")
            {
                logol = new StagedGoal(i,_seperator);
            }
            else
            {
                logol = new SimpleGoal($"UNKNOWN {otype}","I DON'T KNOW WHAT TO DO WITH THAT INFO",-100000);
            }
            _goals.Add(logol);
            }
        }
        // cant do much atm, when wifi is back up, see how to save things as a string, then have the first one be the type, and build from there
        // in Goal.cs, add an overload constructor that takes one string, this one string is the data from the newly opened file, it will interpret the contents from there
        // the seperator i ¤
    }

    private void ListGoals()
    {
        Console.WriteLine("Here are the goals you currently have:\n");
        foreach (Goal i in _goals)
        {
            Console.WriteLine($"    {i.GetGoal()}");
        }
        Console.WriteLine("\nPress enter/return to continue.");
        Console.ReadLine();
    }

    private void CreateGoal()
    {
        Goal newGoal;
        Console.WriteLine("What type of goal do you wish to create?\n\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\n    4. Staged Goal\n");
        string sel = Console.ReadLine();
        if (sel != "1" && sel != "2" && sel != "3" && sel != "4")
        {
            Console.WriteLine($"Your selection of \"{sel}\" is not recognized. Please only enter 1, 2, 3, or 4.\n(Press enter/return to continue)");
            Console.ReadLine();
            return;
        }
        Console.Clear();
        Console.WriteLine("\nWhat is your goal?");
        string gnm = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\nWhat is the description of the goal?");
        string gnd = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\nHow many points is this goal worth?");
        int pts = int.Parse(Console.ReadLine());
        Console.Clear();
        if (sel == "1")
        {
            newGoal = new SimpleGoal(gnm,gnd,pts);
        } else if (sel == "2")
        {
            newGoal = new EternalGoal(gnm,gnd,pts);
        } else if (sel == "3")
        {
            Console.Clear();
            Console.WriteLine("\nHow many times do you want to do this goal?");
            int gotm = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"\nHow many points is goal {gotm} worth?");
            int gobn = int.Parse(Console.ReadLine());
            Console.Clear();
            newGoal = new ChecklistGoal(gnm,gnd,pts,gobn,gotm);
        }else if (sel == "4")
        {
            Console.Clear();
            Console.WriteLine($"\nHow many points do you want Simple Goals to be worth? (Ideally less than {pts})");
            int smgl = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"\nHow many points do you want Checklist Goals to be worth? (Ideally less than {smgl})");
            int clgl = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\nHow many stages do you want?");
            int stgs = int.Parse(Console.ReadLine());
            Console.Clear();
            newGoal = new StagedGoal(gnm,gnd,pts,smgl,clgl,stgs);
        }
        else
        {
            newGoal = new SimpleGoal("DUMMY","CONSUME NACHORITO",99999999);
        }
        Console.Clear();
        _goals.Add(newGoal);
        Console.WriteLine("\nAdded new goal to goals!\n(Press enter/return to continue)");
        Console.ReadLine();
    }

    private void RecordGoal()
    {
        Console.WriteLine("Enter the corresponding number of the goal you want to record\n");
        int numgoal = _goals.Count;
        for (int i = 0; i < numgoal; i++)
        {
            string iq = _goals[i].GetGoal();
            string wt = $"    {i + 1}. {iq}";
            Console.WriteLine(wt);
        }
        Console.WriteLine("\n(Type \"0\" to cancel)");
        bool isCont = false;
        bool isQuit = false;
        int selnum = 0;
        do
        {
            int sel = int.Parse(Console.ReadLine());
            if (sel > numgoal)
            {
                Console.WriteLine($"The selection {sel} is too large.\n");
            } else if (sel == 0)
            {
                isCont = true;
                isQuit = true;
            }
            else if (sel < 1)
            {
                Console.WriteLine($"The selection {sel} is too small.\n");
            } else
            {
                Console.Clear();
                selnum = sel - 1;
                Console.WriteLine($"\n{_goals[selnum].GetGoal()}\n\nAre you sure this is the selection you want? (y/n)\n");
                string conf = Console.ReadLine().ToLower();
                isCont = true;
                if (conf == "n")
                {
                    isQuit = true;
                }
            }
        } while (!isCont);
        Console.Clear();
        if (!isQuit)
        {
            if (!_goals[selnum].IsComplete())
            {
            _goals[selnum].RecordEvent();
            _score += _goals[selnum].GetPoints();
            Console.WriteLine("Recorded Your Event!");
            }
            else
            {
                Console.WriteLine("This goal is already complete");
            }
        }
        Console.WriteLine("Thank you for using!\n(Press enter/return to continue)");
        Console.ReadLine();

    }

    public void Start()
    {
        string sectn;
        do
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the Eternal Quest. Select an option from the menu\n");
            Console.WriteLine("    1. Record Goal\n    2. Create Goal\n    3. List Goals\n    4. Load From File\n    5. Save To File\n    6. Quit");
            Console.WriteLine($"(Score: {_score})");
            sectn = Console.ReadLine();
            Console.Clear();
            if (sectn == "1")
            {
                RecordGoal();
            } else if (sectn == "2")
            {
                CreateGoal();
            } else if (sectn == "3")
            {
                ListGoals();
            } else if (sectn == "4")
            {
                Load();
            } else if (sectn == "5")
            {
                Save();
            } else if (sectn == "6")
            {
                Console.WriteLine("Save before you go? (y/n)");
                string yn = Console.ReadLine().ToLower();
                if (yn == "y")
                {
                    Console.Clear();
                    Save();
                }
                Console.Clear();
                Console.WriteLine("Thank you for using!");
            } else
            {
                Console.WriteLine($"Selection {sectn} is not recognized (insert only 1-6)\n(Press enter/return to continue)");
                Console.ReadLine();
            }
        } while (sectn != "6");
        
    }
}

/*
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