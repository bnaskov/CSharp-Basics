// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string mFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string mLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int mAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string mPhone = Console.ReadLine();
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", 
        companyName, companyAddress, phoneNumber, faxNumber, webSite, mFirstName, mLastName, mAge, mPhone);
    }
}