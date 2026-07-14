// Added a manifest system to keep track of journal documents easier. also added an option to generate a random names for journal files

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class Program
{
    


    static void Main(string[] args)
    {
        /* project requirememnts:
1 Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
2 Display the journal - Iterate through all entries in the journal and display them to the screen.
3 Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
4 Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
5 Provide a menu that allows the user choose these options
6 Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
    a Who was the most interesting person I interacted with today?
    b What was the best part of my day?
    c How did I see the hand of the Lord in my life today?
    d What was the strongest emotion I felt today?
    e If I had one thing I could do over today, what would it be?
7 Your interface should generally follow the pattern shown in the video demo below. (video not provided in .cs file for obvious reasons)

In addition, your program must:

1 Contain classes for the major components in the program. (Each class should be in its own file where the filename matches the class name.)
    write, display, save, load, prompt x, open x
2 Contain at least two classes in addition to the Program class.
3 Demonstrate the principle of abstraction by using member variables and methods appropriately.

For the core requirements you do not need to worry about the following:

1 Saving your file as a .csv file requires you to handle commas and quotes in the content appropriately. At this point, you can ignore that and just choose a symbol for a separator that you think is unlikely to show up in the content (such as | or ~ or ~|~).
2 You do not need to store the date as an actual C# DateTime object in your class or in the file. You can simply store it as a string. 

Showing Creativity and Exceeding Requirements
Meeting the core requirements makes your program eligible to receive a 93%. To receive 100% on the assignment, you need to show creativity and exceed these requirements.

Here are some ideas you might consider:

1 Think of other problems that keep people from writing in their journal and address one of those.
2 Save other information in the journal entry.
3 Improve the process of saving and loading to save as a .csv file that could be opened in Excel (make sure to account for quotation marks and commas correctly in your content.
4 Save or load your document to a database or use a different library or format such as JSON for storage.

Report on what you have done to exceed requirements by adding a description of it in a comment in the Program.cs file. (you will know where i put this when i put this) */
        Console.WriteLine("Hello World! This is the Journal Project.");
        // Console.WriteLine("!!Just to let youu know, I did this late and w/o a group, dock me points if you must");

        Console.WriteLine("Boodup Buutyoomp!");
        DisplayJMenu journalMenu = new DisplayJMenu();
        journalMenu.MainMenu();

        Console.WriteLine("Thanksa so nice!");
        // a certain italian man calls this style of nonsense "yam brain," and it only appears when youve beem working into the wee hours of the night. this is a record for how early it has appeared, its 12:47a
    }
}

// todo: have the file be loaded and primed and useable when load is selected
// add a function that clears a journal of everything in it