using System;

    class KaspichaniaBoats
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int outerDots = n - 1;
            int innerDots = 0;
            Console.WriteLine(new string('.', n) + new string('*', 1) + new string('.', n));
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write('*');
                Console.Write(new string('.', innerDots));
                Console.Write('*');
                Console.Write(new string('.', innerDots));
                Console.Write('*');
                Console.Write(new string('.', outerDots));
                outerDots--;
                innerDots++;
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', 2 * n + 1));
            int newOuterDots = 1;
            int newInnerDots = (n * 2 - 3) / 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', newOuterDots));
                Console.Write('*');
                Console.Write(new string('.', newInnerDots));
                Console.Write('*');
                Console.Write(new string('.', newInnerDots));
                Console.Write('*');
                Console.Write(new string('.', newOuterDots));
                newOuterDots++;
                newInnerDots--;
                Console.WriteLine();
            }
            Console.WriteLine(new string('.', (n + 1) / 2) + new string('*', n) + new string('.', (n + 1) / 2));
        }
    }