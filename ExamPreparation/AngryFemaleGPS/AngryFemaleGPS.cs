using System;

class AngryFemaleGPS
{
    static void Main()
    {
        long m = long.Parse(Console.ReadLine());
        long n = Math.Abs(m);
        string p = n.ToString();
        long sumOdd = 0;
        long sumEven = 0;
        for (int i = 0; i < p.Length; i++)
        {
            if (p[i] % 2 != 0)
            {
                sumOdd += long.Parse(p[i].ToString());
            }
            else if (p[i] % 2 == 0)
            {
                sumEven += long.Parse(p[i].ToString());
            }
        }
        if (sumOdd > sumEven)
        {
            Console.WriteLine("left {0}", sumOdd);
        }
        else if (sumOdd < sumEven)
        {
            Console.WriteLine("right {0}", sumEven);
        }
        else if (sumOdd == sumEven)
        {
            Console.WriteLine("straight {0}", sumEven);
        }
    }
}
