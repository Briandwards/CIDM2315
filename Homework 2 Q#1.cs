using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a letter grade (A, B, C, D, F): ");
        string letterGrade = Console.ReadLine().ToUpper();

        double gpaPoints;

        switch (letterGrade)
        {
            case "A":
                gpaPoints = 4;
                break;
            case "B":
                gpaPoints = 3;
                break;
            case "C":
                gpaPoints = 2;
                break;
            case "D":
                gpaPoints = 1;
                break;
            case "F":
                gpaPoints = 0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return;
        }

        Console.WriteLine($"The corresponding GPA points for the letter grade {letterGrade} is {gpaPoints}.");
    }
}