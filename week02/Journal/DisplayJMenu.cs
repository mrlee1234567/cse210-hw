using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Security.Cryptography;

class DisplayJMenu
{
    public JournalWriter journal = new JournalWriter();
    public JournalBehind bts = new JournalBehind();
    public SaveLoad sl = new SaveLoad();
    public ReadExtFiles reader = new ReadExtFiles();
    public string manifestFile = "manifest.txt";
    
    static List<string> ConvertToList(string[] victim)
    {
        List<string> graveyard = new List<string>();
        foreach (string innard in victim)
        {
            graveyard.Add(innard);
            // im going to hell for this one lol
        }
        return graveyard;
    }

    public void MainMenu()
    
    {
        bool menae = true;
        List<string> manifest = ConvertToList(reader.OpenRaw(manifestFile));
        
        do
        {
            Console.WriteLine("Please select the following:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
            int selsen = int.Parse(Console.ReadLine());
            if (selsen == 1)
            {
                // write
                journal.Write();
            }
            else if (selsen == 2)
            {
                // display
                List<string> contnt = journal.Get();
                foreach (string i in contnt)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("(Enter to return to menu)");
                Console.ReadLine();
            }
            else if (selsen == 3)
            {
                // load (ie, load and read existing journal)
                sl.Open(manifestFile);
                Console.WriteLine("(Enter to return to menu)");
                Console.ReadLine();
            }
            else if (selsen == 4)
            {
                // save
                List<string> contnt = journal.Get();
                manifest = sl.SaveJournal(contnt,manifest);
                bts.ManifestWriter(manifest,manifestFile);
            }
            else if (selsen == 5)
            {
                Console.WriteLine("Goodbye!");
                menae = false;
            }
            else
            {
                Console.WriteLine($"{selsen} is not a valid input\n");
            }
        } while (menae);
    }
}