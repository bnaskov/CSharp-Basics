using System;

class Print10MembersOfSequence
{
    static void Main()
    {
        for (int b = 2; b <= 11; b++)
        {
            if (b % 2 == 0)
            {
                Console.Write(b);
            }
            else
            {
                Console.Write(-b);
            }
        }
    }
}