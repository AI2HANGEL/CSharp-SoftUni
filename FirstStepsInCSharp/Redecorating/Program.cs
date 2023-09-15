namespace Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int paint_sol = int.Parse(Console.ReadLine());
            int work_hours = int.Parse(Console.ReadLine());

            double nylon_sum = (nylon + 2) * 1.50;
            double paint_sum = (paint * 1.1) * 14.50;
            double paint_sol_sum = paint_sol * 5;
            double bags = 0.4;

            double total_sum = nylon_sum + paint_sum + paint_sol_sum + bags;
            double workers_sum = (total_sum * 0.3) * work_hours;

            Console.WriteLine(total_sum + workers_sum);
        }
    }
}