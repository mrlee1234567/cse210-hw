using System;
using System.Collections.Generic;

class FileReader
{
    public List<string> ReadFile(string fileName)
    {
        string[] ret = System.IO.File.ReadAllLines(fileName);
        List<string> gup = new List<string>();
        foreach (string i in ret)
        {
            // Console.WriteLine(i);
            gup.Add(i);
        }
        return gup;
    }
}