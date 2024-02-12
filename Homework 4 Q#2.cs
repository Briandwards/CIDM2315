static void PrintTriangle(int N, string shape)
{
    Console.WriteLine($"N is: {N}; shape is {shape}");
    if (shape.ToLower() == "left")
    {
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else if (shape.ToLower() == "right")
    {
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N - i + 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Invalid shape. Please use 'left' or 'right'.");
    }
}

static void Main(string[] args)
{
    int N = 7;
    string shape = "Right";
    PrintTriangle(N, shape);
}N is: 7; shape is Right
*
**
***
****
*****
****
***
**
*