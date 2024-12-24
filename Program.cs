/*var amit = new List<string> { "amit", "zxse", "ram", "shayam" };

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
   
*/

   // Specify the data source.
List<int> scores  = [97, 92, 81,79,98,60];

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}

// Output: 97 92 81