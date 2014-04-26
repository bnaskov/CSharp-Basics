// Write a program that reads 3 real numbers from the console and prints their sum. 

using System;

class Sum3Numbers
{
    static void Main()
    {
        Console.Write("Enter number 1: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 3: ");
        double n3 = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the 3 numbers is: {0}.", n1 + n2 + n3);
    }
}