using System;

class SandGrass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int asterisk = n;
        int dots = 0;
        for (int i = 0; i < n /2 + 1; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('*', asterisk));
            Console.Write(new string('.', dots));
            dots++;
            asterisk -= 2;
            Console.WriteLine();
        }
        int newAsterisk = 3;
        int newDots = (n - 3) / 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', newDots));
            Console.Write(new string('*', newAsterisk));
            Console.Write(new string('.', newDots));
            newDots--;
            newAsterisk += 2;
            Console.WriteLine();
        }
    }
}
