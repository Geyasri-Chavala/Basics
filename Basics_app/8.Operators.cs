using System;



    class Operators
{ 
    static void Main()
    {
        // Arthemetic Operators
        int a = 10;
        int b = 5;

        Console.WriteLine("Addition: " + (a + b)); // 15

        Console.WriteLine("Subtraction: " + (a - b)); // 5

        
        Console.WriteLine("Multiplication: " + (a * b)); // 50

           
        Console.WriteLine("Division: " + (a / b)); // 2

        Console.WriteLine("Modulus: " + (a % b)); // 0


        // == , != , > , < , >= , <=

        bool isEqual = (12 == 12);
        Console.WriteLine(isEqual); // True

        bool isEqual1 = (12 == 15);
        Console.WriteLine(isEqual1); // False

        bool isEqual2 = (12 > 15);
        Console.WriteLine(isEqual2); // False

        bool isEqual3 = (12 < 15);
        Console.WriteLine(isEqual3); // True

        bool isEqual4 = (12 >= 15);
        Console.WriteLine(isEqual4); // False

        bool isEqual5 = (12 <= 15); 
        Console.WriteLine(isEqual5); // True



        // logical operators

        Console.WriteLine("---------------------AND Operator---------------");

        bool isResult =  (12 == 12) && (15 == 15);
        Console.WriteLine(isResult);       // True && True = True

        bool isResult1 = (12 == 12 && 10 < 5);
        Console.WriteLine(isResult1);      // True && False = False

        bool isResult2 = (12 != 12 && 10 > 5);
        Console.WriteLine(isResult2);      // False && True = False

        bool isResult3 = (12 != 12 && 10 < 5);
        Console.WriteLine(isResult3);        // False && False = False


        Console.WriteLine("---------------------OR Operator---------------");

        bool isResult4 = (12 == 12 || 10 > 5);
        Console.WriteLine(isResult4);        // True || True = True

        bool isResult5 = (12 == 12 || 10 < 5);
        Console.WriteLine(isResult5);        // True || False = True

        bool isResult6 = (12 != 12 || 10 > 5);
        Console.WriteLine(isResult6);        // False || True = True

        bool isResult7 = (12 != 12 || 10 < 5);
        Console.WriteLine(isResult7);        // False || False = False



        Console.WriteLine("---------------------NOT Operator---------------");

        bool isResult8 = !(12 == 12);
        Console.WriteLine(isResult8);        // !True = False

        bool isResult9 = !(12 != 12);
        Console.WriteLine(isResult9);        // !False = True


    }
}
