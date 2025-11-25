using System;

public static class breakContinueDemo
{
    public static void Show()
    {
        
        // for(int i=0; i<5; i++)
        // {
        //     Console.WriteLine(i + 1);
        //     break;
        // }

        for(int i=0; i<5; i++)
        {
            if (i == 0)
            {
               continue;
            }
                
            Console.WriteLine(i + 1);
            
        }

        Console.ReadLine();
        
    }

}