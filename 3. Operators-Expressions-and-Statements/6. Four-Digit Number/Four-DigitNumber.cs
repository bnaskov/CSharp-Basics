// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// • Calculates the sum of the digits (in our example 2+0+1+1 = 4).
// • Prints on the console the number in reversed order: dcba (in our example 1102).
// • Puts the last digit in the first position: dabc (in our example 1201).
// • Exchanges the second and the third digits: acbd (in our example 2101).
// The number has always exactly 4 digits and cannot start with 0. 


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a four digit number: ");
        int entNumber = int.Parse(Console.ReadLine());
        int frthDigit = entNumber % 10;
        int thrdDigit = (entNumber / 10) % 10;
        int scndDigit = (entNumber / 100) % 10;
        int frstDigit = (entNumber / 1000) % 10;
        int sumDigits = frstDigit + scndDigit + thrdDigit + frthDigit;

        Console.WriteLine("The sum of the digits is: {0}", sumDigits);
        Console.WriteLine("The reversed order of the digits is: {0}{1}{2}{3}", frthDigit, thrdDigit, scndDigit, frstDigit);
        Console.WriteLine("Last digit in the first position: {0}{1}{2}{3}", frthDigit, frstDigit, scndDigit, thrdDigit);
        Console.WriteLine("Last digit in the first position: {0}{1}{2}{3}", frstDigit, thrdDigit, scndDigit, frthDigit);
    }
}
