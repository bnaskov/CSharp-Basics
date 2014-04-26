//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
//The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 

using System;

    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int nRightp = n >> p;
            int bit = nRightp & 1;
            Console.WriteLine(bit);
        }
    }
