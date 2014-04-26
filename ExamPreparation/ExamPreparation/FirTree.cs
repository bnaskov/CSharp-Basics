using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int starCount = 1;
        int dotCount = n - 2;

        for (int i = 0; i < n - 1; i++)
			{
                Console.Write(new string('.', dotCount));
                Console.Write(new string('*', starCount));
                Console.Write(new string('.', dotCount));
                Console.WriteLine();                
                dotCount--;
                starCount += 2;
			}
        Console.Write(new string('.', n - 2));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', n - 2));
        Console.WriteLine();
    }
}

// for the first line string firstLine = new string('.', dotCount) + '*' + new string('.', dotCount);