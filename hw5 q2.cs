using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter four integers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());
        int largest = GetLargest(num1, num2, num3, num4);
        Console.WriteLine($"The largest number is: {largest}");
    }

    static int GetLargest(int a, int b, int c, int d)
    {
        int largest1 = GetLargest(a, b);
        int largest2 = GetLargest(c, d);
        return GetLargest(largest1, largest2);
    }

    static int GetLargest(int a, int b)
    {
        return a > b ? a : b;
    }
}