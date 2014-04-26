using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger nElement = 0;
        if (n == 1)
        {
            Console.WriteLine(a);
        }
        else if (n == 2)
        {
            Console.WriteLine(b);
        }
        else if (n == 3)
        {
            Console.WriteLine(c);
        }
        else
        {
            for (int i = 0; i < n - 3; i++)
            {
                nElement = a + b + c;
                a = b;
                b = c;
                c = nElement;
            }
            Console.WriteLine(nElement);
        }
    }
}
