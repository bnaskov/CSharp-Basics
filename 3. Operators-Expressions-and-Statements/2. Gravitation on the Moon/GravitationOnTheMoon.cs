﻿// Problem 2.Gravitation on the Moon
// The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth. Examples:


using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("What's your weight: ");
        double Weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on the Moon will be {0} kg!", Weight * 0.17);
    }
}
