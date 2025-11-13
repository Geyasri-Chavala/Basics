using System;



using System;

class Methods1
{
    static void Main()
    {
        string color = GetFavoriteColor();
        Console.WriteLine("Favorite Color: " + color);


        bool isLoggedIn = LoginCheck();
        Console.WriteLine("Login Successful: " + isLoggedIn);


        int number = GetNumber();
        Console.WriteLine("Returned Number: " + number);


        string[] carsNames = getStudentNames();
        Console.WriteLine("Car Names:");


        foreach (string car in carsNames)
        {
            Console.WriteLine(car);
        }
    }


    // Method returning a string
    static string GetFavoriteColor()
    {
        string favorite = "Blue";
        return favorite;
    }


    // Method returning a boolean
    static bool LoginCheck()
    {
        string username = "Geya";
        string password = "Geya@123";

        if (username == "Geya" && password == "Geya@123")
            return true;
        else
            return false;
    }


    // Method returning an integer
    static int GetNumber()
    {
        int value = 10;
        return value;
    }


    // Method returning a string array
    static string[] getStudentNames()
    {
        string[] cars = new string[] { "Audi", "BMW", "Ferrari" };
        return cars;
    }
}
