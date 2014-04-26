using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());
        if (n < 2 || min > max)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            Random rand = new Random();
            int randNumber;
            for (int i = 0; i < n; i++)
            {
                randNumber = rand.Next(min, max + 1);
                Console.Write(randNumber + " ");
            }
        }
        Console.WriteLine();
    }
}
