namespace UsdToBgn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usdDollars = double.Parse(Console.ReadLine());
            double bulgarianlev = usdDollars * 1.79549;
            Console.WriteLine(bulgarianlev);
        }
    }
}