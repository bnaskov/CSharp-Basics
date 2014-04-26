using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter trapezoid's baseA: ");
        double baseA = double.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid's baseB: ");
        double baseB = double.Parse(Console.ReadLine());
        Console.Write("Enter trapezoid's height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("The trapezoid's area is: {0}", (baseA / 2 + baseB / 2) * height);
    }
}
