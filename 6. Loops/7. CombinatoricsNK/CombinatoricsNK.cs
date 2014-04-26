using System;

class CombinatoricsNK
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
            double resultNdevK = 1;
            int resultNminusK = n - k;
            double NminusKfactorial = 1;
            for (double a = k + 1; a <= n; a++)
            {
                resultNdevK *= a;
            }
            for (int b = 1; b <= resultNminusK; b++)
            {
                NminusKfactorial *= b;
            }
            Console.WriteLine(resultNdevK / NminusKfactorial);
        }
    }
}