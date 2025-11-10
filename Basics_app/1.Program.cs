using System;



class MyProgram
    {
        static void Main()
        {
            //Console.WriteLine("Hello World!");
        
        // Numerical Data Types numbers
        // byte, short, int, uint, long, ulong, decimal and double

        byte age = 23;                                  // byte range from 0-255
        Console.WriteLine(age);


        short value = 1212;                            // Range from 32767 to -32768
        short value1 = -12;
        Console.WriteLine(value);
        Console.WriteLine(value1);


        ushort population = 50000;                   // Range from 0 to 65535   -- stores small number values
        Console.WriteLine(population);


        // int -- default data types for integers
        // Range from -2,147,483,648 to 2,147,483,647

        int salary = 25000;
        Console.WriteLine(salary);  //integer 


        //uint range from  -0 to 4,294,967,295
          uint distance = 30000000U;

        Console.WriteLine(distance);
        Console.WriteLine(100);  //int
        Console.WriteLine(100U); //Uint


        //Long
        // Range from -9223372036854775888 to 9223372036854775807
        long worldpopulation = 7800000000L;
        Console.WriteLine(worldpopulation);


        //ulong 
        // Range from 0 to -10,000,000,00,000,000
        ulong indiaGDP = 20000000000UL;
        Console.WriteLine(indiaGDP);




        // Floating Data Types
        // 0.68,    0.1215,     10,     10.0

        // decimal 
        // Range from 1.0*10^-28 to 7.9*10^28
        // purpose mainly used for money or financial transactions
        decimal price = 199.99M;
        Console.WriteLine(price);

        // float
        // Range from -3.40282347*10^38 to 3.40282347*10^38
        // purpose used in scientific  calculations.
        float pi = 3.14f;
        Console.WriteLine(pi);

        // Double
        // Range from +- 5.0810^-324 * +- 1.7*10^388
        // Purpose Mathematical Calculations(stocks)

        double db = 987.898d;
        Console.WriteLine(db);































    }
}
