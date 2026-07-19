using System;
using System.Collections.Generic;

class ScriptureLoader
{
    static Scripture _scripture;
    static string _scriptureFile;
    static List<string> _scriptureContent;
    static FileReader _reader = new FileReader();

    public ScriptureLoader(string book, int chapter, List<int> verses)
    {
        string filePath = $"{book}-{chapter}.txt";
        Console.WriteLine(filePath);
        if (System.IO.File.Exists(filePath))
        {
            
            _scriptureFile = filePath;
            _scriptureContent = _reader.ReadFile(filePath);
            
        }
        else
        {
            _scriptureContent = ["none"];
            Console.WriteLine("cannot find that scripture");
        }
        _scripture = new Scripture(_scriptureContent,verses,book,chapter);
    }

    public ScriptureLoader(string book, int chapter, int firstVerse, int lastVerse)
    {
        string filePath = $"{book}-{chapter}.txt";
        if (System.IO.File.Exists(filePath))
        {
            
            Console.WriteLine(filePath);
            
            _scriptureFile = filePath;
            _scriptureContent = _reader.ReadFile(filePath);
            
        }
        else
        {
            _scriptureContent = ["none"];
            Console.WriteLine("cannot find that scripture");
        }
        List<int> verses = new List<int>();
        for (int i = firstVerse; i < lastVerse + 1; i++)
        {
            verses.Add(i);
        }
        _scripture = new Scripture(_scriptureContent,verses,book,chapter);
    }

    public void ShowLoop()
    {
        bool doable = _scripture.GetDoable();
        string toPrint;
        while (doable)
        {
            Console.Clear();
            _scripture.PrintPassage();
            Console.WriteLine("(Enter \"quit\" to quit)");
            toPrint = Console.ReadLine();
            if (toPrint.ToLower() == "quit")
            {
                doable = false;
            }
        }
    }
}