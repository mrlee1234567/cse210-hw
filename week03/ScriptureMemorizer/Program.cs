// It takes in a scripture in the form a a text file and asks the user for the range of what they want to memorize. only 1 Nephi 1 is included, but theoretically more could be added


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("Select a Book of Scripture (only first nephi chapter 1 right now)");
        string selection = Console.ReadLine();
        string book = selection;
        Console.WriteLine("Select a chapter from this book");
        selection = Console.ReadLine();
        int chapter = int.Parse(selection);
        Console.WriteLine("Insert the first verse you want");
        selection = Console.ReadLine();
        int v1 = int.Parse(selection);
        Console.WriteLine("Insert the last verse you want");
        selection = Console.ReadLine();
        int v2 = int.Parse(selection);
        Console.WriteLine("Thank you, processing your entries.");
        ScriptureLoader loader = new ScriptureLoader(book, chapter,v1,v2);
        loader.ShowLoop();
        Console.WriteLine("Thank you good bye!");
    }
    /* 
    
    program stores scripture + reference (ie john 3:16) and accomodates multiple verses (ie proverbs 3:5-6)
    clear console and display full scripture and reference
    if the user types quit, the program ends
    if enter is pressed w/o input, the program takes random words in the scripture and replaces it with underscores
    continue pompting until all words are hidden
    if enter is hit with all words hidden, the program ends
    can select already hidden words randomly, as a stretch for extra hopefully points, select from not hidden words only

    requirements:

    demonstrate proper use of encapsulation, ie classes, methods, public,private access, and good style
    at least 3 classes, one for the scripture, one for the reference, and one for each word in the scripture
    Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").

    + creativity
    examples:
    Think of other challenges that people find when trying to memorize a scripture. Find a way to have your program help with these challenges.
    Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.
    Have the program to load scriptures from a files.
    Anything else you can think of!

    user inputs:
    beginning reference
    quit/hide word
    
    outputs:
    start menu
    scripture reference
    scripture and hidden words

    ends by doing quit or filling the entry with blanks

    classes:
    Scripture, Word, Reference, LoaderMenu, ScriptureLoader

     */
}