namespace TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PacksOfPens = int.Parse(Console.ReadLine());
            int PacksOfMarkers = int.Parse(Console.ReadLine());
            int LitresOfCleaner = int.Parse(Console.ReadLine());
            double PercentDiscount = double.Parse(Console.ReadLine()) / 100;

            double PricePens = PacksOfPens * 5.8;
            double PriceMarker = PacksOfMarkers * 7.2;
            double PriceCleaner = LitresOfCleaner * 1.2;

            double PriceAll = (PricePens + PriceMarker + PriceCleaner) - ((PricePens + PriceMarker + PriceCleaner) * PercentDiscount);
            Console.WriteLine(PriceAll);

        }   
    }
}