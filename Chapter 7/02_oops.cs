using System;

public static class oopsDemo
{
    public static void Show()
    {
        
        Player tommy = new Player();
        Console.WriteLine(tommy.health);
        tommy.setHealth(57);
        Console.WriteLine(tommy.health);
        Console.ReadLine();
        
    }
}
