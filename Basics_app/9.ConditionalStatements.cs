using System;
class CconditionalStatements
{
    static void Main()


    // if , else if , else --  statements

    {
        string food = "Pizza";

        if (food == "Burger")
        {
            Console.WriteLine("You ordered a Burger");
        }

        else if (food == "Pizza")
        {
            Console.WriteLine("You ordered a Pizza");
        }

        else if (food == "Sandwich")
        {
            Console.WriteLine("You ordered a Sandwich");
        }

        else
        {
            Console.WriteLine("Item not available");
        }


        // switch case statement ---> Assume the statements based on the case

        string signal = "Green";

        switch (signal)
        {

            case "Red":
                Console.WriteLine("Stop");
                break;

            case "Yellow":
                Console.WriteLine("Get Ready");
                break;

            case "Green":
                Console.WriteLine("Go");
                break;

            default:
                Console.WriteLine("Invalid Signal");
                break;
        }


    }
}