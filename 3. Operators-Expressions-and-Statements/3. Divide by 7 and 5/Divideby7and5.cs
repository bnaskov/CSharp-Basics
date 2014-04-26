// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class Divideby7and5
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int Number = int.Parse(Console.ReadLine());
        if (Number % 5 == 0 && Number % 7 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
    }
}  