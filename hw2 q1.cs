using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the letter grade: ");
        char letterGrade = Convert.ToChar(Console.ReadLine());

        int gpaPoints;

        switch (char.ToUpper(letterGrade))
        {
            case 'A':
                gpaPoints = 4;
                break;
            case 'B':
                gpaPoints = 3;
                break;
            case 'C':
                gpaPoints = 2;
                break;
            case 'D':
                gpaPoints = 1;
                break;
            case 'F':
                gpaPoints = 0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return; // exit the program
        }

        Console.WriteLine($"Corresponding GPA points: {gpaPoints}");
    }
}