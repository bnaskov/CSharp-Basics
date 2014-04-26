// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigitis7
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int Number = int.Parse(Console.ReadLine());
        int Number100 = (Number / 100) % 10;
        bool Ncheck = (Number100 == 7);
        Console.WriteLine("\"The third digit from right to left is 7\" is: {0}", Ncheck);
    }
}
