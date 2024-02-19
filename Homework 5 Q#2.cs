using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 12;
            int c = 14;
            int d = 20;

            int max1 = GetLargestNumber(a, b);
            int max2 = GetLargestNumber(c, d);
            int max = GetLargestNumber(max1, max2);

            Console.WriteLine($"The largest number is: {max}");
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