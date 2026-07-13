using System;
using System.Collections.Generic;

class PromptRandomer
{
    public string Prompt(string[] listo, int rseed)
    {
        Random genor = new Random(rseed);
        int lilen = listo.Length;
        int pocito = genor.Next(lilen);
        string res = listo[pocito];
        return res;
    }

    public string Prompt(List<string> listo, int rseed)
    {
        Random genor = new Random(rseed);
        int lilen = listo.Count;
        int pocito = genor.Next(lilen);
        string res = listo[pocito];
        return res;
    }

    public string FilePrompt(string fileName, int rseed)
    {
        ReadExtFiles rwf = new ReadExtFiles(); //idk why this is necessary... but its neccessary i guess?
        if (!System.IO.File.Exists(fileName))
        {
            return $"{fileName} NO EXISTO";
        }
        string[] file = rwf.OpenRaw(fileName);
        string ret = Prompt(file,rseed);
        return ret;
    }

    public int SeedSeeder()
    {
        DateTime rn = DateTime.Now;
        int hour = rn.Hour;
        int minit = rn.Minute;
        int dag = rn.Day;
        int jaar = rn.Year;
        int dagjaar = rn.DayOfYear;
        int mili = rn.Millisecond;
        int moe = rn.Month;
        // all of that to keep from repeating myself. also its just fun
        int sneed = (hour * minit) + dag + (jaar - dagjaar) + mili + moe;
        return sneed;
    }

    public int SeedSeeder(int offset)
    {
        int sneed = SeedSeeder();
        sneed = sneed / offset;
        return sneed;
    }

    public string FilePrompt(string fileName)
    {
        int sneed = SeedSeeder();
        string ret = FilePrompt(fileName,sneed);
        return ret;
    }
}

/* from workpage:
C# has a class that is used for working with dates and time of day called, DateTime.

You can get an object representing the current day and time with DateTime.Now. Then,
it has various methods that are helpful, such as .ToShortDateString(). */