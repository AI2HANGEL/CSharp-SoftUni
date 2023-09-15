namespace MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberOfPages = int.Parse(Console.ReadLine());  
            int Pages = int.Parse(Console.ReadLine());  
            int NumberOfDays = int.Parse(Console.ReadLine());

            int NumberOfHours = (NumberOfPages / Pages) / NumberOfDays;
            Console.WriteLine(NumberOfHours);

        }
    }
}