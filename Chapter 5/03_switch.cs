using System;

public static class switchDemo
{
    public static void Show()
    {
        int age = 20;

        switch (age)
        {
            case 18:
            Console.WriteLine("Please wait for an year");
            break;

            case 20:
            Console.WriteLine("You are 20");
            break;

            default:
            Console.WriteLine("Enjoy!");
            break;
        }
        

        Console.ReadLine();
    }
}
