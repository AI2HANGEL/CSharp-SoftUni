namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double DepositedAmount = double.Parse(Console.ReadLine());
            int Months = int.Parse(Console.ReadLine());
            double AnnualInterest = double.Parse(Console.ReadLine()) / 100;
            double amount = DepositedAmount + Months * (DepositedAmount * AnnualInterest) / 12;
            Console.WriteLine(amount);
        }
    }
}