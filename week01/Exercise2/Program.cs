using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        int agrade = 90;
        int bgrade = 80;
        int cgrade = 70;
        int dfgrade = 60;
        Console.WriteLine("What is your grade score? (INT ONLY!)");
        int mgrade = int.Parse(Console.ReadLine());
        string lgrade;
        int pmgrade = 0;
        bool ignoresign = false;
        if (mgrade >= agrade)
        {
            lgrade = "an A";
            pmgrade = mgrade - agrade;
            if (pmgrade >= 7)
            {
                ignoresign = true;
            }
        }
        else if (mgrade >= bgrade)
        {
            lgrade = "a B";
            pmgrade = mgrade - bgrade;
        }
        else if (mgrade >= cgrade)
        {
            lgrade = "a C";
            pmgrade = mgrade - cgrade;
        }
        else if (mgrade >= dfgrade)
        {
            lgrade = "a D";
            pmgrade = mgrade - dfgrade;
        }
        else if (mgrade < dfgrade)
        {
            lgrade = "an F";
            ignoresign = true;
        }
        else
        {
            lgrade = "somehow, no grade";
            ignoresign = true;
        }

        if ((pmgrade >= 7) && !ignoresign)
        {
            lgrade = lgrade + "+";
        }
        else if ((pmgrade < 3) && !ignoresign)
        {
            lgrade = lgrade + "-";
        }

        Console.WriteLine($"The grade you recieved was {lgrade}.");
        if (mgrade >= cgrade)
        {
            Console.WriteLine("Congrulations! You passing you!");
        }
    }
}