using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        bool keepgoing = true;
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
                magicnum = genor.Next(1,100);
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
                    // Console.WriteLine("Lower");
                }
                else if (guess < magicnum)
                {
                    highlow = "higher ";
                    // Console.WriteLine("Higher");
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
                keepgoing = false;
            }
        } while (keepgoing);
        Console.WriteLine("Ok, bey.");
    }
}