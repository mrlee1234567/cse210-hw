using System;
using System.Collections.Generic;

class Scripture
{
    static List<Verse> _verses;
    static Reference _reference;
    static Random _random;
    static bool _canChoose;

    public Scripture(List<string> chapterContent, List<int> verses, string book, int chapter)
    {
        _reference = new Reference(verses,chapter,book);
        List<Verse> vses = new List<Verse>();
        int versum = chapter;
        foreach (int i in verses)
        {
            string iq = chapterContent[i];
            Verse newVerse = new Verse(i,iq);
            vses.Add(newVerse);
            versum += i;
        }
        _verses = vses;
        DateTime nuh = DateTime.Now;
        int hr = nuh.Hour;
        int yr = nuh.Year;
        int min = nuh.Minute;
        int sec = nuh.Second;
        int mil = nuh.Millisecond;
        int seedee = hr + min + yr + sec + mil + versum;
        _random = new Random(seedee);
        _canChoose = true;
    }

    static void RemoveWord()
    {
        List<int> viableInds = new List<int>();
        for (int i = 0; i < _verses.Count; i++)
        {
            Verse iq = _verses[i];
            if (iq.CheckHiding())
            {
                viableInds.Add(i);
            }
        }
        if (viableInds.Count == 0)
        {
            _canChoose = false;
            return;
        }
        int rint = _random.Next(viableInds.Count);
        Verse chosen = _verses[rint];
        _verses[rint].HideRandom(_random);
    }

    public void PrintPassage(bool removeWord)
    {
        if (removeWord)
        {
            RemoveWord();
        }
        string res = "";
        
        foreach (Verse i in _verses)
        {
            
            res += i.GetVerse();
            
        }
        Console.WriteLine(res);
    }

    public void PrintPassage()
    {
        PrintPassage(true);
    }

    public bool GetDoable()
    {
        return _canChoose;
    }
}