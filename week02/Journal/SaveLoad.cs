using System;
using System.Collections.Generic;

class SaveLoad
{
    static ReadExtFiles reader = new ReadExtFiles();
    static WriteFiles writer = new WriteFiles();
    static JournalBehind bts = new JournalBehind();
    static PromptRandomer prompter = new PromptRandomer();

    

    public List<string> DisplayManifest(string manifestName)
    {
        List<List<string>> monstrosity = bts.ManifestReader(manifestName);
        List<string> tamedBeast = new List<string>();
        for (int i = 0; i < monstrosity.Count; i++)
        {
            List<string> iq = monstrosity[i];
            // file.file|||date|||time
            string filename = iq[0];
            string addate = iq[1];
            string adtime = iq[2];
            string toad = $"{i + 1}: {filename} - {addate} {adtime}";
            Console.WriteLine(toad);
            tamedBeast.Add(filename);
        }
        return tamedBeast;
    }

    public void DisplayFile(string fileName)
    {
        if (System.IO.File.Exists(fileName))
        {
            string dorian = reader.Open(fileName);
            Console.WriteLine(dorian);
        }
        else
        {
            Console.WriteLine($"{fileName} does not exist");
        }
    }

    public List<string> SaveJournal(List<string> journal, List<string> manifest)
    {
        string fileName;
        bool goodnuf = true;
        do
        {
            Console.WriteLine("Would you like to enter your own file name? (y/n)");
            string respn = Console.ReadLine().ToLower();
            if (respn == "y")
            {
                Console.WriteLine("\nOmit the extension (.txt) and do not use \"|||\" in the name");
                fileName = $"{Console.ReadLine()}.txt";
                
            }
            else
            {
                fileName = writer.BuildDF();
            }
            Console.WriteLine($"\nIs {fileName} correct? (y/n)");
            respn = Console.ReadLine().ToLower();
            if (respn == "y")
            {
                goodnuf = false;
            }
        } while (goodnuf);

        Console.WriteLine("Saving to File...");
        writer.WriteFile(fileName,journal);
        Console.WriteLine("Saved!");
        return bts.ManifestAdder(manifest,fileName);
    }

    public void Open(string manifestFile)
    {
        List<string> manCont = DisplayManifest(manifestFile);
        int manlen = manCont.Count;
        Console.WriteLine($"Select which file you want (1-{manlen})");
        int selsen = int.Parse(Console.ReadLine());
        if (selsen > manlen)
        {
            Console.WriteLine($"{selsen} is outside of the content list.");
        }
        else if (selsen < 1)
        {
            Console.WriteLine($"Selection must be 1 or greater, {selsen} is less than 1.");
        }
        else
        {
            string selfile = manCont[selsen - 1];
            DisplayFile(selfile);
        }
    }
    
}