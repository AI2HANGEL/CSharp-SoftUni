using System;

class Program
{
    static void Main()
    {
        int dailySteps = 0;

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "Going home")
            {
                command = Console.ReadLine();
                dailySteps += int.Parse(command);
                break;
            }

            dailySteps += int.Parse(command);

            if (dailySteps >= 10000)
            {
                break;
            }
        }

        int diff = Math.Abs(dailySteps - 10000);

        if (dailySteps >= 10000)
        {
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{diff} steps over the goal!");
        }
        else
        {
            Console.WriteLine($"{diff} more steps to reach goal.");
        }
    }
}
