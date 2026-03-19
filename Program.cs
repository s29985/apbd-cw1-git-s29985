using System.Linq;

Console.WriteLine("Hello, World!");
Console.WriteLine("Enter numbers separated by space:");
string input = Console.ReadLine();
if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Invalid input");
}

int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
