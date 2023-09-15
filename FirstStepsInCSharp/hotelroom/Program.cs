
class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        int amountNights = int.Parse(Console.ReadLine());

        double priceStudio = 0;
        double priceApartment = 0;

        switch (month)
        {
            case "May":
            case "October":
                if (amountNights <= 7)
                {
                    priceStudio = amountNights * 50;
                }
                else if (amountNights < 14)
                {
                    priceStudio = (amountNights * 50) * 0.95;
                }
                else
                {
                    priceStudio = (amountNights * 50) * 0.7;
                }

                priceApartment = amountNights * 65;
                break;

            case "June":
            case "September":
                if (amountNights > 14)
                {
                    priceStudio = (amountNights * 75.2) * 0.8;
                }
                else
                {
                    priceStudio = amountNights * 75.2;
                }

                priceApartment = amountNights * 68.70;
                break;

            case "July":
            case "August":
                priceStudio = amountNights * 76;
                priceApartment = amountNights * 77;
                break;
        }

        if (amountNights > 14)
        {
            priceApartment *= 0.9;
        }

        Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
    }
}
