string drink = Console.ReadLine();
string extra = Console.ReadLine();

double price = 0;


if (drink != "coffee" && drink != "tea")
{
    Console.WriteLine("Unknown drink");
    return;
}
else if (extra != "sugar" &&  extra != "no")
{
    Console.WriteLine("Unknown extra");
    return;
}


if (drink == "coffee")
{
    if (extra == "sugar")
    {
        price = 1 + 0.4;
    }
    else
    {
        price = 1;
    }
}

else if (drink == "tea")
{
    if (extra == "sugar")
    {
        price = 0.6 + 0.4;
    }
    else
    {
        price = 0.6;
    }
}


Console.WriteLine($"Final price: ${price:F2}");