static int FindLargestNumber(int num1, int num2)
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

static void Main(string[] args)
{
    int a = 10;
    int b = 7;
    int largestNumber = FindLargestNumber(a, b);
    Console.WriteLine($"The largest number is: {largestNumber}");
}The largest number is: 10