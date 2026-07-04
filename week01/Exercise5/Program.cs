using System;
using System.Data.SqlTypes;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is you Name?");
        string ret = Console.ReadLine();
        return ret;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int ret = int.Parse(Console.ReadLine());
        return ret;
    }

    static int SquareNumber(int favnum)
    {
        int sqd = favnum * favnum;
        return sqd;
    }

    static void DisplayResult(int favnum, string uname)
    {
        Console.WriteLine($"The squared favorite number is {favnum}");
        Console.WriteLine($"The user is called {uname}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        // PromptUserName - Asks for and returns the user's name (as a string)
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        // SquareNumber - Accepts an integer as a parameter and returns that number squared(as an integer)
        // DisplayResult - Accepts the user's name and the squared number and displays them.

        DisplayWelcome();
        string username = PromptUserName();
        int favnum = PromptUserNumber();
        int fasquanom = SquareNumber(favnum);
        DisplayResult(fasquanom,username);
    }
}