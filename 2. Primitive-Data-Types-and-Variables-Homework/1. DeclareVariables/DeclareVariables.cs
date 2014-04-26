using System;

class DeclareVariables
{
    static void Main()
    {
        ushort AverageAnnualSalary = 52130;
        sbyte Temperature = -115;
        int MoneyInTheBank = 4825932;
        byte Age = 97;
        short LastMonthProfit = -10000;

        Console.WriteLine(
            "The average anual salary of my friend is {0}. The temperature on planet Mars reaches {1} C. My fiancee has {2} USD in the bank. My grandfather is {3} years old. The last month's profits are {4} BGN.",
            AverageAnnualSalary, Temperature, MoneyInTheBank, Age, LastMonthProfit);
    }
}
