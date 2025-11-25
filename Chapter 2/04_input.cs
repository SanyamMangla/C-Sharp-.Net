using System;

public static class input
{
    public static void Show()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hey Hello " + name);
        
    
        Console.WriteLine("How many candies do you want?");
        string can = Console.ReadLine();
        Console.WriteLine("You will get 4 more candies: " + (Convert.ToInt32(can) + 4));
        Console.ReadLine();

    }
}
