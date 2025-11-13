using System;
class LoopingMecanisams
{
    static void Main()
    {
        // while loop

        int i = 1;

        while (i <= 5)
        {
            Console.WriteLine("Number: " + i);
            i++;
        }

        // Do While Loop

        int result = 0;
        do
        {
            Console.WriteLine("Do....Excuted");
            result = result + 1;
        } while (result < 5);

        // For each Loop

        string[] fruits = { "Apple", "Banana", "Cherry" };

        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }


    }
}