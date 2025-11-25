using System;

public static class TypeCasting
{
    public static void Show()
    {
        // There are two types of type casting in C#:
        // 1. Implicit Casting (automatically) - converting a smaller type to a larger type size
        // char to int to long to float to double
        int x = 3;
        double y = x; // Implicit casting from int to double
        // int z = y; // This will cause a compile-time error

        // 2. Explicit Casting (manually) - converting a larger type to a smaller size type

        // int x = (int) 3.5; // Explicit casting from double to int

        float z = 'y';

        // Using Convert/Methods class for type casting
        float varr = Convert.ToInt32(3.55);
        // Convert.ToDouble
        // Convert.ToString
        string sx = "Random String";
       

         Console.WriteLine(x);
         Console.WriteLine(y);

        Console.ReadLine();
    }
}
