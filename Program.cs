using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 1st number:");
        string? a = Console.ReadLine();
        int number1;

        // Safe conversion with TryParse
        if (!int.TryParse(a, out number1))
        {
            Console.WriteLine("Invalid input for 1st number.");
            return;
        }

        Console.WriteLine("Enter 2nd number:");
        string? b = Console.ReadLine();
        int number2;

        // Safe conversion with TryParse
        if (!int.TryParse(b, out number2))
        {
            Console.WriteLine("Invalid input for 2nd number.");
            return;
        }

        Console.WriteLine("Enter the operation (add, sub, multiply):");
        string? o = Console.ReadLine();

        // Perform the operation
        if (o == "add")
        {
            int result = number1 + number2;
            Console.WriteLine($"Result: {result}");
        }
        else if (o == "sub")
        {
            int result = number1 - number2;
            Console.WriteLine($"Result: {result}");
        }
        else if (o == "multiply")
        {
            int result = number1 * number2;
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Invalid operation.");
        }
    }
}
