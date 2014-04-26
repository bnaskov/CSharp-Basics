using System;

class MatrixNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        if ((n < 1) || (n > 20))
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                for (int a = i; a <= n + i; a++)
                {
                    Console.Write("{0,2} ", a);
                }
                Console.WriteLine();
            }
        }
    }
}
