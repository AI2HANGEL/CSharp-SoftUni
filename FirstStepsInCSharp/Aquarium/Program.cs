using System;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length_cm = int.Parse(Console.ReadLine());
            int width_cm = int.Parse(Console.ReadLine());
            int height_cm = int.Parse(Console.ReadLine());
            double percent_sand = double.Parse(Console.ReadLine());

            double volume = length_cm * width_cm * height_cm;
            double volume_in_lt = volume * 0.001;
            double occupied_volume = percent_sand / 100;
            double required_lt = volume_in_lt * (1 - occupied_volume);

            // Format required_lt to two decimal places when printing
            Console.WriteLine(required_lt.ToString("0.00"));
        }
    }
}
