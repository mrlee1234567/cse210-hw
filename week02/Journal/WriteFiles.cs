using System;
using System.Collections.Generic;
using System.IO;

class WriteFiles
{
    public PromptRandomer genor = new PromptRandomer();
    public string defaultFile = "dummy.txt";

    public string BuildDF(string inor)
    {
        PromptRandomer sgenor = new PromptRandomer();
        string df = inor;
        if (System.IO.File.Exists("dummynames.txt"))
        {
            DateTime nuh = DateTime.Now;
            int dy = nuh.Day;
            int moe = nuh.Month;
            int yr = nuh.Year;
            int hr = nuh.Hour;
            int mn = nuh.Minute;
            df = sgenor.FilePrompt("dummynames.txt");
            df = $"{df}-{moe} {dy} {yr} {hr}-{mn}.txt";
        }
        return df;
    }

    public string BuildDF()
    {
        return BuildDF(defaultFile);
    }
    
    public void Write(StreamWriter file, string datum)
    {
        file.WriteLine(datum);
    }

    public void WriteFile(string fileName, List<string> datum)
    {
        using (StreamWriter ret = new StreamWriter(fileName))
        {
            foreach (string i in datum)
            {
                Write(ret,i);
            }
        }
    }

    public void WriteFile(string fileName, string[] datum)
    {
        using (StreamWriter ret = new StreamWriter(fileName))
        {
            foreach (string i in datum)
            {
                Write(ret, i);
            }
        }
    }

    public void WriteFile(string fileName, string datum)
    {
        using (StreamWriter ret = new StreamWriter(fileName))
        {
            Write(ret, datum);
        }
    }

    public void WriteFile(List<string> datum)
    {
        string fnam = BuildDF(defaultFile);
        WriteFile(fnam,datum);
    }

    public void WriteFile(string datum)
    {
        string fnam = BuildDF(defaultFile);
        WriteFile(fnam,datum);
    }
}

/* from the course workpage:
You can create or write a text file in C# using a class the System.IO.StreamWriter class.
When you create an object of this class you can use the Write() and WriteLine() methods in the same way as the Console.Write() methods,
except that they will write the strings to the file instead of to the Console.

To make sure the file gets closed and cleaned up appropriately when you are done,
it is best practice to put the StreamWriter object in a using() block.
This works the same as a "with" block in Python and ensures that the resources are cleaned up when you leave that area of the code. */