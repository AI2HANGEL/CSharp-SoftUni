using System;
using System.Linq;

public class Reverser
{
    public static string[] ReverseStrings(string[] arr)
    {
        return arr.Select(s => new string(s.Reverse().ToArray())).ToArray();
    }
}

class Program
{
    static void Main()
    {
        // Sample input array of strings
        string[] inputArray = new string[] { "Hello", "Softuni"};

        // Call the ReverseStrings function
        string[] reversedArray = Reverser.ReverseStrings(inputArray);

        // Display the reversed strings
        Console.WriteLine("Original Strings:");
        foreach (string str in inputArray)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\nReversed Strings:");
        foreach (string str in reversedArray)
        {
            Console.WriteLine(str);
        }

        string input = "olleH\r\ninutfoS";
    }
}
