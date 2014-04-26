using System;

class BankAccountData
{
    static void Main()
    {
        string FirstName = "Ivan";
        string MiddleName = "Ivanov";
        string LastName = "Ivanov";
        double Balance = 20000;
        string BankName = "DSK";
        string IBAN = "CH93 0076 2011 6238 5295 7";
        ulong CreditCard1 = 6011016011016011;
        ulong CreditCard2 = 3566003566003566;
        ulong CreditCard3 = 371449635398431;
        Console.WriteLine("Personal information about: \nFirst Name: {0}\nMiddle Name: {1}\nLastName: {2}\nBalance: {3}\nBank Name: {4}\nIBAN: {5}\nCreditCard1: {6}\nCreditCard2: {7}\nCreditCard3: {8}\n",
        FirstName, MiddleName, LastName, Balance, BankName, IBAN, CreditCard1, CreditCard2, CreditCard3);
    }
}
