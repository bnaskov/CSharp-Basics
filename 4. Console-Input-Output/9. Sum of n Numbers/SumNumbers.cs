// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
// Note that you may need to use a for-loop.

using System;

class Numbers1toN
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0d;
        for (double i = 0; i < n; i++)
        {
            Console.Write("X = ");
            double num = double.Parse(Console.ReadLine());
            sum = sum + num;
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}