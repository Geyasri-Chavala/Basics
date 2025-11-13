using System;
class Methods
{
    static void Main()
    {
        Greet();

        DisplayMessage();

        ShowDetails();
    }
    // Void - Non-return type
    static void Greet()
        {
            Console.WriteLine("Good Morning!");
        }

    // Void - Non-return type
    static void DisplayMessage()
       {
            Console.WriteLine("Welcome to the C# world!");
       }

    static void ShowDetails()
    {
        Console.WriteLine("Name: Geya");

        Console.WriteLine("fullNmae: Geya Sri chavala");
    }

}

