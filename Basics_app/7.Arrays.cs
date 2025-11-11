using System;

class Arrays
{
    static void Main()
    {
        // Arrays in C#
        // An array is a collection of items stored at contiguous memory locations.
        // It is used to store multiple values in a single variable, instead of declaring separate variables for each value.
        // Declaring and initializing an array of integers
        int[] numbers = new int[5]; // declaring an array of size 5
        // Assigning values to the array
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;
        // Accessing and printing array elements
        Console.WriteLine("Array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        // Declaring and initializing an array of strings
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
        // Accessing and printing string array elements
        Console.WriteLine("\nFruits:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);

            int[] scores = new int[] { 85, 90, 78, 92, 88 };
            Console.WriteLine(scores.Length-1);

            numbers[2] = 100; // updating the value at index 2
            Console.WriteLine(numbers[2]);


        }
    }
}