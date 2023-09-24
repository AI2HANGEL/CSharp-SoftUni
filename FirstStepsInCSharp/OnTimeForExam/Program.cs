using System;

class Program
{
    static void Main()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
        int arriveHour = int.Parse(Console.ReadLine());
        int arriveMinute = int.Parse(Console.ReadLine());

        int examTotalTime = examHour * 60 + examMinute;
        int arriveTotalTime = arriveHour * 60 + arriveMinute;

        int timeDiff = Math.Abs(examTotalTime - arriveTotalTime);

        if (arriveTotalTime > examTotalTime)
        {
            Console.WriteLine("Late");
            if (timeDiff >= 60)
            {
                int hour = timeDiff / 60;
                int minutes = timeDiff % 60;
                Console.WriteLine($" {hour}:{minutes:D2} hours after the start");
            }
            else
            {
                Console.WriteLine($" {timeDiff} minutes after the start");
            }
        }
        else if (arriveTotalTime == examTotalTime || timeDiff <= 30)
        {
            Console.WriteLine("On time");
            if (timeDiff >= 1)
            {
                Console.WriteLine($"{timeDiff} minutes before the start");
            }
        }
        else
        {
            Console.WriteLine("Early");
            if (timeDiff >= 60)
            {
                int hour = timeDiff / 60;
                int minutes = timeDiff % 60;
                Console.WriteLine($" {hour}:{minutes:D2} hours before the start");
            }
            else
            {
                Console.WriteLine($"{timeDiff} minutes before the start");
            }
        }
    }
}
