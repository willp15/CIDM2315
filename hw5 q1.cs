using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two integers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int largest = GetLargest(num1, num2);
        Console.WriteLine($"The largest number is: {largest}");
    }

    static int GetLargest(int a, int b)
    {
        return a > b ? a : b;
    }
}