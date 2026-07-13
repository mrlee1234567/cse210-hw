using System;
using System.Collections.Generic;

class ReadExtFiles
{
    public string[] OpenRaw(string fileName)
    {
        string[] ret = System.IO.File.ReadAllLines(fileName);
        return ret;
    }

    public string Open(string fileName, string sep)
    {
        string ret = "";

        string[] lines = OpenRaw(fileName);

        foreach (string i in lines)
        {
            ret += sep + i;
        }

        return ret;
    }

    public string Open(string fileName)
    {
        string ret = Open(fileName,"\n");

        return ret;
    }
}

/* 
from the course workpage:
The easiest way to read a text file in C# is to read the entire file into an array of strings (one per line) using the System.IO.File.ReadAllLines() function. Then, you can iterate through each string as you would with any list.

As you go through each string, you can split it based on a separator character and get the pieces you need by their index.
 */