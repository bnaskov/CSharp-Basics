using System;

class StringsAndObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object greeting = string.Format("{0} {1}", a, b);
        string greetingString = greeting.ToString();
        Console.WriteLine(greetingString);
    }
}
