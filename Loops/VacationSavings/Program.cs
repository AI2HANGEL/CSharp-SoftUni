using System;

class Program
{
    static void Main()
    {
        double moneyNeeded = double.Parse(Console.ReadLine());
        double availableMoney = double.Parse(Console.ReadLine());
        int consecutiveSpendDays = 0;
        int totalDays = 0;

        while (availableMoney < moneyNeeded)
        {
            string actionType = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());


            if (actionType == "spend")
            {
                availableMoney -= amount;
                if (availableMoney < 0)
                {
                    availableMoney = 0;
                }
                consecutiveSpendDays++;
            }
            else if (actionType == "save")
            {
                availableMoney += amount;
                consecutiveSpendDays = 0;
            }

            totalDays++;

            if (consecutiveSpendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(totalDays);
                return; // Exit the program
            }
        }

        Console.WriteLine($"You saved the money for {totalDays} days.");
    }
}
