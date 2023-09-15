namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeofstring = Console.ReadLine();
            int numberofrows = int.Parse(Console.ReadLine());
            int numberofcolumns = int.Parse(Console.ReadLine());
            double income = 0.0;

            double PremierePrice = 12.00;
            double NormalPrice = 7.50;
            double Discounted = 5.0;

            if  (typeofstring == "Premiere")
                {
                income = PremierePrice * numberofcolumns * numberofrows;
            }
            else if (typeofstring == "Normal")
            {
                income = NormalPrice * numberofcolumns * numberofrows;
            }
            else if (typeofstring == "Discount")
            {
                income = Discounted * numberofcolumns * numberofrows;
            }

            Console.WriteLine("{0:f2} leva", income);
        }
    }
}