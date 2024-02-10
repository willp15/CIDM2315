using System;

class Program
{
    static int GetLargest(int num1, int num2)
    {
        return Math.Max(num1, num2);
    }

    static void Main()
    {
        int number1 = 10;
        int number2 = 20;
        int largest = GetLargest(number1, number2);
        Console.WriteLine("The largest number is: " + largest);
    }
}