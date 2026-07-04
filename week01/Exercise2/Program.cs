using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        int aGrade = 90;
        int bGrade = 80;
        int cGrade = 70;
        int dfGrade = 60;
        Console.WriteLine("What is your grade score? (INT ONLY!)");
        int mGrade = int.Parse(Console.ReadLine());
        string lGrade;
        int pmGrade = 0;
        bool ignoreSign = false;
        if (mGrade >= aGrade)
        {
            lGrade = "an A";
            pmGrade = mGrade - aGrade;
            if (pmGrade >= 7)
            {
                ignoreSign = true;
            }
        }
        else if (mGrade >= bGrade)
        {
            lGrade = "a B";
            pmGrade = mGrade - bGrade;
        }
        else if (mGrade >= cGrade)
        {
            lGrade = "a C";
            pmGrade = mGrade - cGrade;
        }
        else if (mGrade >= dfGrade)
        {
            lGrade = "a D";
            pmGrade = mGrade - dfGrade;
        }
        else if (mGrade < dfGrade)
        {
            lGrade = "an F";
            ignoreSign = true;
        }
        else
        {
            lGrade = "somehow, no grade";
            ignoreSign = true;
        }

        if ((pmGrade >= 7) && !ignoreSign)
        {
            lGrade = lGrade + "+";
        }
        else if ((pmGrade < 3) && !ignoreSign)
        {
            lGrade = lGrade + "-";
        }

        Console.WriteLine($"The grade you recieved was {lGrade}.");
        if (mGrade >= cGrade)
        {
            Console.WriteLine("Congrulations! You passing you!");
        }
        else
        {
            Console.WriteLine("Keep going, theres still time!");
        }
    }
}