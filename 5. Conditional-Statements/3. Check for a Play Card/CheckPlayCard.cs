﻿// Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
// Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 

using System;

class CheckPlayCard
    {
    static void Main()
        {
        Console.Write("Enter your sign: ");
        string sign = Console.ReadLine();
 
        switch (sign)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                Console.WriteLine("yes");
                break;
            default: Console.WriteLine("no");
                break;
        }
    }
}


        //Console.Write("Card: ");
        //string card = Console.ReadLine();
        //string allCards = "2 3 4 5 6 7 8 9 10 J Q K A";
        //bool check = allCards.Contains(card);
        //Console.WriteLine(check ? "Yes" : "No");