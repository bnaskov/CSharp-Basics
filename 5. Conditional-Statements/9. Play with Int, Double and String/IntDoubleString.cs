// Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
// If the variable is int or double, the program increases it by one. 
// If the variable is a string, the program appends "*" at the end. 
// Print the result at the console. Use switch statement.

using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Enter a int: ");
                int intNum = int.Parse(Console.ReadLine());
                Console.WriteLine(intNum + 1);
                break;
            case 2:
                Console.Write("Enter a double: ");
                double dNum = double.Parse(Console.ReadLine());
                Console.WriteLine(dNum + 1);
                break;
            case 3:
                Console.Write("Enter a string: ");
                string word = Console.ReadLine();
                Console.WriteLine(word + "*");
                break;
            default:
                Console.WriteLine("invalid entry");
                break;
        }
    }
}