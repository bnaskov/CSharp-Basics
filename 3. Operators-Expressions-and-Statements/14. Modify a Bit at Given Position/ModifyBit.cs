// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
// at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBit
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a bit position: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a bit value (0 or 1): ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine(v == 0 ? n & (~(1 << p)) : n = n | (1 << p));
    }
}
