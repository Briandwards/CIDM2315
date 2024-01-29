using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double smallestValue = FindSmallestValue(num1, num2, num3);

        Console.WriteLine($"The smallest value is {smallestValue}.");
    }

    static double FindSmallestValue(double num1, double num2, double num3)
    {
        double smallestValue = num1;

        if (num2 < smallestValue)
        {
            smallestValue = num2;
        }

        if (num3 < smallestValue)
        {
            smallestValue = num3;
        }

        return smallestValue;
    }
}