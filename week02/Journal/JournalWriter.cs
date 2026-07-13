using System;
using System.Collections.Generic;

class JournalWriter
{
    static List<string> _journal = new List<string>();
    static PromptRandomer prompt = new PromptRandomer();
    static string _promptFile = "prompts.txt";

    public void Write()
    {
        string writingPrompt;

        if (System.IO.File.Exists(_promptFile))
        {
            writingPrompt = prompt.FilePrompt(_promptFile);
        }
        else
        {
            writingPrompt = $"{_promptFile} does not exist, think of something creative, quick!";
        }
        Console.WriteLine(writingPrompt);
        string respn = Console.ReadLine();
        DateTime nuh = DateTime.Now;
        string promPlusNow = $"Date: {nuh.ToShortDateString()} - Prompt: {writingPrompt}\n{respn}\n";
        _journal.Add(promPlusNow);
    }

    public List<string> Get()
    {
        return _journal;
    }
}