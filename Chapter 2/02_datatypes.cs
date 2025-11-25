using System;

public static class DataTypesDemo
{
    public static void Show()
    {

    // int harry = 34; //Interger Variable
    // string inp = Console.ReadLine();
    // Console.WriteLine(inp);


    // Data Types Examples in C#
    int a = 1;                 // integer

    double b = 6.34D;           // floating-point number (double by default)

    float f = 6.33F;           // floating-point number (float)

    string c = "Sanyam";       // string

    bool d = false;            // boolean

    object e = null;           // null (similar to Python's None)

    // Print all values in one line using string interpolation:
        Console.WriteLine($"a = {a}, b = {b}, f = {f}, c = {c}, d = {d}, e = {e}");

        // Or print each on its own line:
        Console.WriteLine("---- Individual values ----");
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
        Console.WriteLine("f: " + f);
        Console.WriteLine("c: " + c);
        Console.WriteLine("d: " + d);
        Console.WriteLine("e: " + (e ?? "null"));


    //    Data Types in C# 
    // Integer - int harry;  ---> 4 bytes
    // Long - long harry; ---> 8 bytes
    // Floating point number - float that;  ---> 4 bytes
    // Double - double harry;  ---> 8 bytes
    // Character - char a = 'A';  ---> 2 bytes
    // Boolean - bool isGreat = true; ---> 1 bit    1byte = 8 bits
    // String - string inp = "Sanyam";  ---> 2 bytes per character

    Console.ReadLine();
    }
}
