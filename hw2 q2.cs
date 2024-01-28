using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");

        // Input first number
        Console.Write("Number 1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Input second number
        Console.Write("Number 2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Input third number
        Console.Write("Number 3: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        // Find the smallest number
        double smallest = Math.Min(Math.Min(num1, num2), num3);

        // Print the result
        Console.WriteLine($"The smallest number is: {smallest}");
    }
}