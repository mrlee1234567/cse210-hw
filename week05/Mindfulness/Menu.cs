using System;
using System.Collections.Generic;
// System.IO.File.ReadAllLines(X)
class Menu
{
    static string _listeningPrompts = "listening_prompts.txt";
    static string _reflectionPrompts = "reflection_prompts.txt";
    static string _reflectionQuestions = "reflection_questions.txt";
    

    public string[] OpenFile(string file)
    {
        string[] ret = System.IO.File.ReadAllLines(file);
        return ret;
    }

    public void RunBreathing(int duration)
    {
        BreathingActivity ba = new BreathingActivity(duration);
        ba.Run();
        ba.Wait(2);
    }

    public void RunReflection(int duration)
    {
        string[] fileprdat = OpenFile(_reflectionPrompts);
        string[] filequdat = OpenFile(_reflectionQuestions);
        ReflectionActivity ra = new ReflectionActivity(duration,fileprdat,filequdat);
        ra.Run();
        ra.Wait(2);
    }

    public void RunListening(int duration)
    {
        string[] filedat = OpenFile(_listeningPrompts);
        ListeningActivity la = new ListeningActivity(duration,filedat);
        la.Run();
        la.Wait(2);
    }

    public void MenuAction(int actn)
    {
        Console.Clear();
        Console.WriteLine("Please insert duration of activity (seconds)\n");
        int dur = int.Parse(Console.ReadLine());
        Console.Clear();
        if (actn == 1)
        {
            // 1 is breathing
            RunBreathing(dur);
        }
        else if (actn == 2)
        {
            RunReflection(dur);
        }
        else if (actn == 3)
        {
            RunListening(dur);
        }
        Console.Clear();
    }

    public void MainMenu()
    {   
        string selsen;
        bool running = true;
        int actn;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Select an Option by number.\n\n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Quit");
            Console.Write("> ");
            selsen = Console.ReadLine();
            actn = int.Parse(selsen);
            if (actn > 0 && actn <= 3)
            {
                MenuAction(actn);
                Console.Clear();
            }
            else if (actn == 4)
            {
                running = false;
            }
        }
        Console.Clear();
        Console.WriteLine("Thank you for using!");
    }
}