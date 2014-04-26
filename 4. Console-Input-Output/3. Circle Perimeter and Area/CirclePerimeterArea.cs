// Write a program that reads the radius r of a circle and prints its perimeter and area 
// formatted with 2 digits after the decimal point. 


using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("r= ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("The perimeter of the circle is: {0:F2}", perimeter);
        Console.WriteLine("The area of the circle is: {0:F2}", area);
    }
}