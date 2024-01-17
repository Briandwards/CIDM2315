namespace HelloWorld;
class Program
{
    
     static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Brian Edwards");
    }
}
using System;

namespace LinearEquationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given values
            double X = 2.5;
            double Y = 3.3;

            // Calculate the value of Z using the linear equation
            double Z = 4 * Math.Pow(X, 2) + 3 * Y;

            // Print the result in the specified format
            Console.WriteLine("The value of Z for X = {0} and Y = {1} is: {2}", X, Y, Z);
        }
    }
}