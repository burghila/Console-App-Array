using System;

class Program
{
    static void Main()
    {
        // Create a one-dimensional Array of strings
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date" };
        // Prompt user to select an index
        Console.WriteLine("Select an index from the string array (0-3):");
        try
        {
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            // Display the string at that index
            Console.WriteLine($"The selected string is: {stringArray[stringIndex]}");
        }
        catch (IndexOutOfRangeException)
        {
            // Error message for out-of-range index
            Console.WriteLine("Error: Index does not exist.");
        }

        // Create a one-dimensional Array of integers
        int[] intArray = { 10, 20, 30, 40 };
        // Prompt user to select an index
        Console.WriteLine("Select an index from the integer array (0-3):");
        try
        {
            int intIndex = Convert.ToInt32(Console.ReadLine());
            // Display the integer at that index
            Console.WriteLine($"The selected integer is: {intArray[intIndex]}");
        }
        catch (IndexOutOfRangeException)
        {
            // Error message for out-of-range index
            Console.WriteLine("Error: Index does not exist.");
        }

        // Create a list of strings
        var stringList = new List<string> { "Red", "Blue", "Green", "Yellow" };
        // Prompt user to select an index
        Console.WriteLine("Select an index from the list of strings (0-3):");
        try
        {
            int listIndex = Convert.ToInt32(Console.ReadLine());
            // Display the content at that index
            Console.WriteLine($"The selected content is: {stringList[listIndex]}");
        }
        catch (IndexOutOfRangeException)
        {
            // Error message for out-of-range index
            Console.WriteLine("Error: Index does not exist.");
        }
    }
}
