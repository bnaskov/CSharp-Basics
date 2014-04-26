// Write a program that finds the biggest of three numbers. 

using System;

class TheBiggest3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double ab = Math.Max(a, b);
        double abc = Math.Max(ab, c);
        if (abc > ab)
        {
            Console.WriteLine(c);
        }
        else if (ab == a)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}