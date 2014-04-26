using System;

class QuotesInStrings
{
    static void Main()
    {
        string Quote1 = "The \"use\" of quotations causes difficulties.";
        string Quote2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("{0}", Quote1);
        Console.WriteLine("{0}", Quote2);
    }
}
