public class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    // Constructor used to assign id, name, and age to the customer when an object is created.
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    // Method used to change customer id
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    // Method used to print customer information (id, name, age)
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer ID: {cus_id}");
        Console.WriteLine($"Customer Name: {cus_name}");
        Console.WriteLine($"Customer Age: {cus_age}");
    }

    // Method used to compare the current object’s age with the objCustomer’s age. Then print out the cus_name of the older customer.
    public void CompareAge(Customer objCustomer)
    {
        if (cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{cus_name} is older than {objCustomer.cus_name}");
        }
        else if (cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older than {cus_name}");
        }
        else
        {
            Console.WriteLine($"{cus_name} and {objCustomer.cus_name} are of the same age");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two customers
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        // Print their information
        Console.WriteLine("Customer 1 Information:");
        customer1.PrintCusInfo();
        Console.WriteLine();

        Console.WriteLine("Customer 2 Information:");
        customer2.PrintCusInfo();
        Console.WriteLine();

        // Update customers' IDs
        customer1.ChangeID(220);
        customer2.ChangeID(221);

        // Print their information again
        Console.WriteLine("Updated Customer 1 Information:");
        customer1.PrintCusInfo();
        Console.WriteLine();

        Console.WriteLine("Updated Customer 2 Information:");
        customer2.PrintCusInfo();
        Console.WriteLine();

        // Compare their age and print the older customer's name
        Console.WriteLine("Comparing their age:");
        customer1.CompareAge(customer2);
    }
}