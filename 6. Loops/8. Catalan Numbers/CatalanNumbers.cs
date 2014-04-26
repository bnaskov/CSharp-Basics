using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        if ((n <= 1) || (n >= 100))
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            double result2nDEVnplus1 = 1;
            double resultNplus1 = 1;
            for (int a = n + 1; a <= (2 * n); a++)
            {
                result2nDEVnplus1 *= a;
            }
            for (int b = 2; b <= (n + 1); b++)
            {
                resultNplus1 *= b;
            }
            Console.WriteLine(result2nDEVnplus1 / resultNplus1);
        }
    }
}