using System;

class StringExamples
{

     public static void Main()
    {
        string myName = "Geya";
        Console.WriteLine(myName);

        string uCourseName = "\"Csharp\"";
        Console.WriteLine(uCourseName);

        string lstatus = "Hello \n World"; // will get line by line output
        Console.WriteLine(lstatus);

        string lstatus1 =  "Geya.  \n Sri.  \n Chavala"; // will get line by line output
        Console.WriteLine(lstatus1);


        string myProjectPath = "C:\\User\\Geya\\Documents\\Dotnetcore\\Basics_app";
        Console.WriteLine(myProjectPath);

        // Using another way
        string myProjectPath1 =  @"C:\\User\\Geya\\Documents\\Dotnetcore\\Basics_app";
        Console.WriteLine(myProjectPath1);

       
        // String Interpolation or String Expression //${}
        string sName = "Geya";
        int sAge = 22;

        string studentDetails = $"Student Name is : {sName} and Student Age is : {sAge}";
        Console.WriteLine(studentDetails);





    }
}
