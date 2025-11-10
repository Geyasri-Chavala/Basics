using System;

class VarAndDynamic
{
    static void Main()
    {
        int number = 10;
        number = number + 1;
        Console.WriteLine(number); // 11

        // number only accepts the number values not strings

        string name = "Csharp";
        name = ".netCore fullstack development";
        //name = 10;
        // string only accepts string values not numbers
        Console.WriteLine(name);
        // .netCore fullstack development

        double stockPriceOfsomeproduct = 12.1215;
        stockPriceOfsomeproduct = 15.121;
        //stockPriceOfsomeproduct = false;
        Console.WriteLine(stockPriceOfsomeproduct);


        var someValue = 12;  // want to assign value to here
        someValue = 15;
        // someValue = "Csharp"; // always an integer

        Console.WriteLine(someValue);   // 15 is integer
        Console.WriteLine(someValue.GetType());

        var someValue1 = "Csharp";
        Console.WriteLine(someValue1); // Csharp
        Console.WriteLine(someValue1.GetType());

        var someValue2 = false;
        Console.WriteLine(someValue2); // false
        Console.WriteLine(someValue2.GetType());


        // by using Dynamic
        dynamic d_someValue = 12;
        d_someValue = 20;
        d_someValue = "Csharp";
        d_someValue = false;

        Console.WriteLine($"dynamic value : {d_someValue}"); // false
        Console.WriteLine(d_someValue.GetType());            //boolean

        dynamic d_someValue1 = "Dotnetcore";
        Console.WriteLine(d_someValue1); // Dotnetcore
        // Console.WriteLine(d_someValue1.GetType());

        dynamic d_someValue2 = false;
        Console.WriteLine(d_someValue2); // false
        // Console.WriteLine(d_someValue2.GetType());

    }
}
