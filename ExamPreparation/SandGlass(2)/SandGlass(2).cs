using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col >= row && row <= n - 1 - col)
                {
                    Console.Write('*');
                }
                else if (col <= row && row >= n - 1 - col)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}
