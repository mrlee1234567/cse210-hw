using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int toad = 9999;
        int largest = -99999;
        int smallest = 99999;
        int spos = 99999;
        int lpos = 0;
        int sneg = 0;
        int lneg = -99999;
        bool haspos = false;
        bool hasneg = false;

        List<int> nums = new List<int>();
        
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Insert numbers to add (insert 0 to end)");
        do
        {
            toad = int.Parse(Console.ReadLine());
            if (toad != 0)
            {
                nums.Add(toad);
            }
            if (toad > 0 && !haspos)
            {
                haspos = true;
            }
            if (toad < 0 && !hasneg)
            {
                hasneg = true;
            }
        } while (toad != 0);
        int ttl = 0;
        foreach (int i in nums)
        {
            if (i > largest)
            {
                largest = i;
            }
            if (i < smallest)
            {
                smallest = i;
            }
            if (i > 0)
            {
                if (i > lpos)
                {
                    lpos = i;
                }
                if (i < spos)
                {
                    spos = i;
                }
            }
            else if (i < 0)
            {
                if (i > lneg)
                {
                    lneg = i;
                }
                if (i < sneg)
                {
                    sneg = i;
                }
            }
            ttl += i;
        }
        nums.Sort();
        float fttl = ttl;
        float fcount = nums.Count();
        float aver = fttl / fcount;
        Console.WriteLine($"The sum is {ttl}");
        Console.WriteLine($"The average is {aver}");
        Console.WriteLine($"The largest number is {largest}");
        Console.WriteLine($"The smallest number is {smallest}");
        if (haspos)
        {
            Console.WriteLine("This list contains positives");
            Console.WriteLine($"The largest positive number is {lpos}");
            Console.WriteLine($"The smallest positive number is {spos}");
        }
        else
        {
            Console.WriteLine("This list has no positives");
        }
        if (hasneg)
        {
            Console.WriteLine("This list contains negatives");
            Console.WriteLine($"The smallest negative number is {lneg}");
            Console.WriteLine($"The largest negative number is {sneg}");
        }
        else
        {
            Console.WriteLine("This list has no negatives");
        }
        Console.WriteLine($"There are {nums.Count()} in the list");
        Console.WriteLine("The sorted list is this:");
        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }
    }
}