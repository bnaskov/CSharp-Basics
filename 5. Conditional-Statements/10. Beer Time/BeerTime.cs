// A beer time is after 1:00 PM and before 3:00 AM. 
// Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
// a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above 
// or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times. 

using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("What time is it (hh:mm TT) (for example: 4:23 AM): ");
        string input = Console.ReadLine();
        DateTime dateTime;
        if (DateTime.TryParse(input, out dateTime))
        {
            DateTime inputTime = DateTime.Parse(input);
            DateTime start = Convert.ToDateTime("01:00 PM");
            DateTime end = Convert.ToDateTime("03:00 AM");
            if ((inputTime >= end) && (inputTime < start))
            {
                Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}