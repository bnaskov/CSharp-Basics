// Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class Biggest5Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());

        double ab = Math.Max(a, b);
        double cd = Math.Max(c, d);
        double abcd = Math.Max(ab, cd);
        if (e > abcd)
        {
            Console.WriteLine(e);
        }
        else if (a == abcd)
        {
            Console.WriteLine(a);
        }
        else if (b == abcd)
        {
            Console.WriteLine(b);
        }
        else if (c == abcd)
        {
            Console.WriteLine(c);
        }
        else if (d == abcd)
        {
            Console.WriteLine(d);
        }
    }
}