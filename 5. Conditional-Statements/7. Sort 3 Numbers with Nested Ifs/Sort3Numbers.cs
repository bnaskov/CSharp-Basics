// Write a program that enters 3 real numbers and prints them sorted in descending order. 
// Use nested if statements. Don’t use arrays and the built-in sorting functionality.

using System;

class Sort3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if ((a > c) && (c > b))
        {
            Console.WriteLine("{0} {1} {2}", a, c, b);
        }
        else if ((a > b) && (b > c))
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
        else if ((b > a) && (a > c))
        {
            Console.WriteLine("{0} {1} {2}", b, a, c);
        }
        else if ((b > c) && (c > a))
        {
            Console.WriteLine("{0} {1} {2}", b, c, a);
        }
        else if ((c > a) && (a > b))
        {
            Console.WriteLine("{0} {1} {2}", c, a, b);
        }
        else
        {
            Console.WriteLine("{0} {1} {2}", c, b, a);
        }
    }
}