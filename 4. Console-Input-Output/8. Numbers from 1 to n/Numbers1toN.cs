﻿// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
// each on a single line. Note that you may need to use a for-loop. 

using System;

class Numbers1toN
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}