using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 11;

            int largestNumber = GetLargestNumber(a, b);

            Console.WriteLine($"The largest number is: {largestNumber}");
        }

        static int GetLargestNumber(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}