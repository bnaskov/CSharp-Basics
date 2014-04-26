﻿using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int p = int.Parse(Console.ReadLine());
            int pNew = 0;

            while (p != 0)
            {
                pNew <<= 1;
                int firstBit = p & 1;
                pNew |= firstBit;
                p >>= 1;
            }
            Console.WriteLine(pNew);
        }
    }
}
