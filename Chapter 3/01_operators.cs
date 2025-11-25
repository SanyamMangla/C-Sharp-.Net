using System;

public static class OperatorsDemo
{
    public static void Show()
    {

        // Operators in C#

        // 1. Arithmetic Operators
        // int a = 4;
        // int b = 2;
        // Console.WriteLine("The value of a + b is: " + (a + b));
        // Console.WriteLine("The value of a - b is: " + (a - b));
        // Console.WriteLine("The value of a * b is: " + (a * b));
        // Console.WriteLine("The value of a / b is: " + (a / b));
  
        // 2. Assignment Operators
        // int a = 4;
        // int b = a;
        // b += 4;
        // b -= 4;
        // b *= 4;
        // b /= 4;
        // Console.WriteLine(b);

        // 3. Logical Operators
        // Console.WriteLine(true && false); // AND operator
        // Console.WriteLine(true && true); // AND operator
        // Console.WriteLine(false && true); // AND operator
        // Console.WriteLine(false && false); // AND operator

        // Console.WriteLine(true || false); // OR operator
        // Console.WriteLine(true || true); // OR operator
        // Console.WriteLine(false || true); // OR operator
        // Console.WriteLine(false || false); // OR operator

        // Console.WriteLine(!false); // NOT operator
        // Console.WriteLine(!true); // NOT operator

        // 4. Comparison Operators
        // Console.WriteLine(55 > 5);
        // Console.WriteLine(55 <= 5);
        // Console.WriteLine(55 >= 5);
        // Console.WriteLine(55 != 55); // != not equal to
        // Console.WriteLine(55 == 5); // == equal to

        // 5. Unary Operators
        int a = 4;
        Console.WriteLine(a++); // prints 4, then a becomes 5
        Console.WriteLine(++a); // a becomes 6, then prints 6
        Console.WriteLine(a--); // prints 6, then a becomes 5
        Console.WriteLine(--a); // a becomes 4, then prints 4   
        Console.WriteLine(-a);  // prints -4
        Console.WriteLine(+a);  // prints 4
        

        
        Console.ReadLine();
    }
}
