using System;

class EmployeesRecord
{
    static void Main()
    {
        string FirstName, LastName;
        byte Age;
        char Gender;
        long idNumber;
        int UniqueEmpNumber;

        FirstName = "Ivan";
        LastName = "Ivanov";
        Age = 25;
        Gender = 'M';
        idNumber = 8306112507;
        UniqueEmpNumber = 27569999;

        Console.WriteLine("Personal Information about {0} {1}:\nFirst Name: {0}\nFamily Name: {1}\nAge: {2}\nGender: {3}\nID Number: {4}\nUnique Employee Number: {5}",
            FirstName, LastName, Age, Gender, idNumber, 27560000 + UniqueEmpNumber);
    }
}
