// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter rectangle's width: ");
        double RWidth = double.Parse(Console.ReadLine());
        Console.Write("Enter rectangle's height: ");
        double RHeight = double.Parse(Console.ReadLine());
        Console.WriteLine("The rectangle's perimeter is: {0}", (RWidth + RHeight) * 2);
        Console.WriteLine("The rectangle's area is: {0}", RWidth * RHeight);
    }
}
