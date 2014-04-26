using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? someInteger = null;
        double? someDouble = null;
        Console.WriteLine("This is the integer with null value -> {0} ", someInteger);
        Console.WriteLine("This is the double with null value -> {0}", someDouble);

        someInteger = 10;
        someDouble = 10.8;
        Console.WriteLine("This is the integer with null value 10 -> " + someInteger);
        Console.WriteLine("This is the double with null value 10,8 -> " + someDouble);
    }
}
