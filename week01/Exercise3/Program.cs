using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        bool keepGoing = true;
        Random genor = new Random();
        do
        {
            bool cg = false;
            Console.WriteLine("Would you like to manually enter the magic number? (y/n)");
            string emg = Console.ReadLine();
            if (emg == "y")
            {
                cg = true;
            }
            int magicnum = 0;
            if (cg)
            {
                Console.WriteLine("What is the magic number?");
                magicnum = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Guess a number between 1 and 100");
                magicnum = genor.Next(1,101);
            }
            bool notwin = true;
            string highlow = "";
            do
            {
                Console.WriteLine($"Guess a {highlow}number");
                int guess = int.Parse(Console.ReadLine());
                if (guess > magicnum)
                {
                    highlow = "lower ";
                    Console.WriteLine("Lower");
                    // these were commented out because the higlow variable contained the context of whether the guess needed to be higher or lower
                }
                else if (guess < magicnum)
                {
                    highlow = "higher ";
                    Console.WriteLine("Higher");
                    // but i can see how it would be confusing if i didnt have it explicitly write to the console
                }
                else
                {
                    notwin = false;
                    Console.WriteLine($"Correct! The number was {magicnum}!");
                }
            } while (notwin);
            Console.WriteLine("Go Again? (y/n)");
            string goagn = Console.ReadLine();
            if (goagn == "n")
            {
                keepGoing = false;
            }
        } while (keepGoing);
        Console.WriteLine("Ok, bey.");
    }
}