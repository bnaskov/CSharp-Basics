// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, 
// on a single line, separated by a space. 

using System;

class NotDivisible3And7All1ToNNumbers
{
    static void Main()
    {
        Console.Write("Please, enter a whole positive number for N = ");
        int numberN = int.Parse(Console.ReadLine());
        if (numberN < 1)
        {
            Console.WriteLine("Error - Invalid Number !!!");
        }
        else
        {
            int num = 0;
            Console.Write("The all numbers from 1 to that number N, witch are not divisible"
        + " by 3 and 7 at the same time, are: ");
            for (int i = 1; i <= numberN; i++)
            {
                if ((i % 5 == 0) || (i % 7 == 0))
                {
                   continue;
                }
                num = i;
                Console.Write(" {0}", num);
            }
            Console.WriteLine();
        }
    }
}