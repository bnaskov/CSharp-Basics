// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
// on a single line, separated by a space. 

using System;

class Numbers1toN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int num = 0;
        for (int i = 0; i < n; i++)
        {
            num += 1;
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}