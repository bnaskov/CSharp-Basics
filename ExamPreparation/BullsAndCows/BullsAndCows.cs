using System;

class BullsAndCows
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int firstDigit = (n /1000) % 10;
        int scnDigit = (n / 100) % 10;
        int thirdDigit = (n / 10) % 10;
        int forthDigit = n  % 10;
        for (int a = 1; a < 10; a++)
        {
            for (int b = 1; b < 10; b++)
            {
                for (int c = 1; c < 10; c++)
                {
                    for (int d = 1; d < 10; d++)
                    {
                        Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
                    }
                }
            }
        }
    }
}