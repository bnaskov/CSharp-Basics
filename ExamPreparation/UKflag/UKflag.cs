using System;

class UKflag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int innerDots = n / 3;
        int outerDots = 0;

        for (int i = 0; i < n /2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('\\');
            Console.Write(new string('.', innerDots));
            Console.Write('|');
            Console.Write(new string('.', innerDots));
            Console.Write('/');
            Console.Write(new string('.', outerDots));
            Console.WriteLine();
            outerDots++;
            innerDots--;
        }
        Console.Write(new string('-', n/2));
        Console.Write('*');
        Console.Write(new string('-', n / 2));
        Console.WriteLine();

        int newOuterDots = n / 3;
        int newInnerDots = 0;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', newOuterDots));
            Console.Write('/');
            Console.Write(new string('.', newInnerDots));
            Console.Write('|');
            Console.Write(new string('.', newInnerDots));
            Console.Write('\\');
            Console.Write(new string('.', newOuterDots));
            Console.WriteLine();
            newOuterDots--;
            newInnerDots++;
        }
    }

}