using System;
using System.Collections.Generic;

class Reference
{
    static string _book;
    static List<int> _verses;
    static string _fullReference;
    static int _chapter;
    static string _verseReference;

    public Reference(int singleVerse, int chap, string book)
    {
        List<int> vees = new List<int>();
        vees.Add(singleVerse);
        _book = book;
        _verses = vees;
        _chapter = chap;
        _verseReference = $"{singleVerse}";
        _fullReference = $"{book} {chap}:{singleVerse}";
    }

    public Reference(List<int> verses, int chap, string book)
    {
        _verses = verses;
        string listString = string.Join(", ", verses);
        _chapter = chap;
        _book = book;
        _fullReference = $"{book} {chap}:{listString}";
        _verseReference = listString;
    }

    public Reference(int firstVerse, int lastVerse, int chap, string book)
    {
        List<int> vees = new List<int>();
        for (int i = firstVerse; i < lastVerse; i++)
        {
            vees.Add(i);
        }
        _verses = vees;
        _book = book;
        _chapter = chap;
        string vref = $"{firstVerse}-{lastVerse}";
        _verseReference = vref;
        _fullReference = $"{book} {chap}:{vref}";
    }

    public Reference(int firstVerse, int lastVerse, List<int> otherVerses, int chap, string book)
    {
        List<int> vees = new List<int>();
        for (int i = firstVerse; i < lastVerse; i++)
        {
            vees.Add(i);
        }
        string chopLa = string.Join(", ",vees);
        vees.AddRange(otherVerses);
        string vref = $"{firstVerse}-{lastVerse}, {chopLa}";
        _verses = vees;
        _chapter = chap;
        _verseReference = vref;
        _book = book;
        _fullReference = $"{book} {chap}:{vref}";
    }

    public List<int> GetVerses()
    {
        return _verses;
    }

    public string GetReference()
    {
        return _fullReference;
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChap()
    {
        return _chapter;
    }
}