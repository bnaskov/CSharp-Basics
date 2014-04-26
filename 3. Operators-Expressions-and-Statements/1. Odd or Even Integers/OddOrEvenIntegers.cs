// Problem 1. Write an expression that checks if given integer is odd or even.

using System;


class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Please enter a Number: ");
        int Number = int.Parse(Console.ReadLine());
        if (Number % 2 != 0)
        {
            Console.WriteLine("Odd: True");
        }
        else
        {
            Console.WriteLine("Odd: False");
        }
    }
}
