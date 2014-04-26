using System;

class Print10MembersOfSequence
{
    static void Main()
    {
        for (int n = 2; n <= 11; n++)
        {
            Console.WriteLine(n*Math.Pow(-1,n));
        }
    }
}