// Write a program that reads two arrays from the console and compares them element by element.


using System;
using System.Collections.Generic;

class ComparingTwoArrays
{
    static void Main()
    {
        int array1Length = int.Parse(Console.ReadLine());
        int[] array1 = new int [array1Length];
        for (int i = 0; i < array1Length; i++)
        {
            int a = int.Parse(Console.ReadLine());
            array1[i] = a;
        }
        Console.WriteLine();
        int array2Length = int.Parse(Console.ReadLine());
        int[] array2 = new int[array2Length];
        for (int i = 0; i < array2Length; i++)
        {
            int a = int.Parse(Console.ReadLine());
            array2[i] = a;
        }
        if (array1Length !=  array2Length)
        {
            Console.WriteLine("The two arrays are not the same length!");
        }
        else
        {
            bool arr1arr2 = false;
            for (int i = 0; i < array1Length; i++)
            {
                arr1arr2 = (array1[i] == array2[i]);
            }
            Console.WriteLine("The two arrays have equal elements: {0}", arr1arr2);
        }
    }
}