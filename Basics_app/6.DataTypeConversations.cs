using System;



    class DataTypeConversations
    { 
    static void Main() 
    {
        // Type Conversations
        // These are of two types : Implicit and Explicit


        // Implicit Type Conversion ---> converting a smaller data type to a larger data type without loosing databyte age = 22;
        int age = 22;        // numeric
        int largeAge = age; // implicit conversion from byte to int



        // Explicit Type Conversion ---> converting a larger data type to a smaller data type with loosing data
        int salary = 30000;               // numeric
        byte smallSalary = (byte)salary; // explicit conversion from int to byte


        // In explict we are giving guidance to the compiler exactly what the type is;
        int age1 = 22;   // telling compiler explictly..
        string name = "Csharp";
        double package = 25000.50;


        // explicit conversion
        // while assigning type we have to manually use casting (int).... otherwise we get compile time error
        // casting(int) is used to convert from one type to another type
        double price = 29.99;
        int amount = (int)price;      // explicit conversion from double to int
        Console.WriteLine("amount"); // Output: Amount after explicit conversion: 29 we are loosing data of .99 value...

        long bigNumber = 9652888199;
        byte byte1 = (byte)bigNumber; // explicit conversion from long to byte
        Console.WriteLine("byte1");  // Output: byte1 after explicit conversion: 15 we are loosing data here...


        // In implict we are going to let the compiler undestand what the type you have assigned value is...
        var age2 = 22;         // compiler will understand it as int
        var name1 = "Csharp"; // compiler will understand it as string

        // takes automatically without loosing data..
        // Here no need to use casting...

        int number = 100;
        double result = number; // implicit conversion from int to double
        Console.WriteLine("result"); // Output: Result after implicit conversion: 100


        // Boxing ----> processs of converting a value type to a reference type
        // Unboxing ---> process of converting a reference type to a value type

        // value type is nothing but actual value....
        // reference stores the address of the actual value...



        // Boxing example
        int num = 42; // value type
        object obj = num; // boxing: converting value type to reference type...
                          // here num is value type  and obj is reference type..
                          // Generally object here stores the refrence of the actual data...
                          // now obj takes the reference of the boxed object num...

        // Unboxing example
        object obj1 = 42;      // reference type
        int num1 = (int)obj1; // unboxing: converting reference type back to value type...
                              // in unboxing we have to use casting (int) to convert reference type to value type...

        string str = "Hello, World!";
        string str1 = str;           // No boxing or unboxing involved here
        Console.WriteLine("str");   // Output: Hello, World!
        Console.WriteLine("str1"); // Output: Hello, World!


        string str2 = "Geya";
        Console.WriteLine("str2"); // Output: Geya











    }
}

