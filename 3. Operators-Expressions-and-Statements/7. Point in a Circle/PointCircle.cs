// Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).

using System;

class PointCircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        if (x * x + y * y < 4)
        {
            Console.WriteLine("The point is inside the circle: True");
        }
        else
            {
            Console.WriteLine("The point is inside the circle: False");
            }
        }
}
