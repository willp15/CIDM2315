using system;

class Program
{
// Q1: calculate the sum of elements in a given int_array (4 points)
    public static void ArraySum(int[] int_array)
    {
        int sum = 0;
        foreach (int num in int_array)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of int_array: {sum}");
    }


    //Q2.1: given a 2d array, print all the odd elements (2 points)
    public static void PrintAllOddNumber(int[,] array_2d)
    {
        Console.WriteLine("Odd elements in the 2d array:");
        foreach (int num in array_2d)
        {
            if (num % 2 != 0)
            {
                Console.Write(num + " ");
            }
        }
    }
    //Q2.2: given a 2d array, return the sum of all elements (2 points)
    public static int ElementSum(int[,] array_2d)
    {
        int sum = 0;
        foreach (int num in array_2d)
        {
            sum += num;
        }
        return sum;
    }


    // Q2.3: given a 2d array, double its element values and return it (2 points)
    public static int[,] DoubleArray(int[,] array_2d)
    {
        int[,] doubledArray = new int[array_2d.GetLength(0), array_2d.GetLength(1)];
        for (int i = 0; i < array_2d.GetLength(0); i++)
        {
            for (int j = 0; j < array_2d.GetLength(1); j++)
            {
                doubledArray[i, j] = array_2d[i, j] * 2;
            }
        }
        return doubledArray;
    }
}