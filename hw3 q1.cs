using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int N = int.Parse(Console.ReadLine());

        if (IsPrime(N))
        {
            Console.WriteLine($"{N} is prime.");
        }
        else
        {
            Console.WriteLine($"{N} is non-prime.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}