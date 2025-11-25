using System;

public static class StringsDemo
{
    public static void Show()
    {
        // string hello = "Hello world this is harry";
        // Console.WriteLine(hello.Length); // length of string
        // Console.WriteLine(hello.ToUpper()); // convert to uppercase
        // Console.WriteLine(hello.ToLower()); // convert to lowercase
        // Console.WriteLine(hello + "You are nice"); // concatenation of strings
        // Console.WriteLine(string.Concat(hello , "You are nice")); // alternative way to concatenate strings
        
        // string name = Console.ReadLine(); 
        // string candies = Console.ReadLine();
        // Console.WriteLine($"Your name is {name}. You will get {candies}"); // string interpolation

        string hello = "Hello world this is harry";
        // Console.WriteLine(hello[0]); // accessing character at index 0
        // Console.WriteLine(hello.IndexOf("world")); // finding index of substring
        Console.WriteLine(hello.Substring(1)); // getting substring from index 1 to end


        // Console.ReadLine();
    }
}
