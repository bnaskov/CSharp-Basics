//Write an expression that checks for given point (x, y) 
// if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

    class InCircleOutRectangle
    {
        static void Main()
        {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        double r = 1.5;
        bool isInCircle = r * r >= (x - 1) * (x - 1) + (y - 1) * (y - 1);
        bool isInRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);
        Console.WriteLine(isInCircle && !isInRectangle ? "yes" : "no");
        }
    }


// Формулата в действителност е (x - h)*(x - h) + (y - k)*(y - k) = r * r , където h и k са началните координати на центъра на кръга