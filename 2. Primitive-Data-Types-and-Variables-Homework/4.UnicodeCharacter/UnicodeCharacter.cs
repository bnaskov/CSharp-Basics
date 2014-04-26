using System;

class UnicodeCharacter
{
    static void Main()
    {
        char symbol = '\u002A';
        Console.WriteLine("The code of '{0}' is {1}",
            symbol, (int)symbol);
    }
}
