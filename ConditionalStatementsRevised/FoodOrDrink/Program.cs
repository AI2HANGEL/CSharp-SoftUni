string product = Console.ReadLine();
bool isfood = false;

List<string> foodList = new List<string>
        {
            "curry",
            "noodles",
            "sushi",
            "spaghetti",
            "bread"
        };

List<string> drinkList = new List<string>
        {
            "tea",
            "water",
            "coffee",
            "juice",
        };

if (foodList.Contains(product))
{
    isfood = true;
}
else if (drinkList.Contains(product))
{
    isfood = false;
}
else
{
    Console.WriteLine("unknown");
    return;
}

if (isfood)
{
    Console.WriteLine("food");
}
else
{
    Console.WriteLine("drink");
}
