namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ChickenMenuPrice = 10.35;
            double FishMenuPrice = 12.40;
            double VegMenuPrice = 8.15;

            int AmountOfChickenMenu = int.Parse(Console.ReadLine());    
            int AmountOfFishMenu = int.Parse(Console.ReadLine());
            int AmountOfVegMenu = int.Parse(Console.ReadLine());
            
            double NetPrice = (AmountOfChickenMenu * ChickenMenuPrice) +
                (AmountOfFishMenu * FishMenuPrice) +
                (AmountOfVegMenu * VegMenuPrice);

            double DesertPrice = NetPrice * 0.2;

            double PriceAll = NetPrice + DesertPrice + 2.5;

            Console.WriteLine(PriceAll);
        }
    }
}