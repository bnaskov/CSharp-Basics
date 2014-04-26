using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int FirstVariable = 5;
        int SecondVariable = 10;
        Console.WriteLine("the first variable is {0}, The second variable is {1}", FirstVariable, SecondVariable);

        SecondVariable = SecondVariable - FirstVariable;
        FirstVariable = FirstVariable + FirstVariable;
        Console.WriteLine("the first variable is {0}, The second variable is {1}", FirstVariable, SecondVariable);
    }
}
