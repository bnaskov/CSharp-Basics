// Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n has value of 1. 

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
        bool bitP = bit == 1;
        Console.WriteLine(bitP);
    }
}
