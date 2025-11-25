using System;

public static class functionsDemo
{
    public static void Show()
    {
        
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }

        static float Average(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum / 3;
        }

        Greet("Sanyam");
        Greet("Dhruv");

        Console.WriteLine(Average(2, 6, 8));
        Console.WriteLine(Average(3, 3, 3));
        

        Console.ReadLine();
    }
}
