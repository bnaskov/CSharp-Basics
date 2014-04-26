using System;

class EasterMister
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = n - 1;
        int innerDots = n + 1;

        string firstLine = new string('.', n + 1) + new string('*', n - 1) + new string('.', n + 1);
        Console.WriteLine(firstLine);

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('*');
            Console.Write(new string('.', innerDots));
            Console.Write('*');
            Console.Write(new string('.', outerDots));
            innerDots += 4;
            outerDots -= 2;
            Console.WriteLine();
        }
        for (int i = 0; i < n / 2 - 1; i++)
        {
            string line = ".*" + new string('.', 3 * n - 3) + "*.";
            Console.WriteLine(line);
        }

        Console.Write(".*.");
        for (int i = 0; i < (3 * n - 4) / 2; i++)
        {
            Console.Write("#.");
        }
        Console.Write("*.");
        Console.WriteLine();
        Console.Write(".*");
        for (int i = 0; i < (3 * n - 4) / 2; i++)
        {
            Console.Write("#.");
        }
        Console.Write("#*.");
        Console.WriteLine();

        for (int i = 0; i < n / 2 - 1; i++)
        {
            string line = ".*" + new string('.', 3 * n - 3) + "*.";
            Console.WriteLine(line);
        }
        int newOuterDots = 3;
        int newInnerDots = 3 * n - 7;
        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.Write(new string('.', newOuterDots));
            Console.Write('*');
            Console.Write(new string('.', newInnerDots));
            Console.Write('*');
            Console.Write(new string('.', newOuterDots));
            newInnerDots -= 4;
            newOuterDots += 2;
            Console.WriteLine();
        }
        Console.WriteLine(firstLine);
    }
}
