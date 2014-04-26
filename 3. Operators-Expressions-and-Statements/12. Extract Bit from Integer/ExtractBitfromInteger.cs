// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitfromInteger
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter place: ");
        int p = int.Parse(Console.ReadLine());
        int nRightp = n >> p;
        int bit = nRightp & 1;
        Console.WriteLine(bit);
    }
}
