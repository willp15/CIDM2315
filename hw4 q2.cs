using System;

class Program
{
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N = {N}, Shape = {shape}");

        if (shape == "left")
        {
            // Print left-side triangle
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (shape == "right")
        {
            // Print right-side triangle
            for (int i = 1; i <= N; i++)
            {
                for (int j = N; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid shape. Please choose 'left' or 'right'.");
        }
    }

    static void Main()
    {
        int N = 5;
        string shape = "left"; // Change this to "right" for right-side triangle
        PrintTriangle(N, shape);
    }
}