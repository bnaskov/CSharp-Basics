// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class Sum5Numbers
{
    static void Main()
    {
        Console.Write("Please, write 5 numbers separated by a space: ");
        string[] userINput = Console.ReadLine().Split();
        double a = Convert.ToDouble(userINput[0]);
        double b = Convert.ToDouble(userINput[1]);
        double c = Convert.ToDouble(userINput[2]);
        double d = Convert.ToDouble(userINput[3]);
        double e = Convert.ToDouble(userINput[4]);
        double sumOfAll = a + b + c + d + e;
        Console.WriteLine(sumOfAll);
        }
}