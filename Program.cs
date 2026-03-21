using System.Linq;

Console.WriteLine("Hello, World!");
Console.WriteLine("Enter numbers separated by space:");
string input = Console.ReadLine();
if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Invalid input");
}

int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

static double CalculateAverage(int[] values)
{
    return values.Average();
}
HEAD
Console.WriteLine("Program started");


static int CalculateMax(int[] values)
{
    return values.Max();
}
feature-max

Console.WriteLine("Main updated again");
=======

static int CalculateMin(int[] values)
{
    return values.Min();
}
Console.WriteLine("Min calculated");
