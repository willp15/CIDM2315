using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int N = int.Parse(Console.ReadLine());

        PrintSquarePattern(N);
    }

    static void PrintSquarePattern(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}