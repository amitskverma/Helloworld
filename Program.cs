using System;

class Program
{
    static void Main()
    {
        // Ask the user for their name
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();  // Nullable type to allow null input
        
        // Ensure name is not null
        if (name == null)
        {
            name = "Unknown"; // Default value if input is null
        }

        // Ask the user for their age
        Console.Write("Enter your age: ");
        string? ageInput = Console.ReadLine();  // Nullable type to allow null input
        
        // Handle the case where the input might be null or not a valid integer
        int age = 0;
        if (ageInput != null && int.TryParse(ageInput, out age))
        {
            // Successfully parsed the age
        }
        else
        {
            Console.WriteLine("Invalid age input. Setting age to default value: 0.");
            age = 0;  // Default value for age
        }

        // Ask the user for their city
        Console.Write("Enter your city: ");
        string? city = Console.ReadLine();  // Nullable type to allow null input
        
        // Ensure city is not null
        if (city == null)
        {
            city = "Unknown"; // Default value if input is null
        }

        // Output the message
        Console.WriteLine($"Hello, {name}! You are {age} years old and live in {city}.");
    }
}
