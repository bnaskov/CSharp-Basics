// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
// Print the obtained array on the console.


using System;
using System.Collections.Generic;

class IntegersMultipliedByFive
{
    static void Main()
    {
        int[] array = new int[20];
        for (int i = 0; i < 20; i++)
        {
            array[i] = i;
        }
        for (int a = 0; a < 20; a++)
        {
            Console.Write(a + " ");
        }
        Console.WriteLine();
        int[] arrayCopy = (int[])array.Clone();
        for (int i = 0; i < 20; i++)
        {
            arrayCopy[i] = i * 5;
        }
        for (int i = 0; i < 20; i++)
        {
            Console.Write(arrayCopy[i] + " ");
        }
        Console.WriteLine();
    }
}
