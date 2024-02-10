using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int N = int.Parse(Console.ReadLine());

        PrintSquarePattern(N);
    }

    static void PrintSquarePattern(int rows)
    {
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}