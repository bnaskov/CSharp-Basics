using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("What's your age?");
        int CurrentAge = int.Parse(Console.ReadLine());
        int AgeAfter10Years = CurrentAge + 10;
        Console.WriteLine("Your age after 10 years will be: {0}!", AgeAfter10Years);
        }
}
