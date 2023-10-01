string season = Console.ReadLine();
string accomodation = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
var price = 0.0;

if  (season == "Spring")
{
    if (accomodation == "Hotel")
    {
        price = (days * 30) * 0.8;
    }
    else if (accomodation == "Camping")
    {
        price = (days * 10) * 0.8;
    }
}
else if (season == "Summer")
{
    if (accomodation == "Hotel")
    {
        price = (days * 50);
    }
    else if (accomodation == "Camping")
    {
        price = (days * 30);
    }
}
else if (season == "Autumn")
{
    if (accomodation == "Hotel")
    {
        price = (days * 20) * 0.7;
    }
    else if (accomodation == "Camping")
    {
        price = (days * 15) * 0.7;
    }
}
else if (season == "Winter")
{
    if (accomodation == "Hotel")
    {
        price = (days * 40) * 0.9;
    }
    else if (accomodation == "Camping")
    {
        price = (days * 10) * 0.9;
    }
}

Console.WriteLine($"{price:F2}");