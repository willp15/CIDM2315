using System;

class Program
{
    static void Main(string[] args)
    {
        createAccount();
    }

    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Enter password again:");
        string password2 = Console.ReadLine();

        Console.WriteLine("Enter birth year:");
        int birthYear = int.Parse(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}