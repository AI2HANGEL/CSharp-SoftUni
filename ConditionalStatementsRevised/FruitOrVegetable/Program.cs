string product = Console.ReadLine();
bool isfood = false;

List<string> fruitList = new List<string>
        {
            "banana",
            "apple",
            "kiwi",
            "cherry",
            "lemon"
        };

List<string> vegList = new List<string>
        {
            "cucumber",
            "pepper",
            "carrot",
        };

if (fruitList.Contains(product))
{
    isfood = true;
}
else if (vegList.Contains(product))
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
    Console.WriteLine("fruit");
}
else
{
    Console.WriteLine("vegetable");
}
