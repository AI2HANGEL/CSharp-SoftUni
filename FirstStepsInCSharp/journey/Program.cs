using System;

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();

        string destination = "";
        string holidayType = "";
        double amountSpent = 0.0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                holidayType = "Camp";
                amountSpent = budget * 0.3;
            }
            else if (season == "winter")
            {
                holidayType = "Hotel";
                amountSpent = budget * 0.7;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                holidayType = "Camp";
                amountSpent = budget * 0.4;
            }
            else if (season == "winter")
            {
                holidayType = "Hotel";
                amountSpent = budget * 0.8;
            }
        }
        else
        {
            destination = "Europe";
            holidayType = "Hotel";
            amountSpent = budget * 0.9;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{holidayType} - {amountSpent:f2}");
    }
}
