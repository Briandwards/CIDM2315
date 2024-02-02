using System;

namespace SquarePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j || i + j == N - 1)
                    {
                        Console.Write(Math.Max(i, j) + 1 + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}