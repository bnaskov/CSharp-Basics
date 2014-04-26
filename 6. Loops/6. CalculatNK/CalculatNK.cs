using System;

class CalculatNK
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        if ((n >= 100) || (k <= 1) || (k >= n))
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            ulong result = 1;
            for (int index = k + 1; index <= n; index++)
            {
                result *= (ulong)index;
            }
            Console.WriteLine(result);
        }
    }
}