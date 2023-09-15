namespace BasketBallEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AnnualFee = int.Parse(Console.ReadLine());



            double Sneakers = AnnualFee - (AnnualFee * 0.4);
            double Team = Sneakers - (Sneakers * 0.2);
            double Ball = Team * 0.25;
            double Accesories = Ball * 0.2;

            double Total = AnnualFee + Sneakers + Team + Ball + Accesories;
            Console.WriteLine(Total);

        }
    }
}