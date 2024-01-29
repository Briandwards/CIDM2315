using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        bool isLeapYear = IsLeapYear(year);

        if (isLeapYear)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }

    static bool IsLeapYear(int year)
    {
        if (year % 4 != 0)
        {
            return false;
        }

        if (year % 100 != 0)
        {
            return true;
        }

        if (year % 400 != 0)
        {
            return false;
        }

        return true;
    }
}