int money = int.Parse(Console.ReadLine());
int withraw = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

if (withraw > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else if (money < withraw)
{
    Console.WriteLine("Insufficient availability.");
}
else
{
    Console.WriteLine("The withdraw was successful.");
}