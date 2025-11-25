using System;

public static class forEachDemo
{
    public static void Show()
    {
        
        string[] fruits = { "Apple", "Banana", "Mango", "Orange", "Pineapple" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        int[] numbers = { 1, 2, 3, 4, 5 };

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        string name = "Sanyam";

        foreach (char ch in name)
        {
            Console.WriteLine(ch);
        }




        Console.ReadLine();
        
    }

}