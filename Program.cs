var amit = new List<string> { "amit", "zxse", "ram", "shayam" };

        // Sort the list alphabetically
        amit.Sort();

        // Print each element of the list using a foreach loop
        Console.WriteLine("Sorted List (Using foreach):");
        foreach (var name in amit)
        {
            Console.WriteLine(name);
        }

        // Alternatively, you can join the list into a single string and print it
        Console.WriteLine("\nSorted List (Using string.Join):");
        Console.WriteLine(string.Join(", ", amit)); // Join elements with commas
   