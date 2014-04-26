// Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).

using System;

public class Program
{
    public static void Main()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number > 100) Console.WriteLine("Invalid number!!!");

        bool isPrime = true;

        if (number < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
        }
        Console.WriteLine(isPrime);
    }
}
