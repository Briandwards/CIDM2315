using System;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(N))
            {
                Console.WriteLine("N is prime");
            }
            else
            {
                Console.WriteLine("N is non-prime");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i+=2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}